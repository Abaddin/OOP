using System;

namespace Lab_3
{

    class TSphere : TCircle
    {
        private double radius;

        public TSphere() : base()
        {
            this.radius = 5;
        }

        public TSphere(double radius) : base(radius)
        { 
            
        }

        public TSphere(TSphere sphere)
        {
            this.radius = sphere.radius;
        }

        

        public override double GetSquare()
        {
            return 4 * Math.PI * Math.Pow(base.Radius, 2);
        }

        public double GetVolume()
        {
            return (4/3) * Math.PI * Math.Pow(base.Radius,3);
        }

        public override string ToString()
        {
            return "" + base.Radius;
        }
    }
}
