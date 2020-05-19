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
    public partial class NewGameForm : Form
    {
        public NewGameForm()
        {
            InitializeComponent();
        }

        private void btnZapisz_Click(object sender, EventArgs e)
        {
            try
            {
                Game games = new Game(txtTytul.Text, int.Parse(txtWiek.Text), decimal.Parse(txtCena.Text), txtOpis.Text);
                games.SaveToFile();
                MessageBox.Show("Zapisano!");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wpisałeś błędne wartości" + ex.Message);
            }
        }

        private void btnCzysc_Click(object sender, EventArgs e)
        {
            txtCena.Text = "";
            txtOpis.Text = "";
            txtTytul.Text = "";
            txtWiek.Text = "";
        }

        private void NewGameForm_Load(object sender, EventArgs e)
        {

        }
    }
}
