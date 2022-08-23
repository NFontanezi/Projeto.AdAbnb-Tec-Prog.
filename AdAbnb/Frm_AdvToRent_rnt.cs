using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using AdAbnb.Domain;
using System.Windows.Forms;


namespace AdAbnb.Presentation
{
    public partial class Frm_AdvToRent_rnt : Form
    {
        bool bPiscina { get; set; }
        bool bAC { get; set; }
        bool bProxAoMar { get; set; }
        bool bPetFriendly { get; set; }
        bool bVagaEstacionamento { get; set; }
        bool bProximoAoTransPublico { get; set; }
        static List<Property> propFiltradas { get; set; } = new List<Property>();

        public DataTable dtF = new DataTable();

        int clickCountPool = 0;
        int clickCountAC = 0;
        int clickCountNextToBeach = 0;
        int clickCountPetFriendly = 0;
        int clickCountGarageSlots = 0;
        int clickCountNextToPublicTransp = 0;

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
            dtF.Columns.Add("piscina", typeof(bool));
            dtF.Columns.Add("ac", typeof(bool));
            dtF.Columns.Add("proxMar", typeof(bool));
            dtF.Columns.Add("petFriendly", typeof(bool));
            dtF.Columns.Add("vaga", typeof(bool));
            dtF.Columns.Add("proxTranspPublico", typeof(bool));




            dtF.Rows.Add(new object[] {101, "Apartamento beira-mar 01", 700M,
                "https://viagemeturismo.abril.com.br/wp-content/uploads/2020/09/casas-airbnb-praia-perto-de-sao-paulo.jpg", "Guarujá", true, true, true, false, false, false});

            Property property1 = new Property("Bairro qualquer", "Guarujá", "SP", 100, 700, true, 
                "https://viagemeturismo.abril.com.br/wp-content/uploads/2020/09/casas-airbnb-praia-perto-de-sao-paulo.jpg");
            Repositories.AllProperties.allProperties.Add(property1);



            dtF.Rows.Add(new object[] {102, "Apartamento beira-mar 02", 800M,
                "https://maladeaventuras.com/wp-content/uploads/2021/01/apartamento-de-temporada-bombinhas.jpg", "Ubatuba", false, false, false, true, true, true});

            Property property2 = new Property("Bairro qualquer 2", "Ubatuba", "SP", 100, 800, false, 
                "https://maladeaventuras.com/wp-content/uploads/2021/01/apartamento-de-temporada-bombinhas.jpg");
            Repositories.AllProperties.allProperties.Add(property2);



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


            //dtF.Columns.Add("piscina", typeof(bool));
            //dtF.Columns.Add("ac", typeof(bool));
            //dtF.Columns.Add("proxMar", typeof(bool));
            //dtF.Columns.Add("petFriendly", typeof(bool));
            //dtF.Columns.Add("vaga", typeof(bool));
            //dtF.Columns.Add("proxTranspPublico", typeof(bool));

            dataGridView1.Columns["piscina"].Visible = false;
            dataGridView1.Columns["ac"].Visible = false;
            dataGridView1.Columns["proxMar"].Visible = false;
            dataGridView1.Columns["petFriendly"].Visible = false;
            dataGridView1.Columns["vaga"].Visible = false;
            dataGridView1.Columns["proxTranspPublico"].Visible = false;

        }

        public void CarregarFotos()
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
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

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            var path = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells
                ["arquivoFoto"].Value.ToString();

            Form frm = new Form_Img_Adv(path);
            frm.ShowDialog();

        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            string filter = "";
            FilterCity(filter);
            FilterFacilities(filter);

            string filtroFinal = FilterCity(filter) + FilterFacilities(filter);

