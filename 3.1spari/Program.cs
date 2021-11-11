using System;

namespace _3._1spari
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите n:");
                int n = int.Parse(Console.ReadLine());
                double Q = 0;
                double F = 1;
                for (int k = 1; k <= n; k++)
                {
                    for (int i = 1; i <= n - k; i++) F *= i;
                    {
                        if ( n == k) continue;
                        Q += Math.Pow(-1, k) * (k - 7) / 2 * F;

                    }                  
                }
                Console.WriteLine($"Q={Q:F2}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
