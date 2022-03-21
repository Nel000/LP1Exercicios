using System;

namespace Ex46
{
    class Program
    {
        static void Main(string[] args)
        {
            // 5 = 0? N; 5 % 2 = 0? N; [2+] 4 = 0? N; 4 % 2 = 0? S; [3+] 3...
            // [2+] 2 % 2 = 0? S; [3+] 1 % 2 = 0? N; [2+] 0 (STOP) = [12]
            Console.WriteLine(MetodoRecursivo(5));
        }

        static int MetodoRecursivo(int n)
        {
            if (n == 0)
                return 0;
            else if (n % 2 == 0)
                return 3 + MetodoRecursivo(n - 1);
            else
                return 2 + MetodoRecursivo(n - 1);
        }
    }
}
