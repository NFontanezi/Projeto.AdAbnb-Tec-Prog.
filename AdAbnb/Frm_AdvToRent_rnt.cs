using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdAbnb.Presentation
{
    public partial class Frm_AdvToRent_rnt : Form
    {
        public Frm_AdvToRent_rnt()
        {
            InitializeComponent();
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = GetAnuncios();
            ConfigurarGrade();
            CarregarFotos();
        }


        public static DataTable GetAnuncios()
        {
            var dt = new DataTable();

            dt.Columns.Add("id", typeof(Int32));
            dt.Columns.Add("descricao", typeof(string));
            dt.Columns.Add("diaria", typeof(decimal));
            dt.Columns.Add("arquivoFoto", typeof(string));


            dt.Rows.Add(101, "Apartamento beira-mar 01", 700M, @"C:\Users\natal\OneDrive\Área de Trabalho\Let's Code\05 - Técnicas de Programação\Projeto_TP\Projeto.AdAbnb-Tec-Prog\apartamento-01-adabnb.png");
            dt.Rows.Add(102, "Apartamento beira-mar 02", 800M, @"C:\Users\natal\OneDrive\Área de Trabalho\Let's Code\05 - Técnicas de Programação\Projeto_TP\Projeto.AdAbnb-Tec-Prog\apartamento-02-adabnb.png");
            dt.Rows.Add(103, "Apartamento beira-mar 02", 900M, @"C:\Users\natal\OneDrive\Área de Trabalho\Let's Code\05 - Técnicas de Programação\Projeto_TP\Projeto.AdAbnb-Tec-Prog\apartamento-03-adabnb.png");

            return dt;

        }

        
        public void ConfigurarGrade()
        {
            dataGridView1.DefaultCellStyle.Font = new Font("Arial", 10);
            dataGridView1.Columns["id"].HeaderText = "ID";
            dataGridView1.Columns["id"].Width = 50;
            dataGridView1.Columns["id"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["id"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridView1.Columns["descricao"].HeaderText = "Descrição";
            dataGridView1.Columns["descricao"].Width = 300;

            dataGridView1.Columns["diaria"].HeaderText = "Diária";
            dataGridView1.Columns["diaria"].Width = 80;
            dataGridView1.Columns["diaria"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["diaria"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridView1.Columns["arquivoFoto"].HeaderText = "Arquivo";
            dataGridView1.Columns["arquivoFoto"].Width = 300;

            DataGridViewImageColumn col = new();
            col.Name = "img";
            col.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dataGridView1.Columns.Add(col);
            dataGridView1.Columns["img"].HeaderText = "Foto";
            dataGridView1.Columns["img"].Width = 64;

        }

        public void CarregarFotos()
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                row.Cells["img"].Value = Image
                    .FromFile(row.Cells["arquivoFoto"].Value.ToString());
            }
        }
    }
}
