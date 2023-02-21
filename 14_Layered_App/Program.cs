using _14_Layered_App.DAL;
using _14_Layered_App.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _14_Layered_App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------------------------------------------");

            EmpDataAccess dalObject = new EmpDataAccess();
            Emp myemp = new Emp();
            int choice;
            do
            {
                Console.WriteLine("1 . List of all Employee");
                Console.WriteLine("2 . Update Employee");
                Console.WriteLine("3 . Add an Employee");
                Console.WriteLine("4 . Delete An Employee");

                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        List<Emp> employee = dalObject.getAllEmployee();
                        foreach (Emp emp in employee)
                        {
                            Console.WriteLine(emp.Name);
                        }

                        Console.ReadLine();
                        break;

                    case 2:


                        Console.WriteLine("TO Update the employee input");

                        Console.WriteLine("Emp No : ");
                        myemp.No = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Emp Name : ");
                        myemp.Name = Console.ReadLine();

                        Console.WriteLine("Emp Address : ");
                        myemp.Address = Console.ReadLine();


                        int affetectedRow = dalObject.UpdateEmployee(myemp);

                        Console.WriteLine(affetectedRow + " rows Afftecteed ");
                        Console.ReadLine();
                        break;


                    case 3:

                        Console.WriteLine("TO Add the employee input");

                        Console.WriteLine("Emp No : ");
                        myemp.No = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Emp Name : ");
                        myemp.Name = Console.ReadLine();

                        Console.WriteLine("Emp Address : ");
                        myemp.Address = Console.ReadLine();


                        affetectedRow = dalObject.AddEmployee(myemp);

                        Console.WriteLine(affetectedRow + " rows Afftecteed ");
                        Console.ReadLine();
                        break;


                    case 4:

                        Console.WriteLine("Emp No : ");
                        int no = Convert.ToInt32(Console.ReadLine());

                        affetectedRow = dalObject.RemoveEmployee(no);

                        Console.WriteLine(affetectedRow + " rows Afftecteed ");
                        Console.ReadLine();

                        break;


                    default:
                        break;
                }

            } while (choice != 0);

            Console.WriteLine("--------------------------------------------");




        }
    }
}
