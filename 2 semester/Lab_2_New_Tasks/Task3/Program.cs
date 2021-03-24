using System;

namespace Task3
{
    class Program
    {
        public delegate void DivideOn(int[] mas);

        static void Main(string[] args)
        {
            int[] mas = {12, -7, 3, 144, 35, 18, -121};
            DivideOn d3 = new DivideOn(IfDividedOn3);
            DivideOn d7 = new DivideOn(IfDividedOn7);
            d3(mas);
            d7.Invoke(mas);
        }

        public static void IfDividedOn3(int[] mas)
        {
            Console.WriteLine("Divisible by 3: ");
            foreach (int a in mas)
            {
                if (a % 3 == 0)
                {
                    Console.Write(a + " ");
                }
            }

            Console.WriteLine();
        }

        public static void IfDividedOn7(int[] mas)
        {
            Console.WriteLine("Divisible by 7: ");
            foreach (int a in mas)
            {
                if (a % 7 == 0)
                {
                    Console.Write(a + " ");
                }
            }

            Console.WriteLine();
        }
    }
}