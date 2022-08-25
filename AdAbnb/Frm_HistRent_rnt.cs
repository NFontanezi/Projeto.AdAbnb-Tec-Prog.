using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdAbnb.Domain;
using AdAbnb.Repositories;

namespace AdAbnb.Presentation
{
    public partial class Frm_HistRent_rnt : Form
    {
        static DataTable dt2 = new DataTable();

        Person User { get; set; }

        List<Property> Properties { get; set; }

        public Frm_HistRent_rnt(Person user)
        {
            InitializeComponent();
            User = user;
            Properties = user.usersPropRented;
        }

        private void Frm_HistRent_rnt_Load(object sender, EventArgs e)
        {
            dtv2.DataSource = null;
            dt2 = ConvertToDatatable(Properties);

            dtv2.DataSource = dt2;
            ConfigurarGrade(dtv2);
            CarregarFotos(dtv2);
        }

        static DataTable ConvertToDatatable(List<Property> list)
        {
            if (!dt2.Columns.Contains("ID_prop"))
            {
                dt2.Columns.Add("ID_prop");
                dt2.Columns.Add("District");
                dt2.Columns.Add("City");
                dt2.Columns.Add("State");
                dt2.Columns.Add("Footage");
                dt2.Columns.Add("Daily");
                dt2.Columns.Add("Active");
                dt2.Columns.Add("imagetext");

                dt2.Columns.Add("Piscina", typeof(bool));
                dt2.Columns.Add("AC", typeof(bool));
                dt2.Columns.Add("ProxMar", typeof(bool));
                dt2.Columns.Add("PetFriendly", typeof(bool));
                dt2.Columns.Add("Vaga", typeof(bool));
                dt2.Columns.Add("ProxTransp", typeof(bool));

            }


            
            if(Frm_AdvToRent_rnt.clickAlugar == 1)
            {
                dt2.Clear();

                foreach (var item in list)
                {
                    var row = dt2.NewRow();

                    var piscina = item.Piscina;
                    var ac = item.AC;
                    var proxMar = item.ProxMar;
                    var petFriendly = item.PetFriendly;
                    var vaga = item.Vaga;
                    var proxTranspPublico = item.ProxTransp;


                    row["ID_prop"] = item.ID_prop;
                    row["District"] = item.Daily;
                    row["City"] = item.City;
                    row["State"] = item.State;
                    row["Footage"] = item.Footage;
                    row["Daily"] = item.Daily;
                    row["Active"] = item.Active;
                    row["imagetext"] = item.imagetext;
                    row["Piscina"] = piscina;
                    row["AC"] = ac;
                    row["ProxMar"] = proxMar;
                    row["PetFriendly"] = petFriendly;
                    row["Vaga"] = vaga;
                    row["ProxTransp"] = proxTranspPublico;

                    Frm_AdvToRent_rnt.clickAlugar = 0;

                    dt2.Rows.Add(row);

                }

            }

            return dt2;
        }


        private void ConfigurarGrade(DataGridView dtv2)
        {

            dtv2.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 11);
            dtv2.DefaultCellStyle.Font = new Font("Arial", 10);
            dtv2.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dtv2.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


            dtv2.Columns[5].HeaderText = "Diária";
            dtv2.Columns[5].Width = 80;
            dtv2.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtv2.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dtv2.Columns[2].HeaderText = "Cidade";
            dtv2.Columns[2].Width = 80;
            dtv2.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtv2.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dtv2.Columns[1].HeaderText = "Bairro";
            dtv2.Columns[1].Width = 80;
            dtv2.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtv2.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dtv2.Columns[3].HeaderText = "Estado";
            dtv2.Columns[3].Width = 80;
            dtv2.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtv2.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dtv2.Columns[6].HeaderText = "Ativo";
            dtv2.Columns[6].Width = 80;
            dtv2.Columns[6].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtv2.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dtv2.Columns[4].HeaderText = "Metragem";
            dtv2.Columns[4].Width = 80;
            dtv2.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtv2.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


            dtv2.Columns[7].Visible = false;
            dtv2.Columns[1].Visible = false;
            dtv2.Columns[0].Visible = false;
            dtv2.Columns[6].Visible = false;
            dtv2.Columns[8].Visible = false;
            dtv2.Columns[9].Visible = false;
            dtv2.Columns[10].Visible = false;
            dtv2.Columns[11].Visible = false;
            dtv2.Columns[12].Visible = false;
            dtv2.Columns[13].Visible = false;

            dtv2.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

            DataGridViewImageColumn col = new();
            col.Name = "Image"; // -- 14
            col.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dtv2.Columns.Add(col);
            dtv2.Columns[14].HeaderText = "Foto";
            dtv2.Columns[14].Width = 64;

        }

        public void CarregarFotos(DataGridView dtv)
        {
            foreach (DataGridViewRow row in dtv.Rows)
            {
                Uri uri = new Uri(row.Cells[7].Value.ToString());
                row.Cells[14].Value = GetImageFromUrl(uri);
            }
        }


        public static Image GetImageFromUrl(Uri uri)
        {
            HttpWebRequest httpWebRequest = (HttpWebRequest)HttpWebRequest.Create(uri);

            using (HttpWebResponse httpWebReponse = (HttpWebResponse)httpWebRequest.GetResponse())
            {
                using (Stream stream = httpWebReponse.GetResponseStream())
                {
                    return Image.FromStream(stream);
                }
            }
        }

        private void dtv2_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var path = dtv2.Rows[dtv2.CurrentCell.RowIndex].Cells["imagetext"].Value.ToString();

            Form frm = new Form_Img_Adv(path);
            frm.ShowDialog();
        }

        //private void btnBack_Click(object sender, EventArgs e)
        //{
        //    var t = new Thread(() => Application.Run(new Frm_ClientArea(User)));
        //    this.Close();
        //    t.Start();
        //}
    }
}
