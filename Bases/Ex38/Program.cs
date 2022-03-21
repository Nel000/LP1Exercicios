using System;

namespace Ex38
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaração de variáveis
            int n;
            int[] numbers;

            // Pedir ao utilizador o tamanho do array de inteiros
            Console.Write("Qual o tamanho do array?");
            n = Convert.ToInt32(Console.ReadLine());

            // Gerar números de 1 até n
            numbers = CreateNumbersToN(n);

            // Inverter os conteúdos do array
            Reverse(numbers);

            // Imprimir os conteúdos do array
            PrintNumbers(numbers);
        }

        private static int[] CreateNumbersToN(int n)
        {
            int[] numbers = new int[n];

            for (int i = 0; i < n; i++)
            {
                numbers[i] = i + 1;
            }

            return numbers;
        }

        private static void Reverse(int[] numbers)
        {
            int[] numbersReverse = new int[numbers.Length];

            for (int i = numbersReverse.Length - 1, j = 0; i >= 0; i--, j++)
            {
                numbersReverse[j] = numbers[i];
            }
            for (int i = 0; i < numbersReverse.Length; i++)
            {
                numbers[i] = numbersReverse[i];
            }
        }

        private static void PrintNumbers(int[] i)
        {
            Console.WriteLine("Array contém:");

            foreach (int number in i)
            {
                Console.WriteLine($"- {number}");
            }
        }
    }
}
