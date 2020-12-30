using System;

namespace Zalik_v5
{
    class Circle : Figure
    {
        private double R;

        public Circle(double R)
        {
            this.R = R;
        }

        public override void GetSquare()
        {
            Console.WriteLine(Math.PI * Math.Pow(R, 2));
        }

        public override void GetCircuit()
        {
            Console.WriteLine(2 * Math.PI * R);
        }
    }
}
