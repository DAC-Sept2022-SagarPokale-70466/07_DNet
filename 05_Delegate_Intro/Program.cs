using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Delegate_Intro
{
    delegate bool Mydeledate(int x);        // Delegate is a pointer to function which will accept int and return bool
    class Program
    {

        static void Main(string[] args)
        {
            Mydeledate pointer1 = new Mydeledate(Check);        // Pointer to function

            //bool result = Check(20);

            bool result = pointer1(20);     // Passing function pointer with the pareameter

            Console.WriteLine("Result is " + result);
        }



        public static bool Check(int i)
        {
            return (i > 10);
        }
    }
}
