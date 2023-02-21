using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 : SQL , 2 : Oracle");
            int choice = Convert.ToInt32(Console.ReadLine());

            DBFactory dbfactory = new DBFactory();

            IDatabase databasedb = dbfactory.GetMyDatabase(choice);

            databasedb.Delete();

            Console.ReadLine();
        }
    }

    public interface IDatabase
    {
        void Insert();

        void Update();

        void Delete();
    }

    public class DBFactory
    {
        public IDatabase GetMyDatabase(int choice)
        {
            if (choice == 1)
            {
                return new SQLServer();
            }
            else
                return new OracleServer();
        }
    }

    public class SQLServer : IDatabase
    {
        public void Delete()
        {
            Console.WriteLine("SQLServer Deleted function");
            Logger.GetLogger().insertLog("Delete Logged");
        }

        public void Insert()
        {
            Console.WriteLine("SQLServer Insert Function");
            Logger.GetLogger().insertLog("Insert Logged");
        }

        public void Update()
        {
            Console.WriteLine("SQLServer Update Function");
            Logger.GetLogger().insertLog("Update Logged");
        }
    }

    public class OracleServer : IDatabase
    {
        public void Delete()
        {
            Console.WriteLine("OracleServer Delete Function");
            Logger.GetLogger().insertLog("Delete Logged");
        }

        public void Insert()
        {
            Console.WriteLine("OracleServer Insert Function");
            Logger.GetLogger().insertLog("Insert Logged");
        }

        public void Update()
        {
            Console.WriteLine("OracleServer Update Function");
            Logger.GetLogger().insertLog("Update Logged");
        }
    }

    public class Logger
    {
        private static Logger logger = new Logger();

        private Logger()
        {
            Console.WriteLine("Constructor initialized");
        }

        public static Logger GetLogger()
        {
            return logger;
        }

        public void insertLog(string msg)
        {
            Console.WriteLine("Logged at " + DateTime.Now.ToString() + " for " + msg);
        }

    }

}
