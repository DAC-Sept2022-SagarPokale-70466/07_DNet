using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL_File
{
    [Serializable]
    public class Arithmatic
    {

        public int Add(int x, int y)
        {
            return x + y;
        }

        public int Subtract(int x, int y)
        {
            return x - y;
        }

        public int Divide(int x, int y)
        {
            return x / y;
        }

        public int Multiplication(int x, int y)
        {
            return (x * y);
        }
    }
}
