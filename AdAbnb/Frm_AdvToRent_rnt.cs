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

namespace AdAbnb.Presentation
{
    public partial class Frm_AdvToRent_rnt : Form
    {
        public DataTable dtF = new DataTable();

        public Frm_AdvToRent_rnt()
        {
            InitializeComponent();
            //dataGridView1.DataSource = GetAnuncios(dtF);
            //ConfigurarGrade();
            //CarregarFotos();
        }

        private void Frm_AdvToRent_rnt_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = GetAnuncios(dtF);
            ConfigurarGrade();
            CarregarFotos();
        }

        //private void btnAbrir_Click(object sender, EventArgs e)
        //{
        //  dataGridView1.DataSource = GetAnuncios(dtF);
        //  ConfigurarGrade();
        //  CarregarFotos();
        //}


        public static DataTable GetAnuncios(DataTable dtF)
        {
            dtF.Columns.Add("id", typeof(Int32));
            dtF.Columns.Add("descricao", typeof(string));
            dtF.Columns.Add("diaria", typeof(decimal));
            dtF.Columns.Add("arquivoFoto", typeof(string));
            dtF.Columns.Add("cidade", typeof(string));

            dtF.Rows.Add(new object[] {101, "Apartamento beira-mar 01", 700M,
                "https://viagemeturismo.abril.com.br/wp-content/uploads/2020/09/casas-airbnb-praia-perto-de-sao-paulo.jpg", "Guarujá"});
            dtF.Rows.Add(new object[] {102, "Apartamento beira-mar 02", 800M,
                "https://maladeaventuras.com/wp-content/uploads/2021/01/apartamento-de-temporada-bombinhas.jpg", "Ubatuba"});

            return dtF;

        }

        public static void AddAdv(DataTable dtF, int cod, string descricao, decimal diaria, string url)
        {
            dtF.Rows.Add(new object[] { cod, descricao, diaria, url });
        }

        public void ConfigurarGrade()
        {
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 11);
            dataGridView1.DefaultCellStyle.Font = new Font("Arial", 10);
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            dataGridView1.Columns["id"].HeaderText = "ID";
            dataGridView1.Columns["id"].Width = 50;
            dataGridView1.Columns["id"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["id"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridView1.Columns["descricao"].HeaderText = "Descrição";
            dataGridView1.Columns["descricao"].Width = 500;

            dataGridView1.Columns["diaria"].HeaderText = "Diária";
            dataGridView1.Columns["diaria"].Width = 80;
            dataGridView1.Columns["diaria"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["diaria"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridView1.Columns["arquivoFoto"].Visible = false;

            DataGridViewImageColumn col = new();
            col.Name = "Image";
            col.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dataGridView1.Columns.Add(col);
            dataGridView1.Columns["Image"].HeaderText = "Foto";
            dataGridView1.Columns["Image"].Width = 64;

        }

        public void CarregarFotos()
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                Uri uri = new Uri (row.Cells["arquivoFoto"].Value.ToString());
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

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            var path = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells
                ["arquivoFoto"].Value.ToString();

            Form frm = new Form_Img_Adv(path);
            frm.ShowDialog();

        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            FilterCity();
        }


        private void FilterCity()
        {
            dtF.DefaultView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", "cidade", txbCidade.Text);
            dataGridView1.DataSource = dtF;
        }
        
        private void FilterFacilities()
        {
            //dtF.DefaultView.RowFilter = dataGridView1
        }


        //private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    if (e.ColumnIndex == 1)
        //    {
        //        MessageBox.Show("coluna 1");
        //    } 
        //    else if (e.ColumnIndex == 2)
        //    {
        //        MessageBox.Show("coluna 2");
        //    }
        //}
    }
}
