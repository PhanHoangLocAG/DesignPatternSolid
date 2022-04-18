using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_Close_Principle
{
    public class ErrorLogger
    {
        private readonly string _whereToLog;

        public ErrorLogger(string whereToLog)
        {
            this._whereToLog = whereToLog;
        }

        public void LogError(string message)
        {
            switch (this._whereToLog)
            {
                case "TEXTFILE":
                    WriteTextFile(message);
                    break;
                case "EVENTLOG":
                    break ;
                default:
                    throw new Exception("Unable to log error");
            }
        }

        private void WriteTextFile(string message)
        {
            File.WriteAllText(@"N:\UTOP\Single_Responsibility_Principle\Open_Close_Principle\Data\Errors.txt", message);
        }

        private void WriteEventLog(string message)
        {
            string source = "DNC Magazine";
            string log = "Application";

            if (!EventLog.SourceExists(source))
            {
                EventLog.CreateEventSource(source, log);
            }
            EventLog.WriteEntry(source, message, EventLogEntryType.Error,1);
        }
    }
}
