using System;
using static System.Console;

namespace Lab_2_New
{
    class Program
    {

        static void Main(string[] args)
        {
            WriteLine("Enter number 0, 1 or 2 for operations and number(Example: 0 7 or 1 3)\n" +
                      "0 -- sqrt(abs(x))\n" +
                      "1 -- x^3\n" +
                      "2 -- x + 3,5\n");
            int op;
            double num;

            while (true)
            {
                try
                {
                    string str = ReadLine();
                    string[] subs = str.Split(' ');
                    op = Convert.ToInt32(subs[0]);
                    num = Convert.ToDouble(subs[1]);

                    /*double result = Operation(num, op);
                    WriteLine(result);*/
                    
                    Action<double> oper;
                    oper = Boost;
                    Operation(num, oper);
                    oper = Boost1;
                    Operation(num, oper);
                    oper = Boost2;
                    Operation(num, oper);
                }
                catch (Exception ex)
                {
                    WriteLine("Input string was not in a correct format");
                    break;
                }
            }
        }

        private static void Operation(double x, Action<double> op)
        {
            if (x > 0)
                op(x);
        }
        
        /*private static double Operation(double x, int op)
        {
            if (op == 0)
            {
                return Math.Sqrt(Math.Abs(x));
            } 
            else if (op == 1)
            {
                return Math.Pow(x, 3);
            }
            else
            {
                return x + 3.5;
            }
        }*/

        private static void Boost(double x)
        {
            WriteLine(Math.Sqrt(Math.Abs(x)));
        }
        
        private static void Boost1(double x)
        {
            WriteLine(Math.Pow(x, 3));
        }
        
        private static void Boost2(double x)
        {
            WriteLine(x + 3.5);
        }

        /*private static double Root(double x)
        {
            return Math.Sqrt(Math.Abs(x));
        }

        private static double Triple(double x)
        {
            return Math.Pow(x, 3);
        }

        private static double Addiction(double x)
        {
            return x + 3.5;
        }*/
    }
}