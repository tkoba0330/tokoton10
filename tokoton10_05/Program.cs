using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tokoton10_05
{
    class MyClass<T>
    {
        internal static T GetSomeValue()
        {
            return default(T);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MyClass<int>.GetSomeValue());
            Console.WriteLine(MyClass<Program>.GetSomeValue() == null);

            Console.ReadLine();
        }
    }
}
