using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tokoton10_02
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 1u;

            var b = a;
            Console.WriteLine(b.GetType().FullName);

            Console.ReadLine();
        }
    }
}
