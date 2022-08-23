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


        public frmLoginArea_MyAdvs(Owner owner)
        {

            this.owner = owner;
            list1 = owner.PropertyList;

            InitializeComponent();

        }

        private void LoginArea_MyAdvs_Load(object sender, EventArgs e)
        {
         

            dataGridView_adv.DataSource = null;
            dataGridView_adv.DataSource = list1;
            dataGridView_adv.Refresh();
            dataGridView_adv.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            ConfigurarGrade();
            CarregarFotos();
        }
 


        public void ConfigurarGrade()
        {
            dataGridView_adv.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 11);
            dataGridView_adv.DefaultCellStyle.Font = new Font("Arial", 10);
            dataGridView_adv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView_adv.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


            dataGridView_adv.Columns["Daily"].HeaderText = "Diária";
            dataGridView_adv.Columns["Daily"].Width = 80;
            dataGridView_adv.Columns["Daily"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView_adv.Columns["Daily"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridView_adv.Columns["facilities"].HeaderText = "Comodidades";
            dataGridView_adv.Columns["facilities"].Width = 80;
            dataGridView_adv.Columns["facilities"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView_adv.Columns["facilities"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridView_adv.Columns["City"].HeaderText = "Cidade";
            dataGridView_adv.Columns["City"].Width = 80;
            dataGridView_adv.Columns["City"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView_adv.Columns["City"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridView_adv.Columns["District"].HeaderText = "Bairro";
            dataGridView_adv.Columns["District"].Width = 80;
            dataGridView_adv.Columns["District"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView_adv.Columns["District"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridView_adv.Columns["State"].HeaderText = "Estado";
            dataGridView_adv.Columns["State"].Width = 80;
            dataGridView_adv.Columns["State"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView_adv.Columns["State"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridView_adv.Columns["Active"].HeaderText = "Ativo";
            dataGridView_adv.Columns["Active"].Width = 80;
            dataGridView_adv.Columns["Active"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView_adv.Columns["Active"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridView_adv.Columns["Footage"].HeaderText = "Metragem";
            dataGridView_adv.Columns["Footage"].Width = 80;
            dataGridView_adv.Columns["Footage"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView_adv.Columns["Footage"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            
            dataGridView_adv.Columns["imagetext"].Visible = false;

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

        private void dataGridView_adv_DoubleClick(object sender, EventArgs e)
        {
            var path = dataGridView_adv.Rows[dataGridView_adv.CurrentCell.RowIndex].Cells
                ["imagetext"].Value.ToString();

            Form frm = new Form_Img_Adv(path);
            frm.ShowDialog();

        }

        private void dataGridView_adv_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = dataGridView_adv.CurrentCell.RowIndex;
            int columnindex = dataGridView_adv.CurrentCell.ColumnIndex;
            

            if (columnindex == 9)
            {
                var path = dataGridView_adv.Rows[rowindex].Cells
                 ["imagetext"].Value.ToString();

                Form frm = new Form_Img_Adv(path);
                frm.ShowDialog();
            }
            else if (columnindex == 7)
            {

                int x = e.RowIndex;
                var p = list1[x]; //uma propriedade
                var f = list1[x].Facilities;

                Form frm = new frmFacilities(p, f);
                frm.ShowDialog();
            }

        }

        private void dataGridView_adv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
