using System;
namespace firstspace
{
    class namespace_cl
    {
        public void func()
        {
            Console.WriteLine("first line namespace");
        }
    }
}

namespace secondspace
{
    class namespace_cl
    {
        public void func()
        {
            Console.WriteLine("second line namespace");
        }
    }
}

class tester
{
    static void Main(string[] args)
    {
        firstspace.namespace_cl fc = new firstspace.namespace_cl();
        secondspace.namespace_cl sc = new secondspace.namespace_cl();
        fc.func();
        sc.func();
        Console.ReadKey();
    }
}
