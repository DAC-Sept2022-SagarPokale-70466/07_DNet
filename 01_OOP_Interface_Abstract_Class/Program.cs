using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace _01_OOP_Interface_Abstract_Class
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }
    }

    public class ReportFactory
    {
        public Report GetReport(int chioce)
        {
            if(chioce == 1)
            {
                return new Pdf();
            }
            else if(chioce == 2) 
            {
                return new Docx();
            }    
            else
            {
                return new Pptx();
            }

        }
    }


    public abstract class Report
    {
        protected abstract void Create();

        protected abstract void Parse();

        protected abstract void Validate();

        protected abstract void Save();

        public virtual 
    }

}
