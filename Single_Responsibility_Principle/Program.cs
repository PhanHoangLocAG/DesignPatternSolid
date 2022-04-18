using Single_Responsibility_Principle.RefactorProcessor;
using Single_Responsibility_Principle.RefactorProcessor.RefactorSupper.Services;
using System;
using System.IO;

namespace Single_Responsibility_Principle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = Path.Combine(Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName + "\\Data\\data.csv");

            /* CsvFileProcessor processor = new CsvFileProcessor();
             processor.Process(path);*/

            /* CsvFileProcessorRefactor csvFileProcessorRefactor = new CsvFileProcessorRefactor();
             csvFileProcessorRefactor.Process(path);*/

            CSVContactDataProvider dtp = new CSVContactDataProvider(path);
            CSVContactParser ps = new CSVContactParser();
            ADOContactWriter aDOContactWriter = new ADOContactWriter();

            aDOContactWriter.Write(ps.Parse(dtp.Read()));

            Console.WriteLine("Hello World!");
        }
    }
}
