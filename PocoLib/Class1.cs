using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using MyAnnotation;

namespace PocoLib
{
    [Table(Name = "Employee")]
    class Emp
    {
        private int _No;
        private string _Name;
        private string _Address;

        [Column(Name = "Address", Type = "varchar(50)")]
        public string Address
        {
            get { return _Address; }
            set { _Address = value; }
        }


        [Column(Name = "Name", Type = "varchar(50)")]
        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }


        [Column(Name = "id", Type = "int")]
        public int No
        {
            get { return _No; }
            set { _No = value; }
        }


    }


    [Table(Name = "Customer")]
    public class Customer
    {
        private int _ID;

        [Column(Name = "CID", Type = "int")]
        public int ID
        {
            get { return _ID; }
            set { _ID = value; }
        }
        private string _CName;

        [Column(Name = "CName", Type = "varchar(30)")]
        public string CName
        {
            get { return _CName; }
            set { _CName = value; }
        }


    }
}
