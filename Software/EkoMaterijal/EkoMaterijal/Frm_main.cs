using EkoMaterijal.Interfaces;
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
    public partial class Frm_main : Form
    {
        public Frm_main()
        {
            InitializeComponent();
        }

        private void Frm_main_Load(object sender, EventArgs e)
        {
            System.Drawing.Rectangle workingRectangle = Screen.PrimaryScreen.WorkingArea;
            this.Size = new System.Drawing.Size(Convert.ToInt32(0.5*workingRectangle.Width), 
                Convert.ToInt32(0.5*workingRectangle.Height));
            this.Location = new System.Drawing.Point(50,50);
            UpdateForm();
        }

        private void btn_Dodaj_Click(object sender, EventArgs e)
        {
            Materijal selectdMat = dgv_Materijali.CurrentRow.DataBoundItem as Materijal;
            if (selectdMat != null)
            {
                Frm_zaprimi frm_Zaprimi = new Frm_zaprimi(selectdMat);
                frm_Zaprimi.ShowDialog();
                UpdateForm();
            }
        }

        private void btn_obrada_Click(object sender, EventArgs e)
        {
            

            Materijal selectdMat = dgv_Materijali.CurrentRow.DataBoundItem as Materijal;
            
            
            if (selectdMat != null)
            {
                Frm_Obrada frm_Obrada = new Frm_Obrada(selectdMat);
                frm_Obrada.ShowDialog();
                UpdateForm();
            }
        }

        private void btn_rezerviraj_Click(object sender, EventArgs e)
        {
            Materijal selectdMat = dgv_Materijali.CurrentRow.DataBoundItem as Materijal;
            if (selectdMat != null)
            {
                Frm_rezervacija frm_Rezervacija = new Frm_rezervacija(selectdMat);
                frm_Rezervacija.ShowDialog();
                UpdateForm();
            }
        }

        private void UpdateForm()
        {
            dgv_Materijali.DataSource = MaterijalInterface.GetMaterijals();
            dgv_Materijali.Columns["name"].DisplayIndex = 1;
            dgv_Materijali.Columns["name"].HeaderText = "Naziv";
            dgv_Materijali.Columns["kol"].HeaderText = "Kolicina";
            dgv_Materijali.Columns["kol"].DisplayIndex = 2;
            dgv_Materijali.Columns["Rezervirano"].DisplayIndex = 4;
            dgv_Materijali.Columns["maxKol"].DisplayIndex = 3; 
            dgv_Materijali.Columns["maxKol"].HeaderText = "Kapacitet skladista";
            dgv_Materijali.Columns["kritKol"].HeaderText = "Kriticna kolicina";
            dgv_Materijali.Columns["kolicinaSlobodno"].DisplayIndex=5;
            dgv_Materijali.Columns["kolicinaSlobodno"].HeaderText = "Slobodni materijal";
            dgv_Materijali.Columns["mjJedinica"].HeaderText = "Jedinicna mjera";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            UpdateForm();
        }
    }
}
