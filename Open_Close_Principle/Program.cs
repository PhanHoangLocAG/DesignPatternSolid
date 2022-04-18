using System;

namespace Open_Close_Principle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ErrorLogger errorLogger = new ErrorLogger("TEXTFILE");
            errorLogger.LogError("log error location");
            Console.WriteLine("success");
        }
    }
}
