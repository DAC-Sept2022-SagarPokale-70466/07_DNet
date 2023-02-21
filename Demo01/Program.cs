using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using DLL_File;

namespace Demo01
{
    class Program
    {
        static void Main(string[] args)
        {
            Arithmatic myClass = new Arithmatic();

            Console.WriteLine("Holla");
            Arithmatic calculation = new Arithmatic();

            int num;

            do
            {
                Console.WriteLine("*******************************************");
                Console.WriteLine("1. Addition ");
                Console.WriteLine("2. SUbstraction ");
                Console.WriteLine("3. Multiplication ");
                Console.WriteLine("4. Division ");
                Console.WriteLine("*******************************************");

                String read = Console.ReadLine();
                num = Convert.ToInt32(read);

                switch (num)
                {
                    case 1:
                        Console.WriteLine("Enter Two Values : ");

                        String value1 = Console.ReadLine();
                        int num1 = Convert.ToInt32(value1);

                        String Value2 = Console.ReadLine();
                        int num2 = Convert.ToInt32(Value2);

                        int ans = calculation.Add(num2, num1);
                        Console.WriteLine("Addition = " + ans);
                        break;

                    case 2:
                        Console.WriteLine("Enter Two Values : ");

                        String value2 = Console.ReadLine();
                        num1 = Convert.ToInt32(value2);

                        Value2 = Console.ReadLine();
                        num2 = Convert.ToInt32(Value2);

                        ans = calculation.Subtract(num2, num1);
                        Console.WriteLine("Subtraction = " + ans);
                        break;

                    case 3:
                        Console.WriteLine("Enter Two Values : ");

                        value2 = Console.ReadLine();
                        num1 = Convert.ToInt32(value2);

                        Value2 = Console.ReadLine();
                        num2 = Convert.ToInt32(Value2);

                        ans = calculation.Multiplication(num2, num1);
                        Console.WriteLine("Multiplication = " + ans);
                        break;

                    case 4:
                        Console.WriteLine("Enter Two Values : ");

                        value2 = Console.ReadLine();
                        num1 = Convert.ToInt32(value2);

                        Value2 = Console.ReadLine();
                        num2 = Convert.ToInt32(Value2);

                        ans = calculation.Divide(num2, num1);
                        Console.WriteLine("Division = " + ans);
                        break;



                    default:

                        break;
                }

            } while (num != 0);

            #region MyRegion

            //Console.WriteLine("Enter One value : ");
            //String readValue = Console.ReadLine();

            //Console.WriteLine("Enter the Second value : ");
            //String readValue2 = Console.ReadLine();

            //Console.WriteLine("You entered the value of " + readValue + " and " + readValue2);
            //Console.WriteLine();


            //int addition = calculation.Add(Convert.ToInt32(readValue), Convert.ToInt32(readValue2));

            //Console.WriteLine("Addition is : " + addition);
            #endregion



        }
    }
}
