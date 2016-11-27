using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tokoton10_06
{
    class X
    {
        internal void Say() { Console.WriteLine($"Hello! {this.GetType().Name}!"); }
    }

    class Y : X { }
    class Z : X { }

    class MyClass<T> where T :X , new()
    {
        internal static void Say()
        {
            new T().Say();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyClass<Y>.Say();
            MyClass<Z>.Say();

            Console.ReadLine();
        }
    }
}
