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
using AdAbnb.Repositories;


namespace AdAbnb.Presentation
{
    public partial class Frm_AdvToRent_rnt : Form
    {
        Person User { get; set; }
        bool bPiscina { get; set; }
        bool bAC { get; set; }
        bool bProxAoMar { get; set; }
        bool bPetFriendly { get; set; }
        bool bVagaEstacionamento { get; set; }
        bool bProximoAoTransPublico { get; set; }

        static DataTable dt = new DataTable();

        int clickCountPool = 0;
        int clickCountAC = 0;
        int clickCountNextToBeach = 0;
        int clickCountPetFriendly = 0;
        int clickCountGarageSlots = 0;
        int clickCountNextToPublicTransp = 0;
        public static int clickAlugar { get; set; } = 0;
        public static int clickSearch { get; set; } = 0;

        List<Property> listProp = AllProperties.allProperties;

        public Frm_AdvToRent_rnt(Person User)
        {
            InitializeComponent();
            listProp = AllProperties.allProperties;

            this.User = User;
            //dataGridView1.DataSource = GetAnuncios(dtF);
            //ConfigurarGrade();
            //CarregarFotos();
        }

        private void Frm_AdvToRent_rnt_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = ConvertToDatatable(listProp);
            ConfigurarGrade();

            CarregarFotos(dataGridView1);
            CarregarBotaoAlugar(dataGridView1);
        }

        //private void btnAbrir_Click(object sender, EventArgs e)
        //{
        //  dataGridView1.DataSource = GetAnuncios(dtF);
        //  ConfigurarGrade();
        //  CarregarFotos();
        //}

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

            clickSearch++;

            if (!dt.Columns.Contains("ID_prop"))
            {
                dt.Columns.Add("ID_prop");
                dt.Columns.Add("District");
                dt.Columns.Add("City");
                dt.Columns.Add("State");
                dt.Columns.Add("Footage");
                dt.Columns.Add("Daily");
                dt.Columns.Add("Active");
                dt.Columns.Add("imagetext");

                dt.Columns.Add("Piscina", typeof(bool));
                dt.Columns.Add("AC", typeof(bool));
                dt.Columns.Add("ProxMar", typeof(bool));
                dt.Columns.Add("PetFriendly", typeof(bool));
                dt.Columns.Add("Vaga", typeof(bool));
                dt.Columns.Add("ProxTransp", typeof(bool));
            }




            if(clickSearch == 1)
            {
                foreach (var item in list)
                {
                    var row = dt.NewRow();

                    var piscina = item.Piscina;
                    var ac = item.AC;
                    var proxMar = item.ProxMar;
                    var petFriendly = item.PetFriendly;
                    var vaga = item.Vaga;
                    var proxTranspPublico = item.ProxTransp;


                    row["ID_prop"] = item.ID_prop;
                    row["District"] = item.District;
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
                    dt.Rows.Add(row);

                }


            }

