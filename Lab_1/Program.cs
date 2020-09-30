using System;
using System.Collections.Generic;

namespace Lab_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task2
            try
            {
                TTriangle triangle = new TTriangle(10, 6, 8);
                Console.WriteLine(triangle.ToString());
                Console.WriteLine("Perimetr={0}", triangle.perimetr());
                Console.WriteLine("Square={0}", triangle.square());
                Console.WriteLine();
            }
            catch (NullReferenceException e)
            {

            }
            catch
            {
                Console.WriteLine("Triangle does not exist ");
            }
            

            //Task 1
            Console.WriteLine("Input size matrix B:");
            int size = int.Parse(Console.ReadLine());
            Random rand = new Random();
            int[,] B = new int[size, size];
            int[] P = new int[size];
            int count = 0;
            int indexs = 0;


            Console.WriteLine("Matrix B:");
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    B[i, j] = rand.Next(0, 2);
                    if (B[i, j] == 0)
                    {
                        count++;
                    }

                    Console.Write("{0}\t", B[i, j]);
                }
                P[i] = count;
                count = 0;
                Console.WriteLine();
            }


            Console.Write("The number of zeros in each line: ");
            for (int i = 0; i < size; i++)
            {
                indexs += P[i];
                Console.Write("{0} ", P[i]);
            }
            Console.WriteLine();


            int[] index = new int[indexs];
            int temp = 0;
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (B[i, j] == 0)
                    {
                        index[temp] = j;
                        temp++;
                    }
                }
            }


            int[][] Z = new int[P.Length][];
            for (int i = 0; i < P.Length; i++)
            {
                Z[i] = new int[P[i]];
            }


            temp = 0;
            Console.WriteLine("Matrix Z:");
            for (int i = 0; i < Z.Length; i++)
            {
                for (int j = 0; j < Z[i].Length; j++)
                {
                    Z[i][j] = index[temp];
                    Console.Write("{0}\t", Z[i][j]);
                    temp++;
                }
                Console.WriteLine();
            }


            for (int i = 0; i < Z.Length; i++)
            {
                Array.Reverse(Z[i]);
            }


            Console.WriteLine("Inverted matrix Z:");
            foreach (int[] u in Z)
            {
                foreach (int v in u)
                {
                    Console.Write("{0}\t", v);
                }
                Console.WriteLine();
            }
        }
    }
}
