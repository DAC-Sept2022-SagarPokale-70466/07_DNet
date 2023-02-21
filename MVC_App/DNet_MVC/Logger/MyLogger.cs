using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Web;

namespace DNet_MVC.Logger
{
    public class MyLogger
    {
        private MyLogger() { }

        private static MyLogger logger = new MyLogger();

        public static MyLogger CurrentLogger
        {
            get
            {
                return logger;
            }
        }

        public void Log(string message)
        {
            string filePath = ConfigurationManager.AppSettings["logFilePath"].ToString();
            FileStream fs = null;
            if (File.Exists(filePath))
            {
                fs = new FileStream(filePath, FileMode.Append, FileAccess.Write);
            }
            else
            {
                fs = new FileStream(filePath, FileMode.Create, FileAccess.Write);
            }

            StreamWriter writer = new StreamWriter(fs);
            writer.Write(message);
            writer.Close();
            fs.Close();
            writer = null;
            fs = null;
        }
    }
}