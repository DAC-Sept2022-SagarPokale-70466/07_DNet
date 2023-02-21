using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Event_Based_Log_Delegate_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mydelegate pointer = new Mydelegate(CodeToExecutedAfterInsert);
            SQLServer DB = new SQLServer();

            DB.AfterInsert += pointer;      // Appending delegate to Event

            DB.Insert();

            Console.ReadLine();

        }

        public static void CodeToExecutedAfterInsert()
        {
            Console.WriteLine("MY Log related code");
        }
    }

    public delegate void Mydelegate();


    class SQLServer
    {
        public event Mydelegate AfterInsert;// AfterInsert is an event pointing to Mydelegate type of Pointer

        public void Insert()
        {
            Console.WriteLine("Insert done in SQL Server");
            AfterInsert();
        }
    }
}