            return dt;
        }

        //public static DataTable GetAnuncios(DataTable dtF)
        //{
        //    dtF.Columns.Add("id", typeof(Int32));
        //    dtF.Columns.Add("descricao", typeof(string));
        //    dtF.Columns.Add("diaria", typeof(decimal));
        //    dtF.Columns.Add("arquivoFoto", typeof(string));
        //    dtF.Columns.Add("cidade", typeof(string));
        //    dtF.Columns.Add("piscina", typeof(bool));
        //    dtF.Columns.Add("ac", typeof(bool));
        //    dtF.Columns.Add("proxMar", typeof(bool));
        //    dtF.Columns.Add("petFriendly", typeof(bool));
        //    dtF.Columns.Add("vaga", typeof(bool));
        //    dtF.Columns.Add("proxTranspPublico", typeof(bool));



        //    return dtF;

        //}

        //public void ConfigurarGrade()
        //{
        //    dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 11);
        //    dataGridView1.DefaultCellStyle.Font = new Font("Arial", 10);
        //    dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

        //    dataGridView1.Columns["id"].HeaderText = "ID";
        //    dataGridView1.Columns["id"].Width = 50;
        //    dataGridView1.Columns["id"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
        //    dataGridView1.Columns["id"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

        //    dataGridView1.Columns["descricao"].HeaderText = "Descrição";
        //    dataGridView1.Columns["descricao"].Width = 500;

        //    dataGridView1.Columns["diaria"].HeaderText = "Diária";
        //    dataGridView1.Columns["diaria"].Width = 80;
        //    dataGridView1.Columns["diaria"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
        //    dataGridView1.Columns["diaria"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

        //    dataGridView1.Columns["arquivoFoto"].Visible = false;

        //    DataGridViewImageColumn col = new();
        //    col.Name = "Image";
        //    col.ImageLayout = DataGridViewImageCellLayout.Zoom;
        //    dataGridView1.Columns.Add(col);
        //    dataGridView1.Columns["Image"].HeaderText = "Foto";
        //    dataGridView1.Columns["Image"].Width = 64;


        //    //dtF.Columns.Add("piscina", typeof(bool));
        //    //dtF.Columns.Add("ac", typeof(bool));
        //    //dtF.Columns.Add("proxMar", typeof(bool));
        //    //dtF.Columns.Add("petFriendly", typeof(bool));
        //    //dtF.Columns.Add("vaga", typeof(bool));
        //    //dtF.Columns.Add("proxTranspPublico", typeof(bool));

        //    dataGridView1.Columns["piscina"].Visible = false;
        //    dataGridView1.Columns["ac"].Visible = false;
        //    dataGridView1.Columns["proxMar"].Visible = false;
        //    dataGridView1.Columns["petFriendly"].Visible = false;
        //    dataGridView1.Columns["vaga"].Visible = false;
        //    dataGridView1.Columns["proxTranspPublico"].Visible = false;

        //    dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);


        //}

        //public void CarregarFotos()
        //{
        //    foreach (DataGridViewRow row in dataGridView1.Rows)
        //    {
        //        Uri uri = new Uri(row.Cells["arquivoFoto"].Value.ToString());
        //        row.Cells["Image"].Value = GetImageFromUrl(uri);
        //    }
        //}

        //public static Image GetImageFromUrl(Uri uri)
        //{
        //    HttpWebRequest httpWebRequest = (HttpWebRequest)HttpWebRequest.Create(uri);

        //    using (HttpWebResponse httpWebReponse = (HttpWebResponse)httpWebRequest.GetResponse())
        //    {
        //        using (Stream stream = httpWebReponse.GetResponseStream())
        //        {
        //            return Image.FromStream(stream);
        //        }
        //    }
        //}
        public void ConfigurarGrade()
        {
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 11);
            dataGridView1.DefaultCellStyle.Font = new Font("Arial", 10);
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


            dataGridView1.Columns["Daily"].HeaderText = "Diária";
            dataGridView1.Columns["Daily"].Width = 80;
            dataGridView1.Columns["Daily"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["Daily"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridView1.Columns["City"].HeaderText = "Cidade";
            dataGridView1.Columns["City"].Width = 80;
            dataGridView1.Columns["City"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["City"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridView1.Columns["District"].HeaderText = "Bairro";
            dataGridView1.Columns["District"].Width = 80;
            dataGridView1.Columns["District"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["District"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridView1.Columns["State"].HeaderText = "Estado";
            dataGridView1.Columns["State"].Width = 80;
            dataGridView1.Columns["State"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["State"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridView1.Columns["Active"].HeaderText = "Ativo";
            dataGridView1.Columns["Active"].Width = 80;
            dataGridView1.Columns["Active"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["Active"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridView1.Columns["Footage"].HeaderText = "Metragem";
            dataGridView1.Columns["Footage"].Width = 80;
            dataGridView1.Columns["Footage"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["Footage"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


            dataGridView1.Columns["imagetext"].Visible = false;

            dataGridView1.Columns["Piscina"].Visible = false;
            dataGridView1.Columns["AC"].Visible = false;
            dataGridView1.Columns["ProxMar"].Visible = false;
            dataGridView1.Columns["PetFriendly"].Visible = false;
            dataGridView1.Columns["Vaga"].Visible = false;
            dataGridView1.Columns["ProxTransp"].Visible = false;

            dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

            DataGridViewImageColumn col = new();
            col.Name = "Image";
            col.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dataGridView1.Columns.Add(col);
            dataGridView1.Columns["Image"].HeaderText = "Foto";
            dataGridView1.Columns["Image"].Width = 64;

            DataGridViewTextBoxColumn colRent = new();
            colRent.Name = "Rent";
            colRent.HeaderText = "";
            dataGridView1.Columns.Add(colRent);


        }

        public void CarregarFotos(DataGridView dt)
        {
            foreach (DataGridViewRow row in dt.Rows)
            {
                Uri uri = new Uri(row.Cells["imagetext"].Value.ToString());
                row.Cells["Image"].Value = GetImageFromUrl(uri);
            }
        }

        public void CarregarBotaoAlugar(DataGridView dt)
        {
            foreach (DataGridViewRow row in dt.Rows)
            {
                row.Cells["Rent"].Value = "Alugar";
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = dataGridView1.CurrentCell.RowIndex;
            int columnindex = dataGridView1.CurrentCell.ColumnIndex;


            if (columnindex == 15) //alugar
            {
                var district = dataGridView1.Rows[rowindex].Cells["District"].Value.ToString();
                var city = dataGridView1.Rows[rowindex].Cells["City"].Value.ToString();
                var state = dataGridView1.Rows[rowindex].Cells["State"].Value.ToString();
                var footage = int.Parse(dataGridView1.Rows[rowindex].Cells["Footage"].Value.ToString());
                var daily = decimal.Parse(dataGridView1.Rows[rowindex].Cells["Daily"].Value.ToString());
                var active = bool.Parse(dataGridView1.Rows[rowindex].Cells["Active"].Value.ToString());
                var imagetext = dataGridView1.Rows[rowindex].Cells["imagetext"].Value.ToString();
                var piscina = bool.Parse(dataGridView1.Rows[rowindex].Cells["Piscina"].Value.ToString());
                var proxmar = bool.Parse(dataGridView1.Rows[rowindex].Cells["ProxMar"].Value.ToString());
                var ac = bool.Parse(dataGridView1.Rows[rowindex].Cells["AC"].Value.ToString());
                var petfriendly = bool.Parse(dataGridView1.Rows[rowindex].Cells["PetFriendly"].Value.ToString());
                var vaga = bool.Parse(dataGridView1.Rows[rowindex].Cells["Vaga"].Value.ToString());
                var proxtransp = bool.Parse(dataGridView1.Rows[rowindex].Cells["ProxTransp"].Value.ToString());



                Property rentedProp = new(district, city, state, footage, daily, active, imagetext, ac, piscina, proxmar, petfriendly, vaga, proxtransp);

                User.usersPropRented.Add(rentedProp);

                MessageBox.Show("Imóvel alugado com sucesso!");
                clickAlugar = 1;
                var t = new Thread(() => Application.Run(new Frm_HistRent_rnt(User)));
                t.Start();
            }

            else if (columnindex == 14)// foto
            {
                var path = dataGridView1.Rows[rowindex].Cells
                 ["imagetext"].Value.ToString();

                Form frm = new Form_Img_Adv(path);
                frm.ShowDialog();
            }


        }

        //private void dataGridView1_DoubleClick(object sender, EventArgs e)
        //{
        //    var path = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells
        //        ["imagetext"].Value.ToString();

        //    Form frm = new Form_Img_Adv(path);
        //    frm.ShowDialog();

        //}

        private void btnFilter_Click(object sender, EventArgs e)
        {
            dt.DefaultView.RowFilter = "";
            string filter = "";
            FilterCity(filter);
            FilterFacilities(filter);

            string filtroFinal = FilterCity(filter) + FilterFacilities(filter);

            dt.DefaultView.RowFilter = filtroFinal;
            CarregarFotos(dataGridView1);
            CarregarBotaoAlugar(dataGridView1);

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
            CarregarFotos(dataGridView1);
            CarregarBotaoAlugar(dataGridView1);

            return filterFacilities;
        }

        private string FilterCity(string filterS)
        {
            filterS += $"{dt.DefaultView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", "City", txbCidade.Text)}";
            return filterS;
        }

        //--------------- FILTRO PISCINA
        private string FilterPool(string filterS)
        {
            if (bPiscina == true)
            {
                filterS += $" AND {dt.DefaultView.RowFilter = "Piscina = 1"}";
            }
            else
            {
                filterS += "";
            }

            return filterS;

        }

        private void CkbPool_Click(object sender, EventArgs e)
        {
            clickCountPool++;

            if (clickCountPool % 2 == 0 || clickCountPool == 0)
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
                filterS += $" AND {dt.DefaultView.RowFilter = "AC = 1"}";
            }
            else
            {
                filterS += "";
            }

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
                filterS += $" AND {dt.DefaultView.RowFilter = "ProxMar = 1"}";
            }
            else
            {
                filterS += "";
            }
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
                filterS += $" AND {dt.DefaultView.RowFilter = "PetFriendly = 1"}";
            }
            else
            {
                filterS = "";
            }

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
                filterS += $" AND {dt.DefaultView.RowFilter = "Vaga = 1"}";
            }
            else
            {
                filterS += "";
            }

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
                filterS += $" AND {dt.DefaultView.RowFilter = "ProxTransp = 1"}";
            }
            else
            {
                filterS += "";
            }

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

        private void btnBack_Click(object sender, EventArgs e)
        {
            var t = new Thread(() => Application.Run(new Frm_ClientArea(User)));
            this.Close();
            t.Start();
        }
    }
}
