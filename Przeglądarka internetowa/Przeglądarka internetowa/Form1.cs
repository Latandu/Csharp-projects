using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Przeglądarka_internetowa
{
    public partial class Form1 : Form
    {
        List<Ulubione> ulubioneList;
        public Form1()
        {
            InitializeComponent();
            ulubioneList = new List<Ulubione>();
            ulubioneList = OdczytajUlubioneZPliku();
            OdswiezListeUlubionych();
        }

        private void ZapiszDoUlubionych(string url, string tytul)
        {
            Ulubione strona = new Ulubione(url, tytul);
            ulubioneList.Add(strona);
            ZapiszUlubioneDoPliku(strona);
            OdswiezListeUlubionych();
        }

        private void OdswiezListeUlubionych() 
        {
            cmbUlubione.DataSource = null;
            cmbUlubione.DataSource = ulubioneList;
        }

        private void ZapiszUlubioneDoPliku(Ulubione ulubione)
        {
            using (StreamWriter sw = new StreamWriter(@"C:\Users\Latandu\Documents\ulubione.txt", true))
            {
                sw.WriteLine(string.Format("{0}|{1}", ulubione.Url, ulubione.TytulStrony));
            }
        
        }

        private List<Ulubione> OdczytajUlubioneZPliku()
        {
            List<Ulubione> lista = new List<Ulubione>();
            using (StreamReader sr = new StreamReader(@"C:\Users\Latandu\Documents\ulubione.txt"))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] elementy = line.Split('|');
                    Ulubione ulubione = new Ulubione(elementy[0], elementy[1]);
                    lista.Add(ulubione);
                }
            }
            return lista;
        }

        private void btnWstecz_Click(object sender, EventArgs e)
        {
            brwOkno.GoBack();
        }

        private void btnDalej_Click(object sender, EventArgs e)
        {
            brwOkno.GoForward();
        }

        private void btnZatrzymaj_Click(object sender, EventArgs e)
        {
            brwOkno.Stop();
        }

        private void btnOdswiez_Click(object sender, EventArgs e)
        {
            brwOkno.Refresh();
        }

        private void btnUlubione_Click(object sender, EventArgs e)
        {
            string url = txtAdres.Text;
            string tytul = brwOkno.Document.Title;
            ZapiszDoUlubionych(url, tytul); ;

        }

        private void brwOkno_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            txtAdres.Text = brwOkno.Url.ToString();
            if (brwOkno.CanGoForward)
            {
                btnDalej.Enabled = true;
            }
            else
            {
                btnDalej.Enabled = false;
            }

            if (brwOkno.CanGoBack)
            {
                btnWstecz.Enabled = true;
            }
            else
            {
                btnWstecz.Enabled = false;
            }
        }

        private void cmbUlubione_SelectedIndexChanged(object sender, EventArgs e)
        {
            Ulubione ulubione = cmbUlubione.SelectedItem as Ulubione;
            txtAdres.Text = ulubione.Url;
            brwOkno.Navigate(ulubione.Url);
        }

        private void btnIdz_Click_1(object sender, EventArgs e)
        {
            if (txtAdres.Text != string.Empty)
            {
                brwOkno.Navigate(txtAdres.Text);
            }
            else
            {
                MessageBox.Show("Nie wpisałeś adresu");
            }
        }
    }
    public class Ulubione 
    {
        public string Url;
        public string TytulStrony;

        public Ulubione(string url, string tytul)
        {
            Url = url;
            TytulStrony = tytul;
        }

        public override string ToString()
        {
            return TytulStrony;
        }
    }
}
