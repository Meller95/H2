using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Threads
{
    class Program
    {
        static Vector sharedVector = new Vector();

        static void Main(string[] args)
        {
            int numberOfThreads = 1000;
            Thread[] threads = new Thread[numberOfThreads];

            for (int i = 0; i < numberOfThreads; i++)
            {
                int threadId = i;
                threads[i] = new Thread(() => Writer(threadId));
                threads[i].Start();
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadLine();

            foreach (var thread in threads)
            {
                thread.Join();
            }
        }

        static void Writer(int id)
        {
            while (true)
            {
                if (!sharedVector.SetAndTest(id))
                {
                    Console.WriteLine($"Inconsistency detected by writer {id}!");
                }
                Thread.Sleep(1);
            }
        }

    }
}
