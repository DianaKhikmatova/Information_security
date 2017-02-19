using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XOR
{
    class Program
    {
        public static int XOR (int a, int b)
        {
            int res = (a|b)&(~a|~b);
            return res;
        }
        static void Main(string[] args)
        {
            Console.Write("Enter a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter b: ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("XOR: " + XOR(a, b));
        }
    }
}
