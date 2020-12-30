using System;

namespace Zalik_v5
{
    class Ellipse : Figure
    {
        private double a;
        private double b;

        public Ellipse(double a, double b)
        {
            this.a = a;
            this.b = b;
        }

        public override void GetSquare() 
        {
            Console.WriteLine(Math.PI * a * b);
        }

        public override void GetCircuit(double t)
        {
            Console.WriteLine(Math.Sqrt(Math.Pow(a, 2) * Math.Pow(Math.Sin(t), 2)  + Math.Pow(b, 2) * Math.Pow(Math.Sin(t), 2)));
        }
    }
}
