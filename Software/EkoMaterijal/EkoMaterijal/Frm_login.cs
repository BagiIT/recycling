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
using DBLayer;
using EkoMaterijal.Interfaces;

namespace EkoMaterijal
{
    public partial class Frm_login : Form
    {
        public static Radnik loggedRadnik { get; set; }

        //username test
        //password test

        public Frm_login()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            Prijava();
        }
        private void Prijava()
        {
            if (txt_Username.Text == "")
            {
                MessageBox.Show("Korisničko ime nije uneseno!", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txt_Password.Text == "")
            {
                MessageBox.Show("Lozinka nije unesena!", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                loggedRadnik = RadnikInterface.GetRadnik(txt_Username.Text);

                if (loggedRadnik != null && loggedRadnik.password == txt_Password.Text)
                {
                    Frm_main gl = new Frm_main();
                    Hide();
                    gl.ShowDialog();
                    Close();
                }
                else
                {
                    MessageBox.Show("Krivi podaci!", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
