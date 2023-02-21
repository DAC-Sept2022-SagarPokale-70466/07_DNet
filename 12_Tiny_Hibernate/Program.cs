
using MyAnnotation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using MyAnnotation;


namespace _12_Tiny_Hibernate
{
    class Program
    {
        static void Main(string[] args)
        {
            string pathOfAssembly = @"G:\C-Dac\7_.NET\Projects\Demo\Demo\PocoLib\bin\Debug\PocoLib.dll";

            Assembly assembly = Assembly.LoadFrom(pathOfAssembly);

            Type[] allTypes = assembly.GetTypes();
            foreach (Type type in allTypes)
            {
                string details = "";
                IEnumerable<Attribute> allAttributesOnType = type.GetCustomAttributes();

                foreach (Attribute attribute in allAttributesOnType)
                {
                    if (attribute is Table)
                    {
                        Table tableDetails = (Table)attribute;
                        details = details + "Create table " + tableDetails.Name + "(";
                        break;
                    }
                }

                PropertyInfo[] allProperties = type.GetProperties();

                foreach (PropertyInfo property in allProperties)
                {
                    IEnumerable<Attribute> allPropertyAttributes =
                             property.GetCustomAttributes();

                    foreach (Attribute attributeOnProperty in allPropertyAttributes)
                    {
                        if (attributeOnProperty is Column)
                        {
                            Column columnDetails =
                                    (Column)attributeOnProperty;
                            details = details + columnDetails.Name + " " +
                                      columnDetails.Type + ",";
                            break;
                        }
                    }
                }


                details = details.TrimEnd(',');
                details = details + ")";
                Console.WriteLine(details);

                Console.ReadLine();
            }
        }
    }
}
