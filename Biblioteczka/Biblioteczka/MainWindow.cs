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
    public partial class MainWindow : Form
    {
        private Library myLibrary;

        public MainWindow()
        {
            InitializeComponent();
            myLibrary = new Library();
            myLibrary.ImportGamesFromFile();
            GameList.DataSource = myLibrary.GetGames();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            NewGameForm newGameForm = new NewGameForm();
            newGameForm.ShowDialog();
            myLibrary.ImportGamesFromFile();
            GameList.DataSource = null;
            GameList.DataSource = myLibrary.GetGames();
        }

        private void btnUsun_Click(object sender, EventArgs e)
        {
            myLibrary.RemoveGame(GameList.SelectedItem as Game);
            GameList.DataSource = null;
            GameList.DataSource = myLibrary.GetGames();
        }
    }
}
