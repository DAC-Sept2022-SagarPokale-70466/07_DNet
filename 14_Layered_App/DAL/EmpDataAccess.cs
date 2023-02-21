using _14_Layered_App.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Web;

namespace _14_Layered_App.DAL
{
    class EmpDataAccess
    {
        string connectonDetails = ConfigurationManager.ConnectionStrings["myConnectionString"].ToString();


        public List<Emp> getAllEmployee()
        {

            List<Emp> emploee = new List<Emp>();

            SqlConnection connection = new SqlConnection(connectonDetails);

            connection.Open();

            SqlCommand command = new SqlCommand("select * from Test", connection);

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Emp emp = new Emp();
                emp.No = Convert.ToInt32(reader[0]);
                emp.Name = reader["Name"].ToString();
                emp.Address = reader["Address"].ToString();
                emploee.Add(emp);

            }

            reader.Close();
            connection.Close();

            return emploee;
        }

        public int AddEmployee(Emp emp)
        {
            SqlConnection connection = new SqlConnection(connectonDetails);

            connection.Open();

            string quaryFormat = "insert into Test values({0}, '{1}', '{2}')";

            string quary = string.Format(quaryFormat, emp.No, emp.Name, emp.Address);

            SqlCommand command = new SqlCommand(quary, connection);

            int affectedRow = command.ExecuteNonQuery();

            connection.Close();

            return affectedRow;
        }

        public int UpdateEmployee(Emp emp)
        {
            SqlConnection connection = new SqlConnection(connectonDetails);

            connection.Open();

            string quaryFormat = "update Test set Name='{1}', Address='{2}' where No={0}";
            string quary = string.Format(quaryFormat, emp.No, emp.Name, emp.Address);

            SqlCommand command = new SqlCommand(quary, connection);

            int affectedRow = command.ExecuteNonQuery();

            return affectedRow;
        }

        public int RemoveEmployee(int No)
        {
            SqlConnection connection = new SqlConnection(connectonDetails);

            connection.Open();

            string queryFormat = "delete from Test where No = {0}";
            string query = string.Format(queryFormat, No);

            SqlCommand command = new SqlCommand(query, connection);

            int countOfRowsAffected = command.ExecuteNonQuery();

            connection.Close();

            return countOfRowsAffected;
        }



    }
}
