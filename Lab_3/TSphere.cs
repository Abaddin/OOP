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
            this.radius = radius; 
        }

        public TSphere(TSphere sphere)
        {
            this.radius = sphere.radius;
        }

        public override double GetRadius
        {
            get { return radius; }
            set
            {
                if (value <= 0) throw new ArgumentOutOfRangeException(nameof(value));
                else this.radius = value;
            }
        }

        public override double GetSquare()
        {
            return 4 * Math.PI * Math.Pow(this.radius, 2);
        }

        public double GetVolume()
        {
            return (4/3) * Math.PI * Math.Pow(this.radius,3);
        }

        public override string ToString()
        {
            return "Radius:" + radius;
        }
    }
}
