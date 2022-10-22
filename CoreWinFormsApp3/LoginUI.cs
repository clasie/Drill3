using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoreWinFormsApp3
{
    public partial class LoginUI : Form
    {
        public bool IsLogged = false;
        public LoginUI()
        {
            InitializeComponent();
        }

        private void btn_valider_Click(object sender, EventArgs e)
        {
            if (txt_login.Text == "" || txt_password.Text == "")
            {
                MessageBox.Show("Incomplete creds");
                return;
            }
            else if (txt_login.Text == "a" || txt_password.Text == "a")
            {
                IsLogged = true;
                this.Close();
            }
            else {
                MessageBox.Show("Bad creds");
                return;
            }
        }

        private void btn_annuler_Click(object sender, EventArgs e)
        {
            IsLogged = false;
            this.Close();
        }

        private void txt_login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return) {
                btn_valider.PerformClick();
            }
        }
        private void txt_password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                btn_valider.PerformClick();
            }
        }

        private void LoginUI_Load(object sender, EventArgs e)
        {

        }


    }
}
