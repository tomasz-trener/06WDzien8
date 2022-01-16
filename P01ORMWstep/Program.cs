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

            foreach (var z in wynik12)
                Console.WriteLine(z);


            var wynik13 =
                db.Zawodnik.Select(x => x.nazwisko).ToArray();

            string[][] wynik14=
                wynik13.Select(x => x.Split('E')).ToArray();

            //for (int i = 0; i < wynik14.Length; i++)
            //    Console.WriteLine($"{wynik13[i]} Przed E: {wynik14[i][0]} i po E {wynik14[i][1]}");

            for (int i = 0; i < wynik14.Length; i++)
                Console.WriteLine(string.Format("{0} : Przed E: {1} i po E {2}",
                    wynik13[i], wynik14[i][0], wynik14[i].Length>1? wynik14[i][1]:""));


            // zad1 : wypisz imie, nazwisko i BMI zawodników  (waga[kg]/wzrost[m]^2)
            
            // zad2 : wypisz zawodników którzy mają imie i nazwisko zaczynające się albo kończące się na tę samą litrę

            // zad3 : wypisz zawodnika najstarszego

            // zad4 : wypisz wszystkich zawodników z tego kraju co zawodnik najlżejszy

            // zad5* wypisz imiona i nazwiska zawodniów wraz z podaniem liczby dni za ile będą mieli urodziny, posortuj 
            // wyniki tak aby najpierw byli Ci, którzy będą mieli urodziny najbliżej 



            Console.ReadKey();



        }
    }
}
