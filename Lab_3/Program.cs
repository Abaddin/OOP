using System;
using System.ComponentModel.DataAnnotations;

namespace Lab_3
{
    class Program
    {
        static void Main(string[] args)
        {
            TCircle circle = new TCircle(10);
            TCircle circle2 = new TCircle(6);
            TSphere sphere = new TSphere(7);
            Console.WriteLine("Radius circle: " + circle.Radius);
            Console.WriteLine("Square circle: " + circle.GetSquare());
            Console.WriteLine("Sector circle: " + circle.GetSector(40));
            Console.WriteLine("Circuit: " + circle.GetCircuit());
            Console.Write("Addition circles: ");
            Console.WriteLine(circle + circle2);
            Console.Write("Substraction circles: ");
            Console.WriteLine(circle - circle2);
            Console.Write("Multiplying a number by a circle: ");
            Console.WriteLine(5 * circle);
            Console.Write("Multiplying a circle by a number: ");
            Console.WriteLine(circle * 6);
            Console.WriteLine("Radius sphere: " + sphere.Radius);
            Console.WriteLine("Square sphere: " + sphere.GetSquare());
            Console.WriteLine(circle.CompareTo(circle2));
        }
    }
}
