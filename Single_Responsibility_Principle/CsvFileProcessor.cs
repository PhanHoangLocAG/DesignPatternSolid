using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single_Responsibility_Principle
{
    public class CsvFileProcessor
    {
        public void Process(string fileName)
        {
            List<string> temp = new List<string>();
            using (var reader = new StreamReader(fileName))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    temp.Add(line);
                }
            }
            var conn = new SqlConnection("server=(local);integrated security=sspi;database=SRP");
            conn.Open();




            foreach (string line in temp) {
                string[] columns = line.Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries);
                
                var command = conn.CreateCommand();

                command.CommandText = "INSERT INTO PEOPLE(FirstName,LastName,Email) VALUES (@FirstName,@LastName,@Email)";

                command.Parameters.AddWithValue("@FirstName", columns[0]);
                command.Parameters.AddWithValue("@LastName", columns[1]);
                command.Parameters.AddWithValue("@Email", columns[2]);

                command.ExecuteNonQuery();

            }

            conn.Close();
        }
    }
}
