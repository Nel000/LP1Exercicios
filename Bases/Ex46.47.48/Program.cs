using System;

namespace Ex46._47._48
{
    class Program
    {
        static void Main(string[] args)
        {
            // 46)
            //Console.WriteLine(MetodoRecursivo(5));
            // 5 = 0? N; 5 % 2 = 0? N; [2+] 4 = 0? N; 4 % 2 = 0? S; [3+] 3...
            // [2+] 2 % 2 = 0? S; [3+] 1 % 2 = 0? N; [2+] 0 (STOP) = [12]

            // 47)
            uint n = 5;
            Console.WriteLine($"{n}! = {Fact(n)}");
            // 5 != 120;
            // 5 > 1? S; [5*] 4 > 1? S; [4*] 3 > 1? S... 1 > 1? N (STOP)
            // Factorial de número: 5 * 4 * 3 * 2 * 1 = 120;
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

        static uint Fact(uint i) => i > 1 ? i * Fact(i - 1) : 1;
    }
}
