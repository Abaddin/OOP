using System;

namespace Lab_3
{
    class Program
    {
        static void Main(string[] args)
        {
            TCircle circle = new TCircle(5);
            TCircle circle2 = new TCircle(6);
            TSphere sphere = new TSphere(new TSphere(7));
            Console.WriteLine(circle.GetRadius);
            Console.WriteLine(circle.GetSquare());
            Console.WriteLine(circle.GetSector(40));
            Console.WriteLine(circle.GetCircuit());
            Console.WriteLine(circle + circle2);
            Console.WriteLine(circle - circle2);
            Console.WriteLine(5 * circle);
            Console.WriteLine(circle * 5);
            Console.WriteLine(circle.ToString());
            Console.WriteLine(sphere.GetRadius);
            Console.WriteLine(sphere.GetSquare());
            Console.WriteLine(sphere.ToString());

        }
    }
}
