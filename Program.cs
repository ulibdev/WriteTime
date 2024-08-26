using System;
using System.Threading;

namespace WriteTime
{
    class Program

    {
        static void Main(string[] args)
        {
            string text = "Write";

            foreach (char l in text)
            {
                Console.Write(l);
                Thread.Sleep(50);
            }

            Console.WriteLine();
            Console.ReadLine(); 
        }
    }
}