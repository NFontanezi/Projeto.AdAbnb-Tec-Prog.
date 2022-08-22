using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdAbnb.Domain;
using System.Net;

namespace AdAbnb.Presentation
{
    public partial class frmLoginArea_MyAdvs : Form
    {
        public DataTable dtF = new DataTable();
        Owner owner { get; set; }
        List<Property> list1 { get; set; }

        List<string> f;
        public frmLoginArea_MyAdvs(Owner owner)
        {

            this.owner = owner;
            list1 = owner.PropertyList;

            InitializeComponent();

        }

        private void LoginArea_MyAdvs_Load(object sender, EventArgs e)
        {
            //dataGridView_adv.DataSource = GetAnuncios(dtF);
            // ConfigurarGrade();
            //  CarregarFotos();
            dataGridView_adv.DataSource = null; //Limpa o grid;
            dataGridView_adv.DataSource = list1;
            dataGridView_adv.Refresh();
            //dataGridView_adv.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }
        public static DataTable GetAnuncios(DataTable dt, List<Property> list1)
        {

            dt.Columns.Add("id", typeof(Int32));
            dt.Columns.Add("descricao", typeof(string)); //commodities
            dt.Columns.Add("diaria", typeof(decimal));
            dt.Columns.Add("arquivoFoto", typeof(string));
            FillAnunciosRows(dt, list1);
            return dt;
        }

        public static void FillAnunciosRows(DataTable dt, List<Property> list1)
        {
            for (int i = 0; i < list1.Count; i++)
            {
                dt.Rows.Add(list1[i]);
                var f = list1[i].Facilities;
                GetFacilities(f);

            }

        }
        /*
        dt.Rows.Add(new object[] {101, "Apartamento beira-mar 01", 700M,
                @"https://viagemeturismo.abril.com.br/wp-content/uploads/2020/09/casas-airbnb-praia-perto-de-sao-paulo.jpg"});


           /* dt.Rows.Add(new object[] {101, "Apartamento beira-mar 01", 700M,
                @"https://viagemeturismo.abril.com.br/wp-content/uploads/2020/09/casas-airbnb-praia-perto-de-sao-paulo.jpg"});
            dt.Rows.Add(new object[] {102, "Apartamento beira-mar 02", 800M,
                @"https://maladeaventuras.com/wp-content/uploads/2021/01/apartamento-de-temporada-bombinhas.jpg"});
           */




        public static void AddAdv(DataTable dt, List<Property> list1)
        {
            dt.Rows.Add(list1);
            //dt.Rows.Add(new object[] { cod, descricao, diaria, url });
        }

        public void ConfigurarGrade()
        {
            dataGridView_adv.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 11);
            dataGridView_adv.DefaultCellStyle.Font = new Font("Arial", 10);
            dataGridView_adv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            dataGridView_adv.Columns["id"].HeaderText = "ID";
            dataGridView_adv.Columns["id"].Width = 50;
            dataGridView_adv.Columns["id"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView_adv.Columns["id"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridView_adv.Columns["descricao"].HeaderText = "Descrição";
            dataGridView_adv.Columns["descricao"].Width = 500;

            dataGridView_adv.Columns["diaria"].HeaderText = "Diária";
            dataGridView_adv.Columns["diaria"].Width = 80;
            dataGridView_adv.Columns["diaria"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView_adv.Columns["diaria"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridView_adv.Columns["arquivoFoto"].Visible = false;

            DataGridViewImageColumn col = new();
            col.Name = "Image";
            col.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dataGridView_adv.Columns.Add(col);
            dataGridView_adv.Columns["Image"].HeaderText = "Foto";
            dataGridView_adv.Columns["Image"].Width = 64;

        }

        public void CarregarFotos()
        {
            foreach (DataGridViewRow row in dataGridView_adv.Rows)
            {
                Uri uri = new Uri(row.Cells["arquivoFoto"].Value.ToString());
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

        private void dataGridView_adv_DoubleClick(object sender, EventArgs e)
        {
            var path = dataGridView_adv.Rows[dataGridView_adv.CurrentCell.RowIndex].Cells
                ["arquivoFoto"].Value.ToString();

            Form frm = new Form_Img_Adv(path);
            frm.ShowDialog();

        }

        private void dataGridView_adv_CellContentClickfacilities(object sender, DataGridViewCellEventArgs e)
        {
            
                StringBuilder stringBuilder = new StringBuilder();

                stringBuilder.AppendLine("Comodidades");

                for (int i = 0; i < list1.Count; i++)
                {
                    stringBuilder.AppendLine($"{list1[i]}");
                }

                MessageBox.Show(stringBuilder.ToString());

            
        }

        public static void GetFacilities(Dictionary<string, bool> facilities)
        {
            //  var search = from x in facilities
            //             where x.Value.Contains("true")
            //           select x.Key; ????

            List<string> listafacilities = new();
            foreach (KeyValuePair<string, bool> pair in facilities)
            {
                if (pair.Value == true)
                {
                    listafacilities.Add(pair.Key);
                }
                else continue;
            }

            //return listafacilities.ToList();
        }

        private void dataGridView_adv_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
