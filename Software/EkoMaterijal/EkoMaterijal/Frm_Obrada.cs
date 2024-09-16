using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EkoMaterijal
{
    public partial class Frm_Obrada : Form
    {
        private Materijal mat;
        public Materijal selecMat { get => mat; set => mat = value; }
        private float added = 0;
        private float newAmount = 0;
        public Frm_Obrada(Materijal selectdMat)
        {
            this.selecMat = selectdMat;
            InitializeComponent();
        }

        private void btn_potvrdi_Click(object sender, EventArgs e)
        {
            if (selecMat.Obradi(added))
            {
                MessageBox.Show("Podatci uspjesno spremljeni", "Potvrda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            else
            {
                MessageBox.Show("Podatci nisu izmjenjeni", "Potvrda", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_odustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void nud_added_ValueChanged(object sender, EventArgs e)
        {
            added = (float)nud_added.Value;
            if((selecMat.Rezervirano - added) < 0)
            {
                added = selecMat.Rezervirano;
                nud_added.Value = (decimal)added;
            }
            newAmount = selecMat.Rezervirano - added;
            txt_newOstatak.Text = newAmount.ToString();
        }

        private void Frm_Obrada_Load(object sender, EventArgs e)
        {
            txt_rezerviraniMat.Text = selecMat.Rezervirano.ToString();
            nud_added.Value = 0;
            txt_newOstatak.Text = "0";
            lbl_mat.Text = selecMat.name;
        }
    }
}
