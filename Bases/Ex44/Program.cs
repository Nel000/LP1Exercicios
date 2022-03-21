using System;

namespace Ex44
{
    class Program
    {
        static void Main(string[] args)
        {
            // -5000
            // Recursão vai multiplicando o inverso do número
            // -5 * 10 = -50; --50 = 50 * 10 = 500; -500 * 10 = -5000; 
            // --5000 * 10 = 50000 - Aqui, primeira verificação retorna true;
            // recursividade acaba.
            // Voltamos ao último caso onde primeiro caso não é true,
            // e esse é o número retornado.
            int n0 = Recursao(5);

            Console.WriteLine(n0);
        }

        static int Recursao(int n1) 
        {
            int n2;
            if (Math.Abs(n1) > 1000) {
                n2 = n1;
            } else {
                n2 = Recursao(-n1 * 10);
            }
            return n2;
        }
    }
}
