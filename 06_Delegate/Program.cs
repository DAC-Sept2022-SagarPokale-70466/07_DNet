using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Delegate
{
    public delegate string MyDelegate();    // Mydelegate function pointer which acceptes nothing and return string;

    class Program
    {
        static void Main(string[] args)
        {
            B obj = new B();
            C obj2 = new C();

            MyDelegate pointer = new MyDelegate(obj.M2);  // Pointing to some class Method

            A objOfA = new A();
            objOfA.M1(pointer);
        }


    }

    class A
    {
        public void M1(MyDelegate pointerToSomeFunction)
        {
            string someOutput = pointerToSomeFunction();
            Console.WriteLine(someOutput);
        }
    }



    class B
    {
        public string M2()
        {
            return "M2 Method from C Class";
        }

    }

    class C
    {
        public string M3()
        {
            return "M3 Method from C Class";
        }
    }

}
