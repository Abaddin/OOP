using System;

namespace Task2
{
    class Program
    {
        delegate void Deledate(int sec);

        public delegate void Metody();
        static void Main(string[] args)
        {
            Console.Write("Enter number seconds: ");
            int sec = int.Parse(Console.ReadLine());
            Timer timer = new Timer();
            Deledate del = timer.Start;
            del.Invoke(sec);
        }
    }
}