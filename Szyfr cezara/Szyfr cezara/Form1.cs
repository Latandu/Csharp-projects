using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Szyfr_cezara
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static string SzyfrCezara(string tekst, int przesuniecie)
        {
            char[] bufor = tekst.ToCharArray();
            for (int i = 0; i < bufor.Length; i++)
            {
                char litera = bufor[i];
                if (litera == ' ' || litera == '.' || litera == ',')
                {
                    continue;
                }
                if ('A' <= litera && litera <= 'Z')
                {
                    litera = (char)(litera + przesuniecie);
                    if (litera > 'Z')
                    {
                        litera = (char)(litera - 26);
                    }
                    else if (litera < 'A')
                    {
                        litera = (char)(litera + 26);
                    }
                }
                else
                {
                    litera = (char)(litera + przesuniecie);
                    if (litera > 'z')
                    {
                        litera = (char)(litera - 26);
                    }
                    else if (litera < 'a')
                    {
                        litera = (char)(litera + 26);
                    }
                }
                bufor[i] = litera;
            }
            return new string(bufor);
        }


        private void btnKoduj_Click(object sender, EventArgs e)
        {
            string tekstDoZakodowania = txtDoZakodowania.Text;
            int przesuniecie = (int)numPrzesuniecie.Value;
            string tekstzakodowany = SzyfrCezara(tekstDoZakodowania, przesuniecie);

            txtTekstZakodowany.Text = tekstzakodowany;

        }
    }
}
