using System;
using System.Threading;

namespace MultiThread
{
    class ThreadApp
    {
        public static void CallToChildThread()
        {
            try
            {
                Console.WriteLine("Child thread starts");
                // Do some work like counting to 
                for(int counter=0; counter <=10; counter++)
                {
                    Thread.Sleep(500);
                    Console.WriteLine(counter);
                }
                Console.WriteLine("Child Thread Completed");
            }
            catch (ThreadAbortException e)
            {
                Console.WriteLine("Thread Aborted");
            }
            finally
            {
                Console.WriteLine("Could not catch thread");
            }
        }
        static void Main(string[] args)
        {
            ThreadStart childref = new ThreadStart(CallToChildThread);
            Console.WriteLine("Creating the child thread hold on");

            Thread child = new Thread(childref);
            child.Start();
            Thread.Sleep(10000);

            Console.WriteLine("Aborting the child thread");
            child.Abort();
            Console.ReadKey();
        }
    }
}