            dtF.DefaultView.RowFilter = filtroFinal;
        }

        private string FilterFacilities(string filter)
        {
            string filterFacilities = 
                FilterPool(filter) + 
                FilterAC(filter) +
                FilterNextToBeach(filter) +
                FilterPetFriendly(filter) +
                FilterGarageSlots(filter) +
                FilterPublicTransp(filter);
            CarregarFotos();
            
            return filterFacilities;
        }

        private string FilterCity(string filterS)
        {
            filterS += $"{dtF.DefaultView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", "cidade", txbCidade.Text)}";
            dataGridView1.DataSource = dtF;
            return filterS;
        }

        //--------------- FILTRO PISCINA
        private string FilterPool(string filterS)
        {
            if(bPiscina == true)
            {
                filterS += $" AND {dtF.DefaultView.RowFilter = "piscina = 1"}";
            }
            else
            {
                filterS += "";
            }

            
            dataGridView1.DataSource = dtF;
            return filterS;

        }

        private void CkbPool_Click(object sender, EventArgs e)
        {
            clickCountPool++;

            if(clickCountPool % 2 == 0 || clickCountPool == 0)
            {
                bPiscina = false;
            }
            else
            {
                bPiscina = true;
            }
        }


        // ------------ FILTRO AR CONDICIONADO
        private string FilterAC(string filterS)
        {
            if (bAC == true)
            {
                filterS += $" AND {dtF.DefaultView.RowFilter = "ac = 1"}";
            }
            else
            {
                filterS += "";
            }

            dataGridView1.DataSource = dtF;
            return filterS;
        }

        private void CkbAC_Click(object sender, EventArgs e)
        {
            clickCountAC++;

            if (clickCountAC % 2 == 0 || clickCountAC == 0)
            {
                bAC = false;
            }
            else
            {
                bAC = true;
            }
        }

        //------------ FILTRO PROXIMO AO MAR

        private string FilterNextToBeach(string filterS)
        {
            if (bProxAoMar == true)
            {
                filterS += $" AND {dtF.DefaultView.RowFilter = "proxMar = 1"}";
            }
            else
            {
                filterS += "";
            }
            dataGridView1.DataSource = dtF;
            return filterS;
        }

        private void CkbProxAoMar_Click(object sender, EventArgs e)
        {
            clickCountNextToBeach++;

            if (clickCountNextToBeach % 2 == 0 || clickCountNextToBeach == 0)
            {
                bProxAoMar = false;
            }
            else
            {
                bProxAoMar = true;
            }
        }


        //----------- FILTRO PET FRIENDLY

        private string FilterPetFriendly(string filterS)
        {
            if (bPetFriendly == true)
            {
                filterS += $" AND {dtF.DefaultView.RowFilter = "petFriendly = 1"}";
            }
            else
            {
                filterS = "";
            }

            dataGridView1.DataSource = dtF;
            return filterS;
        }


        private void CkbPetFriendly_Click(object sender, EventArgs e)
        {
            clickCountPetFriendly++;

            if (clickCountPetFriendly % 2 == 0 || clickCountPetFriendly == 0)
            {
                bPetFriendly = false;
            }
            else
            {
                bPetFriendly = true;
            }
        }


        //------------ FILTRO VAGA GARAGEM

        private string FilterGarageSlots(string filterS)
        {
            if (bVagaEstacionamento == true)
            {
                filterS += $" AND {dtF.DefaultView.RowFilter = "vaga = 1"}";
            }
            else
            {
                filterS += "";
            }

            dataGridView1.DataSource = dtF;
            return filterS;
        }


        private void CkbVagaGaragem_Click(object sender, EventArgs e)
        {
            clickCountGarageSlots++;

            if (clickCountGarageSlots % 2 == 0 || clickCountGarageSlots == 0)
            {
                bVagaEstacionamento = false;
            }
            else
            {
                bVagaEstacionamento = true;
            }
        }


        //------------ FILTRO TRANSP PUBLICO

        private string FilterPublicTransp(string filterS)
        {
            if (bProximoAoTransPublico == true)
            {
                filterS += $" AND {dtF.DefaultView.RowFilter = "proxTranspPublico = 1"}";
            }
            else
            {
                filterS += "";
            }

            dataGridView1.DataSource = dtF;

            return filterS;
        }

        private void CkbProxTranspPublico_Click(object sender, EventArgs e)
        {
            clickCountNextToPublicTransp++;

            if (clickCountNextToPublicTransp % 2 == 0 || clickCountNextToPublicTransp == 0)
            {
                bProximoAoTransPublico = false;
            }
            else
            {
                bProximoAoTransPublico = true;
            }
        }


        private void Frm_AdvToRent_rnt_Click(object sender, EventArgs e)
        {

        }


    }
}
