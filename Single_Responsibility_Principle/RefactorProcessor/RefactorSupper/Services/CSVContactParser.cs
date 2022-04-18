using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single_Responsibility_Principle.RefactorProcessor.RefactorSupper.Services
{
    public class CSVContactParser : IContactParser
    {
      
            public List<People> Parse(string csvData)
            {
                List<People> contacts = new List<People>();
                string[] lines = csvData.Split(new string[] { @"\r\l" }, StringSplitOptions.RemoveEmptyEntries);
                foreach (string line in lines)
                {
                    string[] columns = line.Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries);
                    var contact = new People
                    {
                        FirstName = columns[0],
                        LastName = columns[1],
                        Email = columns[2]
                    };
                    contacts.Add(contact);
                }

                return contacts;
            }
    }
}
