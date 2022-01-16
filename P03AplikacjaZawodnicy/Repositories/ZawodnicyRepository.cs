using P03AplikacjaZawodnicy.Domains;
using P03AplikacjaZawodnicy.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.CheckedListBox;

namespace P03AplikacjaZawodnicy.Repositories
{
    public class ZawodnicyRepository
    {
       
        public ZawodnikVM[] Zawodnicy;

        
        public void Wczytaj()
        {
            Wczytaj(null);
        }
        
        public void Wczytaj(CheckedItemCollection soc)
        {
            ModelBazyDanychDataContext db = new ModelBazyDanychDataContext();
            Zawodnicy = db.Zawodnik.Select(x=>new ZawodnikVM(x.imie,x.nazwisko,soc)
            {
                Id_zawodnika = x.id_zawodnika,
                Kraj =x.kraj,
                DataUrodzenia =(DateTime)x.data_ur,
                Waga= (int)x.waga,
                Wzrost = (int)x.wzrost
            })
                .ToArray();
           
             
        }

        public void Dodaj(ZawodnikVM z)
        {
            Zawodnik nowy = new Zawodnik()
            {
                imie = z.Imie,
                nazwisko = z.Nazwisko,
                kraj = z.Kraj,
                data_ur = z.DataUrodzenia,
                wzrost = z.Wzrost,
                waga = z.Waga
            };

            ModelBazyDanychDataContext db = new ModelBazyDanychDataContext();
            db.Zawodnik.InsertOnSubmit(nowy);
            db.SubmitChanges();
        }

        public void Edytuj(ZawodnikVM z)
        {
            ModelBazyDanychDataContext db = new ModelBazyDanychDataContext();
            var doEdycji = db.Zawodnik.FirstOrDefault(x => x.id_zawodnika == z.Id_zawodnika);

            doEdycji.imie = z.Imie;
            doEdycji.nazwisko = z.Nazwisko;
            doEdycji.kraj = z.Kraj;
            doEdycji.data_ur = z.DataUrodzenia;
            doEdycji.waga = z.Waga;
            doEdycji.wzrost = z.Wzrost;

            db.SubmitChanges();
        }

        public void Usun(int id)
        {
            ModelBazyDanychDataContext db = new ModelBazyDanychDataContext();
            var z =db.Zawodnik.FirstOrDefault(x => x.id_zawodnika == id);

            db.Zawodnik.DeleteOnSubmit(z);
            db.SubmitChanges();
        }
    }
}


/* Form1 (UI) 
 * ManagerZawodnikow (CRUD)
 * PolaczenieZBaza
 * Baza danych
 */