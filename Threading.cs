using System;
using System.Threading;
namespace ThreadingApplication
{
    class Threading
    {
        static void Main(string[] args)
        {
            Thread th = Thread.CurrentThread;
            th.Name = "Main Start Thread";
            Console.WriteLine(th.Name);
            Console.ReadKey();
        }
    }
}
