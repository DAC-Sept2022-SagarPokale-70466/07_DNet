using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace _04_Generic
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Calling the Generic method from Generic Class

            //Math<int> math = new Math<int>();

            //int a = 101; int b = 202;

            //Console.WriteLine(string.Format("Before the Swap a = {0} and b = {1}",a, b));
            //math.Swap(ref a,ref b);
            //Console.WriteLine(string.Format("After the Swap A = {0} and B = {1}", a, b));

            #endregion

            #region Calling the Normal method and Generic Method from Normal Class

            //myClass obj = new myClass();
            //obj.sayHello();
            //int a = 101;
            //int b = 201;
            //Console.WriteLine("Before Swapping a = "+a+" b = "+b);
            //obj.Swap<int>(ref a, ref b);


            //Console.WriteLine("After Swapping a = " + a + " b = " + b);

            #endregion

            #region Calling the Generic Method Swap from inheritance

            ChildClass childObj = new ChildClass();
            //int a = 1;
            //int b = 2;
            //Console.WriteLine("Before Swapping A = {0} $ B = {1}", a, b);
            //childObj.Swap(ref a, ref b);
            //Console.WriteLine("Before Swapping A = {0} $ B = {1}", a, b);

            #endregion

            #region Using Inheritance in Generic

            SpecialAnotherClass<String, int, short, bool> obj = new SpecialAnotherClass<string, int, short, bool>();

            int p = 101;
            int q = 201;

            Console.WriteLine("Before Swap From Parent Method with child obj A = {0} B = {1}", p, q);

            obj.Swap(ref p, ref q);

            Console.WriteLine("After Swap From Parent Method with child obj A = {0} B = {1}", p, q);
            #endregion

            Console.ReadLine();
        }
    }

    //-------------------------------------------------------------------------

    public class Math<T>
    {
        public void Swap(ref T x, ref T y)
        {
            T z = x;
            x = y;
            y = z;
        }
    }

    //-------------------------------------------------------------------------

    public class myClass
    {
        public void sayHello()
        {
            Console.WriteLine("HOLLA");
        }

        public void Swap<T>(ref T x, ref T y)
        {
            T z = x;
            x = y;
            y = z;
        }
    }

    //-------------------------------------------------------------------------

    // Innherting the Generic class into Normal class
    public class newClass<T>
    {
        public void Swap(ref T x, ref T y)
        {
            T z = x;
            x = y;
            y = z;
        }

    }

    public class ChildClass : newClass<int>
    {
    }


    //------------------------------------------------------------------------

    public class anotherClass<T>
    {
        public void Swap(ref T x, ref T y)
        {
            T z = x;
            x = y;
            y = z;
        }
    }

    public class SpecialAnotherClass<P, Q, R, S> : anotherClass<Q>
    {

        public P someAnotherMethod(P p1, Q q1, R r1, S s1)
        {
            return p1;
        }
    }


}
