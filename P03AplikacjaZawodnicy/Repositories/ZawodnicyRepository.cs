using P03AplikacjaZawodnicy.ViewModels;
using P03AplikacjaZawodnicy.Tools;
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
        string connString = "Data Source=.;Initial Catalog=A_Zawodnicy;User ID=sa;Password=alx";

        public ZawodnikVM[] Zawodnicy;

        
        public void Wczytaj()
        {
            Wczytaj(null);
        }
        
        public void Wczytaj(CheckedItemCollection soc)
        {
          
            PolaczenieZBaza pzb = new PolaczenieZBaza(connString);

            object[][] wynik= pzb.WykonajZapytanieSQL("select * from zawodnicy");

            Zawodnicy = new ZawodnikVM[wynik.Length];

            for (int i = 0; i < wynik.Length; i++)
            {
                ZawodnikVM z = new ZawodnikVM((string)wynik[i][2], (string)wynik[i][3], soc);
                z.Id_zawodnika = (int)wynik[i][0];


                if(!(wynik[i][1] is DBNull))
                    z.Id_trenera = (int)wynik[i][1];

                //try
                //{
                //    z.Id_trenera = (int)wynik[i][1];
                //}
                //catch (Exception)
                //{

                //}
                // z.Id_trenera = (int?)wynik[i][1]; (NULL w bazie danych<> NULL w C#)

                z.Kraj = (string)wynik[i][4];
                z.DataUrodzenia = (DateTime)wynik[i][5];
                z.Wzrost = (int)wynik[i][6];
                z.Waga = (int)wynik[i][7];
                Zawodnicy[i] = z;
            }
        }

        public void Dodaj(ZawodnikVM z)
        {
            PolaczenieZBaza pzb = new PolaczenieZBaza(connString);

            string sql = 
                string.Format("insert into zawodnicy values(null, '{0}', '{1}', '{2}', '{3}', {4}, {5});",
                z.Imie,z.Nazwisko,z.Kraj,z.DataUrodzenia.ToString("yyyyMMdd"),z.Wzrost,z.Waga);
         
            pzb.WykonajZapytanieSQL(sql);
        }

        public void Edytuj(ZawodnikVM z)
        {
            PolaczenieZBaza pzb = new PolaczenieZBaza(connString);

            string sql = string.Format(
                "update zawodnicy set " +
                   " imie = '{0}', " +
                   " nazwisko = '{1}', " +
                   " kraj = '{2}', " +
                   " data_ur = '{3}', " +
                   " wzrost = {4}, " +
                   " waga = {5}" +
                   " where id_zawodnika = {6}",
                z.Imie,z.Nazwisko,z.Kraj,z.DataUrodzenia.ToString("yyyyMMdd"), z.Wzrost,z.Waga,z.Id_zawodnika);
          
            pzb.WykonajZapytanieSQL(sql);
        }

        public void Usun(int id)
        {
            PolaczenieZBaza pzb = new PolaczenieZBaza(connString);
            string sql = string.Format("delete zawodnicy where id_zawodnika={0}", id);

            pzb.WykonajZapytanieSQL(sql);

        }
    }
}


/* Form1 (UI) 
 * ManagerZawodnikow (CRUD)
 * PolaczenieZBaza
 * Baza danych
 */