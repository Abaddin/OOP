using System;
using System.Threading;
using static Task2.Program;

namespace Task2
{
    class Timer
    {
        private int seconds { get; set; }

        public void Start(int sec)
        {
            Metody[] met = new Metody[] {Method1, Method2, Method3, Method4};
            Random rand = new Random();
            while (true)
            {
                Thread.Sleep(sec * 1000);
                int a = rand.Next(0, 4);
                met[a]();
            }
        }

        private static void Method1()
        {
            Random rand = new Random();
            int a = rand.Next(0, 100);
            Console.WriteLine("Method 1. Random number: " + a);
        }

        private static void Method2()
        {
            Console.WriteLine("Method 2. Time: " + DateTime.Now.TimeOfDay);
        }

        private static void Method3()
        {
            Console.WriteLine("Method 3. Day of month: " + DateTime.Now.Day);
        }
        
        private static void Method4()
        {
            Console.WriteLine("Method 4. Month: " + DateTime.Now.Month);
        }
    }
}