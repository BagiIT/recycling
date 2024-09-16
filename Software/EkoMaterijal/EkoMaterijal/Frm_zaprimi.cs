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
    public partial class Frm_zaprimi : Form
    {
        private Materijal mat;
        public Materijal selecMat { get =>  mat; set => mat = value; }
        private float added = 0;
        private float newAmount = 0;

        public Frm_zaprimi(Materijal selectdMat)
        {
            InitializeComponent();
            selecMat = selectdMat;
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            if (selecMat.UpdateMat(added))
            {
                MessageBox.Show("Podatci uspjesno spremljeni", "Potvrda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            else
            {
                MessageBox.Show("Podatci nisu izmjenjeni", "Potvrda", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Frm_zaprimi_Load(object sender, EventArgs e)
        {
            txt_Kapac.Text = selecMat.maxKol.ToString();
            txt_TrenStanje.Text = selecMat.kol.ToString();
            txt_NovStanj.Text = "0";
            lbl_mat.Text = selecMat.name;
        }

        private void btn_cancle_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void nud_added_ValueChanged(object sender, EventArgs e)
        {
            added = (float)nud_added.Value;
            if ((selecMat.kol + added) > selecMat.maxKol)
            {
                added = selecMat.maxKol - selecMat.kol;
                nud_added.Value = (decimal)added;
            }
            newAmount = selecMat.kol + added;
            txt_NovStanj.Text = newAmount.ToString();
        }
    }
}
