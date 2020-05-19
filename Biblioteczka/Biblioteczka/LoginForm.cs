using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteczka
{
    public partial class LoginForm : Form
    {
        string login = "admin";
        string password = "admin";

        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnZaloguj_Click(object sender, EventArgs e)
        {
            if(txtLogin.Text.Equals(login) && txtHaslo.Text.Equals(password))
            {
                lblWrong.Text = "";
                Form mainForm = new MainWindow();
                mainForm.Show();
                Hide();
            }
            else
            {
                lblWrong.ForeColor = Color.Red;
                lblWrong.Text = "Podałes błędne dane";
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
