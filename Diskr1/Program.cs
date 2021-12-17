using System;

namespace Diskr1
{
    class Program
    {
        public static bool Next(ref int[] a, int n, int m)
        {
            int j = m - 1;
            while (j >= 0 && a[j] == n) j--;
            if (j < 0) return false;
            if (a[j] >= n) j--;
            a[j]++;
            if (j == m - 1) return true;
            for (int k = j + 1; k < m; k++)
                a[k] = 1;
            return true;
        }
        public static void Pr(ref int[] a, int n)
        {
            for(int i = 0; i < n; i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.WriteLine();
         
        }
        static void Main(string[] args)
        {
            int N, K;
            Console.Write("N =");
            N = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.Write("K= ");
            K = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[K];
            for(int i = 0; i < K; i++)
                a[i] = 1;
            Pr(ref a, K);
            int sch = 1;
            while(Next(ref a, N, K))
            {
                Pr(ref a, K);
                sch++;
            }
            Console.WriteLine();
            Console.WriteLine("Колличество: " + Math.Pow(N, K));
            Console.Write(sch);
        }
    }
}
