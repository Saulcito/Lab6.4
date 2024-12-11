using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6._4
{
    internal class Program
    {
        static double Power(double M, int N) 
        {
            if (N == 0)
            {
                return 1;
            }
            else if (N > 0)
            {
                return M * Power(M, N - 1);
            }
            else 
            {
                return 1 / Power(M, -N);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the base numer (M):");
            double M = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the exponent number (N):");
            int N = int.Parse(Console.ReadLine());

            double result = Power(M, N);

            Console.WriteLine($"\n {M} raised to the power of {N} is: {result}");

            Console.ReadLine();
        }
    }
}
