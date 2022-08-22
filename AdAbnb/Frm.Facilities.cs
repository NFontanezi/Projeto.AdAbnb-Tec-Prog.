using AdAbnb.Domain;
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
    public partial class frmFacilities : Form
    {   Property Prop { get; set; }
        Dictionary<string, bool> Facilities;
        public frmFacilities(Property prop, Dictionary<string, bool> facilities)
        {
            Prop = prop;
            Facilities = facilities;
            InitializeComponent();

        }

        private void Frm_Load(object sender, EventArgs e)
        {
            List<string> listafacilities = new();
            foreach (KeyValuePair<string, bool> pair in Facilities)
            {
                if (pair.Value == true)
                {
                    txbFacilities.Text = pair.Key;

                }
                else continue;
                
            }

        }
    }
}
