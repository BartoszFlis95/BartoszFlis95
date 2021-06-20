using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Zadanie5YT
{
    public class Rejestracja
    {
        public void RejestracjaUzytkownika(string login, string haslo)
        {
            string zapytanieSQL = $"insert into [dbo].[Users] (login, password) values('{login}', '{haslo}')";
            SqlConnection connection = new SqlConnection(@"Server=(LocalDb)\MSSQLLocalDB;Database=Nauka;Trusted_Connection=True;");
            SqlCommand command = new SqlCommand(zapytanieSQL, connection);

            
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();

        }

    }
}
