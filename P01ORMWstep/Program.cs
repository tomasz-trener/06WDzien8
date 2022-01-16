using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01ORMWstep
{
    class Program
    {
        static void Main(string[] args)
        {
            /* ORM  
             * LINQtoSQL - najprostsze ale o ogormych możliwościach  (MS SQL Server)
             * Entity framework - bardziej rozbudowane o większej liczbie możłiwsci konfiguracyjnych (Głownie MS SQL Server , da się skonfigurować polaczenie z innymi bazami danych) 
             * 
             * W każdym systemie orm sposób komunikacji z danymi jest dokładnie taki sam. język LINQ jest taki sam we wszystkich systemach orm 
             * 
             * Hibernate (N Hibernate dla .NET) - uniwersalne podjeście do komuniacji dowolną bazą danych 
             */

            ModelBazyDanychDataContext db = new ModelBazyDanychDataContext();

         //   Zawodnik[] zawodnicy=  db.Zawodnik.ToArray();

            //foreach (var z in zawodnicy)
            //    Console.WriteLine(z.imie + " " + z.nazwisko);


            // umiejętna komunikacja z danmi wymaga od nas znaomości skłądni LINQ

            //SQL : select * from zawodnicy order by kraj
            var wynik1 = db.Zawodnik.OrderBy(x => x.kraj).ToArray();


        
            //select * from zawodnicy order by kraj asc, wzrost desc
            var wynik2 = db.Zawodnik.OrderBy(x => x.kraj).ThenByDescending(x=>x.wzrost).ToArray();

            var wynik3 = db.Zawodnik.OrderBy(x => x.imie + " " + x.nazwisko).ToArray();

            //select * from zawodnicy order by LEN(nazwisko)
            Zawodnik[] wynik4 = db.Zawodnik.OrderBy(x => x.nazwisko.Length).ToArray();

           // foreach (var z in wynik4)
            //    Console.WriteLine(z.imie + " " + z.nazwisko + " " + z.kraj);

            // select imie from zawodnicy
            string[] wynik5 = db.Zawodnik.Select(x => x.imie).ToArray();

            //foreach (var z in wynik5)
            //    Console.WriteLine(z);

           // select imie +' ' + nazwisko from zawodnicy
           var wynik6 = db.Zawodnik.Select(x => x.imie + " " + x.nazwisko).ToArray();

            //select imie , nazwisko from zawodnicy

            ZawodnikMini[] wynik7 = db.Zawodnik
                .Select(x => new ZawodnikMini() { Imie = x.imie, Nazwisko = x.nazwisko })
                .ToArray();

            var wynik8 =
            db.Zawodnik
                .Select(x => new { MojeImie = x.imie, MojeNazwisko = x.nazwisko })
                .ToArray();

          
            // oczywscie mozemy laczyc ze soba polecenia 


            //select nazwisko from zawodnicy order by kraj
            var wynik9= db.Zawodnik.OrderBy(x => x.kraj).Select(x => x.nazwisko);

            var wynik10 = db.Zawodnik.Select(x => x.nazwisko).OrderBy(x => x);

            //select * from zawodnicy where kraj = 'pol'

            var wynik11 =
                db.Zawodnik.Where(x => x.kraj == "pol").ToArray();

            // select nazwisko from zawodnicy where kraj='pol' order by wzrost
            var wynik12=
                db.Zawodnik
                    .Where(x => x.kraj == "pol")
                    .OrderBy(x => x.wzrost)
                    .Select(x => x.nazwisko)
                    .ToArray();

            //foreach (var z in wynik12)
            //    Console.WriteLine(z);


            var wynik13 =
                db.Zawodnik.Select(x => x.nazwisko).ToArray();

            string[][] wynik14=
                wynik13.Select(x => x.Split('E')).ToArray();

            //for (int i = 0; i < wynik14.Length; i++)
            //    Console.WriteLine($"{wynik13[i]} Przed E: {wynik14[i][0]} i po E {wynik14[i][1]}");

            //for (int i = 0; i < wynik14.Length; i++)
            //    Console.WriteLine(string.Format("{0} : Przed E: {1} i po E {2}",
            //        wynik13[i], wynik14[i][0], wynik14[i].Length>1? wynik14[i][1]:""));


            // zad1 : wypisz imie, nazwisko i BMI zawodników  (waga[kg]/wzrost[m]^2)

            var wynik15= 
            db.Zawodnik.Select(
                x => new
                {
                    Imie = x.imie,
                    Nazwisko = x.nazwisko,
                    BMI = x.waga / Math.Pow((int)x.wzrost / 100.0, 2)
                }).ToArray();


            //foreach (var z in wynik15)
            //    Console.WriteLine(z.Imie + " " + z.Nazwisko + " " + string.Format("{0:00.00}",z.BMI));

            // zad2 : wypisz zawodników którzy mają imie i nazwisko zaczynające się albo kończące się na tę samą litrę

            var wynik16=
            db.Zawodnik
                .Where(x => x.imie.ToLower()[0] == x.nazwisko.ToLower()[0] 
                        || x.imie.ToLower()[x.imie.Length - 1] == x.nazwisko.ToLower()[x.nazwisko.Length - 1])
                .ToArray();

            foreach (var z in wynik16)
                Console.WriteLine(z.imie+  " " + z.nazwisko);


            // zad3 : wypisz zawodnika najstarszego

            var wynik17 = 
                db.Zawodnik.OrderBy(x => x.data_ur).ToArray()[0];

            // zad4 : wypisz wszystkich zawodników z tego kraju co zawodnik najlżejszy


            var wynik18 = db.Zawodnik.OrderBy(x => x.waga).ToArray()[0];

            var wynik19 =
                db.Zawodnik.Where(x => x.kraj == wynik18.kraj).ToArray();

            // zad5* wypisz imiona i nazwiska zawodniów wraz z podaniem liczby dni za ile będą mieli urodziny, posortuj 
            // wyniki tak aby najpierw byli Ci, którzy będą mieli urodziny najbliżej 

            var wynik20 =
            db.Zawodnik.Select(x => new
            {
                Imie = x.imie,
                Nazwisko = x.nazwisko,
                DataUr = x.data_ur,
                KiedyUrodziny = new DateTime(DateTime.Now.Year, x.data_ur.Value.Month, x.data_ur.Value.Day)<DateTime.Now? // jezeli juz mial urodziny w tym roku
                                new DateTime(DateTime.Now.Year+1, x.data_ur.Value.Month, x.data_ur.Value.Day) : // dodajemy +1 do roku
                                new DateTime(DateTime.Now.Year, x.data_ur.Value.Month, x.data_ur.Value.Day) // w przciwnym razie jego urodziny będą w aktualnym roku
            }).ToArray();

            var wynik21=
            wynik20.Select(x => new
            {
                Imie = x.Imie,
                Nazwisko = x.Nazwisko,
                DataUr = x.DataUr,
                ZaIleDniUrodziny = Math.Floor((x.KiedyUrodziny-DateTime.Now ).TotalDays)
            })
            .OrderBy(x=>x.ZaIleDniUrodziny)
            .ToArray();

            foreach (var z in wynik21)
                Console.WriteLine(string.Format("{0} urodzony {1:dd-MM-yyy} będzie miał urodziny za {2} dni",
                    z.Imie + " " + z.Nazwisko, z.DataUr, z.ZaIleDniUrodziny)
                    );



            //https://github.com/tomasz-trener/06WDzien8


            // grupwanie danych

            //select kraj, avg(wzrost)  from zawodnicy   group by kraj

            var wynik22 =
            db.Zawodnik
            .GroupBy(x => x.kraj)
            .Select(x => new 
            { 
                Kraj = x.Key, 
                SredniWzrost = x.Average(y => y.wzrost) 
            }
            ).ToArray();

            //foreach (var g in wynik22)
            //    Console.WriteLine(g.Kraj + " " + g.SredniWzrost);


            // zad1: Dla kazdego kraju podaj ilu jest zawodników wyzszych niz 180 cm

            var wynik23=
            db.Zawodnik
                .Where(x => x.wzrost > 180)
                .GroupBy(x => x.kraj)
                .Select(x => new { Kraj = x.Key, Ile = x.Count() })
                .ToArray();


            // wyrazenia linq mozemy stosowac nie tylko w kontekscie bazy danych 

            string napis = "ala ma kota i ma psa";
            string[] tablica = napis.Split(' ');
          //  string[] tablica = { "ala", "ma", "kota" ,"i","ma","psa" };

            //wypisz z duzych liter wyrazy dluzsze niz 2 znaki , posorotuj po długosci 

            var wynik24 =
            tablica.Where(x => x.Length > 2).OrderBy(x => x.Length).Select(x => x.ToUpper());

            Console.WriteLine(string.Join(" ", wynik24));


            string[,] tab2 = new string[2, 3];
            tab2[0, 0] = "ala";
            tab2[1, 0] = "ma";
            
            tab2[0, 1] = "kota";
            tab2[1, 1] = "i";

            tab2[0, 2] = "ma";
            tab2[1, 2] = "psa";

            // przekonwertowanie tablicy dwu wymiaorwej na tablice tablic 

            string[][] tab3 = new string[3][];
            tab3[0] = new string[2];
            tab3[0][0] = "ala";
            tab3[0][1] = "ma";

            tab3[1] = new string[2];
            tab3[1][0] = "kota";
            tab3[1][1] = "i";

            tab3[2] = new string[2];
            tab3[2][0] = "ma";
            tab3[2][1] = "psa";

            var wynik25=
            tab3.Where(x => x[0].Length == 2).ToArray();




            Console.ReadKey();



        }
    }
}
