using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Zadanie5YT
{
    class BibliotekaUrzytkownik
    {
       public List<Uzytkownik> lista = new List<Uzytkownik>();
        

        public BibliotekaUrzytkownik()
        {
            
            
            
        }

        public void UzytkownikDownload()
        {

            string zapytanieSQL = ("select * from users");
            SqlConnection connection = new SqlConnection(@"Server=(LocalDb)\MSSQLLocalDB;Database=Nauka;Trusted_Connection=True;");
            SqlCommand command = new SqlCommand(zapytanieSQL, connection);

            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Uzytkownik Uzytkownik = new Uzytkownik(reader["password"].ToString(), reader["login"].ToString());
                lista.Add(Uzytkownik);
            }
            connection.Close();

        }





    }
}

