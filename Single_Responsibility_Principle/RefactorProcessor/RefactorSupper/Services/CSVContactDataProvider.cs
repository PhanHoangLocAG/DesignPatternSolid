using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single_Responsibility_Principle.RefactorProcessor.RefactorSupper.Services
{
    public class CSVContactDataProvider : IContactDataProvider
    {
        private readonly string _filename;

        public CSVContactDataProvider(string fileName)
        {
            _filename = fileName;
        }

        public string Read()
        {
            TextReader tr = new StreamReader(_filename);
            tr.ReadToEnd();
            tr.Close();
            return tr.ToString();
        }
    }
}
