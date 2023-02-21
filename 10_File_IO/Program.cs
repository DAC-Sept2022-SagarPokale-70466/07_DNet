using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.IO;
using System.CodeDom;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.InteropServices;
using System.Xml.Serialization;

namespace _10_File_IO
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Simple File writing
            //string pathName = ConfigurationManager.AppSettings["logFilePath"];

            //FileStream fs = null;

            //if (File.Exists(pathName))
            //{
            //    fs = new FileStream(pathName, FileMode.Append, FileAccess.Write);
            //}
            //else
            //{
            //    fs = new FileStream(pathName, FileMode.Create, FileAccess.Write);
            //}

            //StreamWriter writer = new StreamWriter(fs);

            //writer.WriteLine("fsdfasdf");

            //writer.Close();

            //fs.Close();

            //Console.WriteLine("Done Writing");
            //Console.ReadLine();
            #endregion

            #region Simple File reading

            //string path = ConfigurationManager.AppSettings["logFilePath"];

            //FileStream fs = null;

            //if (File.Exists(path))
            //{
            //    fs = new FileStream(path, FileMode.Open, FileAccess.Read);

            //    StreamReader reader = new StreamReader(fs);

            //    string dataFromFile = reader.ReadToEnd();

            //    Console.WriteLine(dataFromFile);

            //    reader.Close();
            //    fs.Close();
            //    Console.WriteLine("Done Reading");
            //}

            #endregion

            #region Simple Object Writing / Serialization

            //Emp emp = new Emp();
            //Console.WriteLine("Enter No : ");
            //emp.No = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Enter Name : ");
            //emp.Name = Console.ReadLine();

            //Console.WriteLine("Enter Address : ");
            //emp.Address = Console.ReadLine();

            //string path = ConfigurationManager.AppSettings["logFilePath"];

            //FileStream fs = null;

            //if (File.Exists(path))
            //{
            //    fs = new FileStream(path, FileMode.Append, FileAccess.Write);
            //}
            //else
            //{
            //    fs = new FileStream(path, FileMode.Create, FileAccess.Write);
            //}

            //BinaryFormatter specialWriter = new BinaryFormatter();

            //specialWriter.Serialize(fs, emp);

            //specialWriter = null;

            //fs.Close();

            //Console.WriteLine("Done writing");
            #endregion

            #region Simple Object Reading / De-Serialization

            //string path = ConfigurationManager.AppSettings["logFilePath"];

            //FileStream fs = null;

            //if (File.Exists(path))

            //{
            //    fs = new FileStream(path, FileMode.Open, FileAccess.Read);

            //    BinaryFormatter specialReader = new BinaryFormatter();

            //    object obj = specialReader.Deserialize(fs);

            //    if (obj is Emp)
            //    {
            //        Emp emp = (Emp)obj;
            //        Console.WriteLine("Details : {0}, {1}, {2}", emp.No, emp.Name, emp.Address);
            //    }
            //    fs.Close();
            //    Console.WriteLine("Done Reading !!!!!!!!!!!!!!!!!!!!!!");
            //}
            //else
            //{
            //    Console.WriteLine("File Does Not Exists !!!!!!!!!!!!!!!!!!!!");
            //}

            #endregion

            #region Object XML Writing / XML Serialization

            //Emp emp = new Emp();

            //Console.WriteLine("Enter No : ");
            //emp.No = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Enter Name : ");
            //emp.Name = Console.ReadLine();

            //Console.WriteLine("Enter Address : ");
            //emp.Address = Console.ReadLine();

            //string path = ConfigurationManager.AppSettings["XMLLogFilePath"];

            //FileStream fs = null;

            //if (File.Exists(path))
            //{
            //    fs = new FileStream(path, FileMode.Append, FileAccess.Write);
            //}
            //else
            //{
            //    fs = new FileStream(path, FileMode.Create, FileAccess.Write);
            //}

            //XmlSerializer specialWriter = new XmlSerializer(typeof(Emp));

            //specialWriter.Serialize(fs, emp);

            //specialWriter = null;

            //fs.Close();

            //Console.WriteLine("Done writing");

            //Console.ReadLine();

            #endregion

            #region Object XMl Reading / XML Deserialization

            string path = ConfigurationManager.AppSettings["XMLLogFilePath"];

            FileStream fs = null;

            if (File.Exists(path))
            {
                fs = new FileStream(path, FileMode.Open, FileAccess.Read);

                XmlSerializer specialReader = new XmlSerializer(typeof(Emp));

                object obj = specialReader.Deserialize(fs);

                if (obj is Emp)
                {
                    Emp emp = (Emp)obj;
                    Console.WriteLine("Details : {0}, {1}, {2}", emp.No, emp.Name, emp.Address);
                }

                specialReader = null;
                fs.Close();

                Console.WriteLine("Done Reading !!");
            }
            else
            {
                Console.WriteLine("File Does Not Exists !!!");
                Console.ReadLine();
            }

            #endregion
        }
    }

    [Serializable]      // Annotation / Attribute
    public class Emp
    {

        private int _No;
        private string _Name;
        private string _Address;
        //[NonSerialized]     // just like trasient keyword ( below field will not get serilized)
        // Does't need for XMLReader
        private String _Passsword = "abc@123";
        public string Address
        {
            get { return _Address; }
            set { _Address = value; }
        }

        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        public int No
        {
            get { return _No; }
            set { _No = value; }
        }

    }

    public class Book
    {
        private int _ISBN;
        private string _Title;

        public string Title
        {
            get { return _Title; }
            set { _Title = value; }
        }


        public int ISBN
        {
            get { return _ISBN; }
            set { _ISBN = value; }
        }

    }
}
