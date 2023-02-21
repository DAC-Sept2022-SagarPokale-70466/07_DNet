using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_Entity_Framework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PuneDB mainObj = new PuneDB();

            //string tableData = mainObj.Tables.ToString();

            //foreach(Table data in mainObj.Tables.ToList())
            //{
            //    Console.WriteLine(data.Name);
            //}

            //------------------------------------------------

            //Table newTable = new Table();

            //newTable.Id = 101;
            //newTable.Name = "Anukesh";
            //newTable.Role = "Doctor";

            //mainObj.Tables.Add(newTable);
            //mainObj.SaveChanges();

            //------------------------------------------------

            //Table updateData = mainObj.Tables.Find(2);
            //updateData.Name = "Pokale";
            //mainObj.SaveChanges();

            //------------------------------------------------

            //Table dataToRemove = mainObj.Tables.Find(2);
            //mainObj.Tables.Remove(dataToRemove);

            //mainObj.SaveChanges();



            Console.ReadLine();
        }
    }
}
