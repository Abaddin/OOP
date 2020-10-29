using System;

namespace Lab_3
{
    public class TCircle
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

        public double Radius
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

        public static bool operator >(TCircle circle1, TCircle circle2) 
        {
            return circle1.Radius > circle2.Radius;
        }

        public static bool operator <(TCircle circle1, TCircle circle2) 
        {
            return circle1.Radius < circle2.Radius;
        }

        public static bool operator ==(TCircle circle1, TCircle circle2) 
        {
            return circle1.Radius == circle2.Radius;
        }

        public static bool operator !=(TCircle circle1, TCircle circle2) 
        {
            return circle1.Radius != circle2.Radius;
        }

       public override bool Equals(Object obj)
       {
            if ((obj == null) || this.GetType() != obj.GetType()) return false;
            TCircle temp = (TCircle)obj;
            return Radius == temp.Radius;
       }

        public override int GetHashCode()
        {
            return Radius.GetHashCode();
        }

        public override string ToString()
        {
            return "" + radius;
        }
    }
}
