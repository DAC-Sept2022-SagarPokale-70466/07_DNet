using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace _13_DB_Programming
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionDetails = ConfigurationManager.ConnectionStrings["myConnectionString"].ToString();

            #region Select Quary

            //SqlConnection connection = new SqlConnection(connectionDetails);

            //connection.Open();

            //SqlCommand command = new SqlCommand("select * from Test", connection);  //Command is given with connection

            //SqlDataReader reader = command.ExecuteReader();     // execute select statement and return SqlDataReader

            //while (reader.Read())
            //{
            //    Console.WriteLine(reader[0].ToString() + reader[1].ToString() + reader["Name"].ToString() );
            //}

            //reader.Close();
            //connection.Close();

            //Console.ReadLine();

            #endregion

            #region Insert Quary

            //SqlConnection connection = new SqlConnection(connectionDetails);

            //connection.Open();

            //Console.WriteLine("Enter No : ");
            //int No = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Enter Name : ");
            //string name = Console.ReadLine();

            //Console.WriteLine("Enter City");
            //string address = Console.ReadLine();

            //string quaryFormat = "insert into Test values({0}, '{1}', '{2}')";
            //string quart = string.Format(quaryFormat, No, name, address);

            //SqlCommand command = new SqlCommand(quart, connection);

            //int affectedItom = command.ExecuteNonQuery();

            //Console.WriteLine(affectedItom + " Rows Afftected");

            //connection.Close();

            #endregion

            #region Update Quary

            //SqlConnection connection = new SqlConnection(connectionDetails);

            //connection.Open();

            //Console.WriteLine("Enter No You want to Update : ");
            //int no = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Enter Name : ");
            //string name = Console.ReadLine();

            //Console.WriteLine("Enter Address");
            //string add = Console.ReadLine();

            //string stringFormat = "update Test set Name='{1}', Address='{2}' where No={0}";
            //string quary = string.Format(stringFormat, no, name, add);


            ////SqlCommand command = new SqlCommand(query, connection);

            ////int countOfRowsAffected = command.ExecuteNonQuery();

            //// OR

            //int affectedRows = new SqlCommand(quary, connection).ExecuteNonQuery();

            //Console.WriteLine(affectedRows + " Row Affected !!!");

            //connection.Close();

            #endregion

            #region Delete Quary

            //SqlConnection connecton = new SqlConnection(connectionDetails);

            //connecton.Open();

            //Console.WriteLine("Enter the No You want to delete : ");
            //int No = Convert.ToInt32(Console.ReadLine());

            //string sqlFormat = "delete from Test where No={0}";
            //string quary = string.Format(sqlFormat, No);

            //SqlCommand command = new SqlCommand(quary, connecton);

            //int affectedRows = command.ExecuteNonQuery();

            //Console.WriteLine(affectedRows + "Rows Affected !!!");



            #endregion

        }
    }
}
