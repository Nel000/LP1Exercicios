using System;

namespace Ex32._33._34
{
    class Program
    {
        static void Main(string[] args)
        {
            // 32)
            /*byte b = byte.MaxValue - 1;

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Iteração {i}: {(byte) (++b - 1)}");
            }*/
            // byte = 8 bits : MaxValue = 255 - 1 = 254
            // Iteração 0: 254
            // Iteração 1: 255
            // Iteração 2: 0
            // Iteração 3: 1
            // Iteração 4: 2
            // Incrementação como prefixo aplica-se imediatamente na operação
            // Variável é permanentemente incrementada

            // 33)
            /*int[] someInts = { 11, 8, 6, 3, 9, 104 };

            foreach (int v in someInts)
            {
                if (v % 2 == 0)
                {
                    Console.WriteLine("{0,3}", v);
                }
            }*/
            //   8
            //   6
            // 104
            // Imprime múltiplos de 2
            // Adiciona 3 espaços à esquerda

            // 34)
            /*int n = 0;

            string[] frases = {
                "Curta",
                "Uma frase longa",
                "Small",
                "Very large sentence",
                "Petit",
                "How many words do I have?"
            };

            foreach (string s in frases)
            {
                if (s.Length > 6)
                {
                    n++;
                }
            }

            Console.WriteLine(n);*/
            // 3
            // Length corresponde a quantidade de caracteres
        }
    }
}
