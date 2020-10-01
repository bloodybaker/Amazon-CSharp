using System;
using System.Collections.Generic;
using System.ServiceModel.Configuration;
using System.Text;

namespace Amazon_CSharp
{
    public class Logger
    {
        private const string INFO_PREFIX = "[INFO] ";
        private const string WARN_PREFIX = "[WARNING] ";
        private const string ERROR_PREFIX = "[ERROR] ";
        private const string ENDL = "\n";

        public void Log(string loggingString)
        {
            using (System.IO.StreamWriter file =
                new System.IO.StreamWriter(@".\log.txt", true))
            {
                file.WriteLine(GetCurrentTime() + INFO_PREFIX + loggingString + ENDL);
                file.Close();
            }
        }

        private string GetCurrentTime()
        {
            return "[ " + DateTime.Now.ToString("T") + "] ";
        }
    }
}