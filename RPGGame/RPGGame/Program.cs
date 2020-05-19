using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGGame
{
    public class Postac 
    {
        public string imie;
        public double punktyZycia;
        public int punktyObrony;
        public int punktyAtaku;
        public Postac(string Imie, double PunktyZycia, int PunktyObrony, int PunktyAtaku) 
        {
            
            this.imie = Imie;
            this.punktyZycia = PunktyZycia;
            this.punktyObrony = PunktyObrony;
            this.punktyAtaku = PunktyAtaku;

        }
        public void DodajZycie(double iloscZycia) 
        {
            punktyZycia += iloscZycia;
        }
        public void OdejmijZycie(double IloscZycia) 
        {
            punktyZycia -= IloscZycia;
        }
    }

    public class Wojownik : Postac 
    {
        string rodzajBroni;
        string rodzajTarczy;
        public Wojownik(string Imie, double PunktyZycia, int PunktyObrony, int PunktyAtaku, string RodzajBroni, string RodzajTarczy) : base(Imie, PunktyZycia, PunktyObrony, PunktyAtaku)
        {
            this.rodzajBroni = RodzajBroni;
            this.rodzajTarczy = RodzajTarczy;
        }
        public double MocAtaku()
        {
            if (punktyZycia < 5)
            {
                return punktyAtaku;
            }
            else
            {
                return punktyAtaku * 0.003 * punktyZycia;
            }
        }
    }

    public class Mag : Postac
    {
        int punktyMagii;
        string specjalneMoce;
        public Mag(string Imie, double PunktyZycia, int PunktyObrony, int PunktyAtaku, int PunktyMagii, string SpecjalneMoce) : base(Imie, PunktyZycia, PunktyObrony, PunktyAtaku)
        {
            this.punktyMagii = PunktyMagii;
            this.specjalneMoce = SpecjalneMoce;
        }
        public double MocAtaku()
        {
            return (punktyMagii + punktyAtaku) * 0.001 * punktyZycia;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //użytkownik wpisuje dane pierwszej postaci
            Console.WriteLine("Za chwilę wpiszesz dane pierwszej postaci, kliknij klawisz aby kontynuować");
            Console.ReadKey();
            Console.WriteLine("Podaj imie");
            string imie = Console.ReadLine();
            Console.WriteLine("Podaj punkty życia");
            double zycie = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj Punkty obrony");
            int obrona = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj punkty ataku");
            int atak = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj rodzaj broni");
            string bron = Console.ReadLine();
            Console.WriteLine("Podaj rodzaj tarczy");
            string tarcza = Console.ReadLine();

            Console.WriteLine("");

            //użytkownik wpisuje dane drugiej postaci 
            Console.WriteLine("Za chwilę wpiszesz dane drugiej postaci, kliknij klawisz aby kontynuować");
            Console.ReadKey();
            Console.WriteLine("Podaj imie");
            string imieG = Console.ReadLine();
            Console.WriteLine("Podaj punkty życia");
            double zycieG = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj Punkty obrony");
            int obronaG = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj punkty ataku");
            int atakG = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj punkty Magii");
            int magiaG = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj specjalną moc");
            string mocG = Console.ReadLine();
            Console.Clear();

            //wypisuje dane na ekran
            Console.WriteLine("Właściwości Wojownika ({0}) to: {1} punktów życia, {2} punktów obrony, {3} punktów ataku," +
                "{4} jako rodzaj broni, {5} jako rodzaj tarczy", imie, zycie, obrona, atak, bron, tarcza);
            Console.WriteLine("");
            Console.WriteLine("Właściwości Maga ({0}) to: {1} punktów życia, {2} punktów obrony, {3} punktów ataku," +
                "{4} punktów magii, {5} jako specjalna moc", imieG, zycieG, obronaG, atakG, magiaG, mocG);

            Console.WriteLine();

            Console.WriteLine("Naciśnij dowolny klawisz, aby rozpocząć walkę!");
            Console.ReadKey();

            Wojownik Leonidas = new Wojownik(imie, zycie, obrona, atak, bron, tarcza);
            Mag Geralt = new Mag(imieG, zycieG, obronaG, atakG, magiaG, mocG);
            while (Geralt.punktyZycia > 0 && Leonidas.punktyZycia > 0)
            {
                double atakGeralta = Geralt.MocAtaku();
                double atakLeonidasa = Leonidas.MocAtaku();
                Geralt.OdejmijZycie(atakLeonidasa);
                Leonidas.OdejmijZycie(atakGeralta);
                Console.WriteLine("Życie {0} {1}",imieG, Geralt.punktyZycia);
                Console.WriteLine("Życie {0} {1}",imie, Leonidas.punktyZycia);
            }
            if (Geralt.punktyZycia > Leonidas.punktyZycia)
                Console.WriteLine("{0} wygrał(a) grę!",imieG);
            else if (Geralt.punktyZycia < Leonidas.punktyZycia)
                Console.WriteLine("Wygrał(a) {0}!", imie);
            else
                Console.WriteLine("Remis");

            Console.WriteLine("Naciśnij dowolny klawisz aby zakończyć");
            Console.ReadKey();
        }
    }
}
