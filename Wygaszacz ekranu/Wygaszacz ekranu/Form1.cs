using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wygaszacz_ekranu
{
    public partial class MojWygaszacz : Form
    {
        int x, y;
        string[] sciezka_do_obrazow;
        int ilosc_obrazkow = 0;
        int numer_obrazka = 0;

        public MojWygaszacz()
        {
            InitializeComponent();
        }

        private void MojWygaszacz_Load(object sender, EventArgs e)
        {
            x = Cursor.Position.X;
            y = Cursor.Position.Y;
            string folder = @"C:\users\Latandu\Pictures\Tapety";

            try
            {
                sciezka_do_obrazow = System.IO.Directory.GetFiles(folder);
            }
            catch 
            {
                MessageBox.Show("Błąd w trakcie pobierania obrazów", "Błąd!", MessageBoxButtons.OK,MessageBoxIcon.Error);
                Application.Exit();
            }

            ilosc_obrazkow = sciezka_do_obrazow.Length;

            if (ilosc_obrazkow == 0)
            {
                MessageBox.Show("Brak plików", "Błąd", MessageBoxButtons.OK);
                Application.Exit();
            }

            BackgroundImage = Image.FromFile(sciezka_do_obrazow[numer_obrazka]);
            Cursor.Hide();
            WindowState = FormWindowState.Maximized;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                BackgroundImage = Image.FromFile(sciezka_do_obrazow[numer_obrazka++]);
                if (numer_obrazka == ilosc_obrazkow)
                {
                    numer_obrazka = 0;
                }

            }
            catch
            {
                MessageBox.Show("Błąd w trakcie pobierania", "Błąd!", MessageBoxButtons.OK);
                Application.Exit();
            }
        }

        private void MojWygaszacz_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.X != x || e.Y != y)
            {
                Application.Exit();
            }
        }

        private void MojWygaszacz_MouseClick(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }

        private void MojWygaszacz_KeyDown(object sender, KeyEventArgs e)
        {
            Application.Exit();
        }
    }
}