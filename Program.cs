using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iz_bukv_v_cifrovoi_kod
{
    class Program
    {
        static void Main(string[] args)
        {
            char ch = (char)Console.Read();
            char num1 =(char)(ch + 1);
            char num2 = (char)(ch + 2);
            char num3 = (char)(ch + 3);
            char num4 = (char)(ch + 4);
            char num5 = (char)(ch + 5);
            Console.WriteLine("{0} {1} {2} {3} {4} {5}", ch, num1, num2, num3, num4, num5);
        }
    }
}
