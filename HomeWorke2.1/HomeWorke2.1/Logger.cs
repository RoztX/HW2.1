using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorke2._1
{
    public sealed partial class Logger
    {
        public List<string> _logs = new List<string>();
        private static readonly Logger instance = new Logger();

        static Logger()
        {

        }

        private Logger()
        {

        }

        public void Log(DateTime dateTime, LogType logType, string message)
        {
            var fullMessage = $"{dateTime} : {logType} : {message}";
            Console.WriteLine(fullMessage);
            _logs.Add(fullMessage);
        }

        public static Logger Instance
        {
            get
            {
                return instance;
            }
        }

        public List<string> GetLogs()
        {
            return _logs;
        }

        public void SavelogToFile()
        {
            string container ="";
            foreach (string log in _logs)
            {
                container = container + log;
            }
            File.WriteAllText("log.txt", container);
        }
    }
}
