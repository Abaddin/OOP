using System;

namespace Zalik_v5_ZVP
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

        public override void GetCircuit()
        {
            
        }
    }
}
