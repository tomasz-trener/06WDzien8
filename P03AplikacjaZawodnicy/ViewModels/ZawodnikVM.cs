using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.CheckedListBox;

namespace P03AplikacjaZawodnicy.ViewModels
{
    public class ZawodnikVM
    {
        public int Id_zawodnika;
        public int? Id_trenera; //dodanie ? powoduje, że typ jest nullable 
        public string Imie; // string jest domyślnie nullable ?
        public string Nazwisko;
        public string Kraj;
        public DateTime DataUrodzenia;
        public int Wzrost;
        public int Waga;

        private CheckedItemCollection soc;

        public string ImieNazwisko { get { return Imie + " " + Nazwisko; } }

        public string WybraneKolumny
        {
            get
            {
                if (soc == null)
                    return ImieNazwisko;

                string kolumny="";

                if (soc.Contains("Imie"))
                    kolumny += Imie + " ";

                if (soc.Contains("Nazwisko"))
                    kolumny += Nazwisko + " ";

                if (soc.Contains("Kraj"))
                    kolumny += Kraj + " ";

                if (soc.Contains("Wzrost"))
                    kolumny += Wzrost + " ";

                if (soc.Contains("Waga"))
                    kolumny += Waga + " ";

                if (soc.Contains("DataUr"))
                    kolumny += DataUrodzenia.ToString("dd-MM-yyyy") + " ";

                return kolumny; 

            }
        }


        public string CalyRekord
        {
            get
            {
                return Id_zawodnika + " " + Id_trenera +  " " +
                    Imie + " " + Nazwisko + " " +
                    Kraj + " " + DataUrodzenia + " " +
                    Wzrost + " " + Wzrost;

            }
        }

        public ZawodnikVM()
        {

        }
        public ZawodnikVM(string imie, string nazwisko)
        {
            Imie = imie;
            Nazwisko = nazwisko;
        }
        public ZawodnikVM(string imie, string nazwisko , CheckedItemCollection soc): this(imie,nazwisko)
        {
            this.soc = soc;
        }

        public string PrzedstawSie()
        {
            return $"Nazywam {Imie} {Nazwisko} i pochodze z {Kraj}";
        }

    }
}
