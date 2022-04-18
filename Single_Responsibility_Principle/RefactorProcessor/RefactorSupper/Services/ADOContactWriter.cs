using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single_Responsibility_Principle.RefactorProcessor.RefactorSupper.Services
{
    public class ADOContactWriter : IContactWriter
    {
        public void Write(List<People> peoples)
        {
            var conn = new SqlConnection("server=(local);integrated security=sspi;database=SRP");
            conn.Open();
            foreach (var contact in peoples)
            {
                var command = conn.CreateCommand();
                command.CommandText = "INSERT INTO People (FirstName, LastName, Email) VALUES (@FirstName, @LastName, @Email)";
                command.Parameters.AddWithValue("@FirstName", contact.FirstName);
                command.Parameters.AddWithValue("@LastName", contact.LastName);
                command.Parameters.AddWithValue("@Email", contact.Email);
                command.ExecuteNonQuery();
            }
            conn.Close();

        }
    }
}
