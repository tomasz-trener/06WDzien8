using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03AplikacjaZawodnicy.Tools
{
    public class PolaczenieZBaza
    {

        private string connString;

        public PolaczenieZBaza(string connString)
        {
            this.connString = connString;
        }


        public object[][] WykonajZapytanieSQL(string sql)
        {
            SqlConnection connection; // do komumikacji z baza danych 
            SqlCommand command; // przechowywanie polecen SQL 
            SqlDataReader dataReader; // czytania odpowiedzi z bazy danych 

            connection = new SqlConnection(connString);

            command = new SqlCommand(sql, connection);

            List<object[]> listaWierszy = new List<object[]>();

            try
            {
                connection.Open();
                dataReader = command.ExecuteReader(); // wysłanie polecenia sql do bazy
                                                      // dataReader jest uchwytem do wyniku 
                while (dataReader.Read())
                {
                    object[] wiersz = new object[dataReader.FieldCount];
                    for (int i = 0; i < dataReader.FieldCount; i++)
                    {
                        wiersz[i] = dataReader.GetValue(i);
                    }
                    listaWierszy.Add(wiersz);
                }
            }
            catch (Exception ex)
            {
                  throw ex;
                //  Console.WriteLine(ex.Message);
                //Console.WriteLine("błąd bazy danych");
            }
            finally
            {
                connection.Close();
            }
            return listaWierszy.ToArray();
        }


    }
}
