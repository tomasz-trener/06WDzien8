using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02OperacjeCRUD
{
    class Program
    {
        static void Main(string[] args)
        {
            ModelBazyDanychDataContext db = new ModelBazyDanychDataContext();

            // tworzenie nowych rekordow 

            //Zawodnik nowy = new Zawodnik();
            //nowy.imie = "Jan";
            //nowy.nazwisko = "Kowalski!";
            //nowy.kraj = "POL";

            //db.Zawodnik.InsertOnSubmit(nowy);
            //db.SubmitChanges();

            // edycja danych 
            // najpierw musimy pobrac tego zawodnika, ktrego chcemy edytowac
            // nastepnie zmieniamy te pola, ktre chemy wyedytowac
            // zapisujemy dane w bazie 

            //var doEdycji=
            //db.Zawodnik.Where(x => x.id_zawodnika == 2).ToArray()[0];

            //int liczba = Convert.ToInt32(doEdycji.imie.Substring(doEdycji.imie.Length - 1)) + 1;
            //string poczatek = doEdycji.imie.Substring(0, doEdycji.imie.Length - 1);
            //doEdycji.imie = poczatek + liczba;


            //db.SubmitChanges();

            // usuwanie danych 
            // najpierw pobieramy tego zawodnika, ktorego chcemy usunac
            // ustawiamy go jako usuniety
            // zapisujemy dane w bazie

            //var doUsunieacia =
            //    db.Zawodnik.Where(x => x.id_zawodnika == 1024).ToArray()[0];

            var doUsuniecia=
                db.Zawodnik.FirstOrDefault(x => x.id_zawodnika == 1024);

            db.Zawodnik.DeleteOnSubmit(doUsuniecia);
            db.SubmitChanges();
        }
    }
}
