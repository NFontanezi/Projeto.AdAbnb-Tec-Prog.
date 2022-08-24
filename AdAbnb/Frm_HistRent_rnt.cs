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
        //List<Property> listPropRented = UsersRentDB.usersPropRented;
        static DataTable dt2 = new DataTable();

        public Frm_HistRent_rnt()
        {
            InitializeComponent();
        }

        private void Frm_HistRent_rnt_Load(object sender, EventArgs e)
        {
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = ConvertToDatatable(UsersRentDB.usersPropRented);
            ConfigurarGrade();
            CarregarFotos(dataGridView2);
        }

        static DataTable ConvertToDatatable(List<Property> list)
        {

            //ID_prop = count_prop++;
            //District = district;
            //City = city;
            //State = state;
            //Footage = footage;
            //Daily = daily;
            //Active = active;
            //imagetext = image;

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


                //dt2.Rows.Add(row);

            }

            return dt2;
        }


        private void ConfigurarGrade()
        {
            dataGridView2.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 11);
            dataGridView2.DefaultCellStyle.Font = new Font("Arial", 10);
            dataGridView2.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView2.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


            dataGridView2.Columns["Daily"].HeaderText = "Diária";
            dataGridView2.Columns["Daily"].Width = 80;
            dataGridView2.Columns["Daily"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView2.Columns["Daily"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridView2.Columns["City"].HeaderText = "Cidade";
            dataGridView2.Columns["City"].Width = 80;
            dataGridView2.Columns["City"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView2.Columns["City"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridView2.Columns["District"].HeaderText = "Bairro";
            dataGridView2.Columns["District"].Width = 80;
            dataGridView2.Columns["District"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView2.Columns["District"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridView2.Columns["State"].HeaderText = "Estado";
            dataGridView2.Columns["State"].Width = 80;
            dataGridView2.Columns["State"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView2.Columns["State"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridView2.Columns["Active"].HeaderText = "Ativo";
            dataGridView2.Columns["Active"].Width = 80;
            dataGridView2.Columns["Active"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView2.Columns["Active"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridView2.Columns["Footage"].HeaderText = "Metragem";
            dataGridView2.Columns["Footage"].Width = 80;
            dataGridView2.Columns["Footage"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView2.Columns["Footage"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


            dataGridView2.Columns["imagetext"].Visible = false;

            dataGridView2.Columns["Active"].Visible = false;
            dataGridView2.Columns["Piscina"].Visible = false;
            dataGridView2.Columns["AC"].Visible = false;
            dataGridView2.Columns["ProxMar"].Visible = false;
            dataGridView2.Columns["PetFriendly"].Visible = false;
            dataGridView2.Columns["Vaga"].Visible = false;
            dataGridView2.Columns["ProxTransp"].Visible = false;

            dataGridView2.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

            DataGridViewImageColumn col = new();
            col.Name = "Image";
            col.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dataGridView2.Columns.Add(col);
            dataGridView2.Columns["Image"].HeaderText = "Foto";
            dataGridView2.Columns["Image"].Width = 64;

        }

        public void CarregarFotos(DataGridView dtv)
        {
            foreach (DataGridViewRow row in dtv.Rows)
            {
                Uri uri = new Uri(row.Cells["imagetext"].Value.ToString());
                row.Cells["Image"].Value = GetImageFromUrl(uri);
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
    }
}
