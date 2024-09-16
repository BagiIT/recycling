using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EkoMaterijal
{
    public partial class Frm_rezervacija : Form
    {
        private Materijal mat;
        public Materijal selecMat { get => mat; set => mat = value; }
        private float added = 0;
        private float newAmount = 0;
        public Frm_rezervacija(Materijal selectdMat)
        {
            selecMat = selectdMat;
            InitializeComponent();
        }

        private void btn_potvrdi_Click(object sender, EventArgs e)
        {
            if (selecMat.RezervirajMat(added))
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

        private void Frm_rezervacija_Load(object sender, EventArgs e)
        {
            lbl_mat.Text = selecMat.name;
            txt_slobodniMat.Text = selecMat.kolicinaSlobodno.ToString();
            txt_rezMat.Text = selecMat.Rezervirano.ToString();
            txt_newRezervirani.Text = "0";
            txt_newSlobodni.Text = "0";
            lbl_mat.Text = selecMat.name;

        }

        private void nud_added_ValueChanged(object sender, EventArgs e)
        {
            added = (float)nud_added.Value;
            
            if((selecMat.kolicinaSlobodno - added) < 0)
            {
                added = selecMat.kolicinaSlobodno;
                nud_added.Value = (decimal)added;
            }
            newAmount = selecMat.kolicinaSlobodno - added;
            txt_newSlobodni.Text = newAmount.ToString();
            newAmount = added + selecMat.Rezervirano;
            txt_newRezervirani.Text = newAmount.ToString();

        }
    }
}
