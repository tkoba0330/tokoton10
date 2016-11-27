using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tokoton10_04
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = new ArrayList() { 1, 2, 3 };
            int sum = (int)array[0] + (int)array[2];
            Console.WriteLine($"添え字0と2の合計値： {sum}");

            Console.ReadLine();

        }
    }
}
