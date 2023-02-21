using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _19_Features_.Net
{
    class Program
    {
        public delegate bool MyDelegate(int i);

        static void Main(string[] args)
        {
            #region Partil Class Concept

            // See we have now two different class with same name in different location 
            //By using the partial keyword we can make then in single class

            //Math m1 = new Math();
            //m1.Add(3,4);
            //m1.Sub(3,4);

            #endregion

            #region Nullable

            //int i = null; // This will generate error

            //int? i = null;
            //OR
            //Nullable<int> i = null;

            //if (i.HasValue)
            //{
            //    Console.WriteLine("I hase value : "+i.ToString());
            //}
            //else
            //{
            //    Console.WriteLine("I holds NULL");
            //}

            #endregion

            #region Call Method

            //bool result = Check(20);
            //Console.WriteLine("Result : " + result);

            #endregion

            #region Call method using Delegate

            //MyDelegate pointer = new MyDelegate(Check);
            //bool result = pointer(20);
            //Console.WriteLine("Result : " + result);

            #endregion

            #region Call method using anonymous Method Concept

            //MyDelegate pointer = delegate (int i)
            //                                    {
            //                                        return (i > 20);
            //                                    };
            //bool result = pointer(0);
            //Console.WriteLine("Result : " + result);

            #endregion

            #region Call method using Lambda Expression concept

            //Here First see the return type of the function and according to its stucture is defined 

            //MyDelegate pointer = (i) =>
            //{
            //    return (i > 10);
            //};

            //bool result = pointer(20);
            //Console.WriteLine("Result : " + result);

            #endregion

            #region Call Lambda Expression Using Function Delegate

            Func<int, bool> pointer = (i) =>
                                            {
                                                return (i > 10);
                                            };

            #endregion

            //----------------------------------------------

            #region Call Lambda Expression using Func Delegate

            //1: Create a Optimized Expression Tree. Store in a variable
            // Expression<Func<int, bool>> tree = (i) =>  (i > 10);

            //2: Compile the Tree in Binary - Hold it as function 
            // Func<int, bool> pointer = tree.Compile();

            //3: Execute the Tree by passing parameter: pointer(20);
            #endregion

            //----------------------------------------------

            #region Iterator

            //without the help of IEnumberable we can not get the obj iterated

            Week week = new Week();

            //foreach(string days in week)
            //{
            //    Console.WriteLine(days.ToString());
            //}

            #endregion

            #region Implicit type

            //Object o = 100;
            //o = new Week();

            var v = 100;
            ////v = "abc";

            //while declaring the implicit type of variable initilizatioin is needed

            #endregion

            #region Object Initializer

            Customer customer = new Customer();

            // Normal People
            //customer.No = 1;
            //customer.Name = "Sagar";

            // ME
            Customer customer1 = new Customer() { No = 101, Name = "Sush" };

            #endregion

            #region Anonymous Type Basic Concept

            //var var1 = new { MyNo = 1, MyName = "Sagar" };

            //Console.WriteLine(var1.GetType());

            //Console.WriteLine(var1.MyNo + var1.MyName);

            #endregion

            #region Anonymous Type Basic Concept  - 2

            // Both the Object will get the different Structure

            //var v1 = new { No = 1, Name = "Duryodhan" };
            //Console.WriteLine(v1.GetType());

            //var v2 = new { No = "abcd", Name = 1234};
            //Console.WriteLine(v2.GetType());
            #endregion

            #region Extension Method

            string str = "ab@a.com";

            bool isValid = MyString.CheckForValidMailAddress<string>(str, 199);

            //OR

            // Obj with which you call a method -> its 1st parameter is itself the object(i.e Method Chaining)

            bool checkValid = str.CheckForValidMailAddress(199);

            Console.WriteLine("Check Valid String : " + isValid);

            Console.WriteLine("Check Valid String : " + checkValid);

            #endregion

            #region List<Emp> Sample Data

            List<Emp> emps = new List<Emp>()
            {
                new Emp{  No = 11, Name = "Mahesh", Address = "Pune"},
                new Emp{  No = 12, Name = "Nilesh", Address = "Mumbai"},
                new Emp{  No = 13, Name = "Suresh", Address = "Puri"},
                new Emp{  No = 14, Name = "Ramesh", Address = "Manglore"},
                new Emp{  No = 15, Name = "Hitesh", Address = "Pune"}
            };

            #endregion

            #region Normal ForEach Based Filter

            List<Emp> FilteredResult = new List<Emp>();

            foreach (Emp emp in emps)
            {
                if (emp.Address.Contains("P"))
                {
                    FilteredResult.Add(emp);
                }
            }

            #endregion

            #region Iterate the FilteredResult

            //foreach (Emp result in FilteredResult)
            //{
            //    Console.WriteLine("{0}, {1}, {2}", result.No, result.Name, result.Address);
            //}

            #endregion

            #region Lazy Execution of LINQ

            //var resultLINQ = (from emp in emps where emp.Address.StartsWith("P") select emp);

            //var filteredResult = (from emp in emps
            //                      where emp.Address.StartsWith("P")
            //                      select emp).ToList();

            //emps.Add(new Emp
            //{
            //    No = 55,
            //    Name = "Shakal",
            //    Address = "Pune"
            //});

            //foreach (Emp result in filteredResult)
            //{
            //    Console.WriteLine("{0},{1},{2}", result.No, result.Name, result.Address);
            //}

            #endregion

            #region Proof of Concept that Where Select are Methods

            //Func<Emp, bool> check = (emp) =>
            //{
            //    return emp.Address.StartsWith("P");
            //};

            //Console.WriteLine("Proof that where is a method : "+check);

            ////----------------------------------------------------------

            //var filterResult = emps.Where((emp) =>
            //{
            //    return emp.Address.StartsWith("P");
            //});

            //Console.WriteLine("Proof that where is a method : " + filterResult);

            #endregion

            #region LINQ To return List<ResultHolder>
            var filteredFResult = (from emp in emps
                                   where emp.Address.StartsWith("P")
                                   select new ResultHolder
                                   {
                                       ENo = emp.No,
                                       EName = emp.Name
                                   });

            foreach (var item in filteredFResult)
            {
                Console.WriteLine(item.ENo + item.EName);
            }
            #endregion

            #region LINQ To Return List<Anonymous Type Collection
            //var filteredFResult = (from emp in emps
            //                       where emp.Address.StartsWith("P")
            //                       select new 
            //                       {
            //                           ENo = emp.No,
            //                           EName = emp.Name
            //                       }).ToList();

            //foreach (var item in filteredFResult)
            //{
            //    Console.WriteLine(item.ENo + item.EName);
            //}
            #endregion

            #region LINQ To Return List<Anonymous Type Collection
            //var filteredFResult = (from emp in emps
            //                       where emp.Address.StartsWith("P")
            //                       select new 
            //                       {
            //                           ENo = emp.No,
            //                           EName = emp.Name
            //                       }).ToList();

            //foreach (var item in filteredFResult)
            //{
            //    Console.WriteLine(item.ENo + item.EName);
            //}
            #endregion

            #region Partial Method
            Test test = new Test();
            test.DoSomething();

            #endregion

            Console.ReadLine();
        }

        public static bool Check(int i)
        {
            return (i > 10);
        }
    }


    public class Week : IEnumerable
    {
        private string[] days = new string[] { "Monday", "Tueday", "Wednesday", "Thursday", "Fridat", "Saturdat", "Sunday" };

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < days.Length; i++)
            {
                yield return days[i];
            }
        }
    }

    // Auto Property
    public class Customer
    {
        #region Auto Property
        public int No { get; set; }

        public string Name { get; set; }

        #endregion
    }

    public static class MyString
    {
        public static bool CheckForValidMailAddress<T>(this T word, int someMorePara)
        {
            //if (word is string)
            //return word.Contains("@");
            return false;
        }
    }

    public class Emp
    {
        public int No { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }
    }

    public class ResultHolder
    {
        public int ENo { get; set; }
        public string EName { get; set; }
    }

}
