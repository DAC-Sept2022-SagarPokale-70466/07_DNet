using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_Disconnect
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Table 1 Created in memory - Hardcoded-Data

            DataTable table = new DataTable("Emp");

            //Creating a new Column
            DataColumn column1 = new DataColumn("No", typeof(int));
            DataColumn column2 = new DataColumn("Name", typeof(string));
            DataColumn column3 = new DataColumn("Address", typeof(string));

            // Adding column to the table

            table.Columns.Add(column1);
            table.Columns.Add(column2);
            table.Columns.Add(column3);

            table.PrimaryKey = new DataColumn[] { column1 };    // adding column1 as primary key

            DataRow row1 = table.NewRow();

            row1[0] = 11;
            row1[1] = "Sagar";
            row1[2] = "Pune";

            table.Rows.Add(row1);

            DataRow row2 = table.NewRow();

            row2[0] = 21;
            row2[1] = "ABC";
            row2[2] = "Pune";

            table.Rows.Add(row2);

            DataRow row3 = table.NewRow();

            row3[0] = 31;
            row3[1] = "Pawar";
            row3[2] = "Pune";

            table.Rows.Add(row3);

            #endregion

        }
    }
}
