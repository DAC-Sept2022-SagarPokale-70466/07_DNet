using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _11_Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Version 1


            //string pathOfAssembly = @"G:\C-Dac\7_.NET\Projects\Demo\Demo\DLL File\bin\Debug\DLL File.dll";

            //Assembly assembly = Assembly.LoadFrom(pathOfAssembly);

            //Type[] types = assembly.GetTypes();

            //Console.WriteLine("Types are : ");

            //foreach (Type type in types)
            //{
            //    Console.WriteLine("-----------------------------------------------------");

            //    Console.WriteLine(type.Name); // return the class name 
            //    Console.WriteLine(type.FullName);

            //    MethodInfo[] allMethods = type.GetMethods();

            //    foreach(MethodInfo method in allMethods)
            //    {
            //        Console.WriteLine("*****************************************");
            //        string details = "";
            //        details = details + method.ReturnType + " " + method.Name + "(";

            //        ParameterInfo[] parameter = method.GetParameters();
            //        foreach(ParameterInfo param in parameter)
            //        {
            //            details = details + param.ParameterType.ToString() + " " + param.Name + " " + ",";
            //        }

            //        details = details.TrimEnd(',');
            //        details = details + ")";
            //        Console.WriteLine(details);
            //    }
            //}

            #endregion

            #region Version 2

            //string pathOfAssembly = @"G:\C-Dac\7_.NET\Projects\Demo\Demo\DLL File\bin\Debug\DLL File.dll";

            //Assembly assembly = Assembly.LoadFrom(pathOfAssembly);

            //Type[] types = assembly.GetTypes();

            //foreach (Type type in types)
            //{
            //    Console.WriteLine("------------------------------------------");
            //    Console.WriteLine(type.FullName);

            //    IEnumerable<Attribute> allAttributesOnTypes = type.GetCustomAttributes();

            //    bool isTypeSerilizable = false;

            //    foreach (Attribute atr in allAttributesOnTypes)
            //    {
            //        //Console.WriteLine(atr);
            //        if (atr is SerializableAttribute)
            //        {
            //            isTypeSerilizable = true;
            //            break;
            //        }
            //    }

            //    if (isTypeSerilizable)
            //        Console.WriteLine(type.Name + "is marked as Serializable :");
            //    else
            //        Console.WriteLine(type.Name + "is NOT marked as Serializable :");

            //    Console.WriteLine("----------------------------------------------");

            //    MethodInfo[] methodInfos = type.GetMethods();

            //    foreach (MethodInfo method in methodInfos)
            //    {
            //        //string details = "";
            //        //details = details +method.ReturnType+ " " +method.Name;
            //        //Console.WriteLine(details);

            //        string details = "";
            //        details = details + method.ReturnType + " " + method.Name + "( ";

            //        ParameterInfo[] allParams = method.GetParameters();
            //        foreach (ParameterInfo parameter in allParams)
            //        {
            //            details = details + parameter.ParameterType.ToString()
            //                        + " " + parameter.Name + ",";
            //        }

            //        details = details.TrimEnd(',');
            //        details = details + ")";
            //        Console.WriteLine(details);
            //        Console.WriteLine("-----------------------------------");
            //    }
            //}


            #endregion 

            #region Version 3 Create a Dynyamic Object

            string pathOfAssembly = @"G:\C-Dac\7_.NET\Projects\Demo\Demo\DLL File\bin\Debug\DLL File.dll";
            
            Assembly assembly = Assembly.LoadFrom(pathOfAssembly);

            Type[] allTypes = assembly.GetTypes();

            object dynamicObejct = null;

            foreach (Type type in allTypes)
            {
                Console.WriteLine("-----------------------------------");

                Console.WriteLine("Creating object of Type : " +
                                                    type.FullName);

                dynamicObejct = assembly.CreateInstance(type.FullName);

                Console.WriteLine("-----------------------------------");

                MethodInfo[] allMethods = type.GetMethods();

                foreach (MethodInfo method in allMethods)
                {
                    Console.WriteLine("Calling Method : " + method.Name);

                    ParameterInfo[] allParams = method.GetParameters();

                    object[] allParameterValues =
                                new object[allParams.Length];

                    for (int i = 0; i < allParams.Length; i++)
                    {
                        ParameterInfo parameter = allParams[i];
                        Console.WriteLine("Enter value for {0} of type {1}", parameter.Name, parameter.ParameterType);

                                    allParameterValues[i] =
                                        Convert.ChangeType(Console.ReadLine(),
                                                           parameter.ParameterType);

                    }



                    object result = type.InvokeMember(method.Name,
                                         BindingFlags.Public |
                                         BindingFlags.Instance |
                                         BindingFlags.InvokeMethod,
                                         null, dynamicObejct,
                                         allParameterValues);

                    Console.WriteLine(result);

                }


            }

            #endregion
        }
    }


}
