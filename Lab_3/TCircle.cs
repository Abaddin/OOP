using System;

namespace Lab_3
{
    class TCircle
    {
        private double radius;

        public TCircle()
        {
            this.radius = 5;
        }

        public TCircle(double radius) 
        {
            this.radius = radius;
        }

        public TCircle(TCircle circle) 
        { 
            this.radius = circle.radius;
        } 

        public virtual double GetRadius
        {
            get { return radius; }
            set
            {
                if (value <= 0) throw new ArgumentOutOfRangeException(nameof(value));
                else this.radius = value;
            }
        }

        public double GetSector(double angle)
        {
            return Math.PI * Math.Pow(this.radius, 2) * (angle / 360);
        }

        public double GetCircuit()
        {
            return 2 * Math.PI * this.radius;
        }

        public virtual double GetSquare() 
        {
            return Math.PI * Math.Pow(this.radius, 2);
        }

        public static TCircle operator +(TCircle circle1, TCircle circle2) 
        {
            return new TCircle(circle1.radius + circle2.radius);
        }

        public static TCircle operator -(TCircle circle1, TCircle circle2) 
        {
            return new TCircle(Math.Abs(circle1.radius - circle2.radius));
        }

        public static TCircle operator *(TCircle circle1, double number)
        {
            return new TCircle(circle1.radius * number);
        }
            
        public static TCircle operator *(double number, TCircle circle1)
        {
            return new TCircle(circle1.radius * number);
        }
            
        public override string ToString()
        {
            return "Radius:" + radius;
        }
    }
}
