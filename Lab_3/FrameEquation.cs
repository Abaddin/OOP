using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_3
{
    public class FrameEquation
    {
        private double a, b, c, x1, x2;

        public FrameEquation()
        {
            this.a = 12;
            this.b = 10;
            this.c = 7;
        }

        public FrameEquation(double a, double b, double c) 
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public void Solution()
        {
            double d; // дискримінант

            try
            {
                d = Math.Pow(b, 2) - 4 * a * c;

                if (a == 0)
                    throw new ArithmeticException("Ділення на 0");

                if (d < 0)
                    throw new ArithmeticException("Рівняння не має коренів");

                if (d == 0) 
                {
                    x1 = x2 = (-b / 2 * a);
                    Console.WriteLine("x1 = x2 = " + x1);
                }

                if (d > 0)
                {
                    x1 = (-b - Math.Sqrt(d)) / (2 * a);
                    x2 = (-b + Math.Sqrt(d)) / (2 * a);
                    Console.WriteLine("x1 = " + x1);
                    Console.WriteLine("x2 = " + x2);
                }
            }
            catch (ArithmeticException e)
            {
                Console.WriteLine(e);
            }
        }
        

    }
}
