using System;

namespace Ex29
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variável contendo nº de frases
            int sentenceNo;

            // Variáveis contendo número de palavras e palavra mais longa
            string longWord;
            int longWordLength;

            // Array contendo frases
            string[] sentences;

            // Array de arrays contendo frases divididas por palavras
            string[][] splitSentences;

            // Array com carateres separadores
            char[] separators = new char[] 
                { ' ', ',', '.', ':', '!', '?', '_', '\t' };

            // Pede nº de frases
            Console.Write("Número de frases: ");

            // Guarda input de utilizador em INT
            sentenceNo = Convert.ToInt32(Console.ReadLine());

            // Inicializa arrays com número de frases
            sentences = new string[sentenceNo];
            splitSentences = new string[sentenceNo][];

            // Pede cada frase
            for (int i = 0; i < sentenceNo; i++)
            {
                Console.Write($"Frase {i + 1}: ");

                // Guarda frase no array de strings
                sentences[i] = Console.ReadLine();

                // Divide frase no array de arrays
                splitSentences[i] = sentences[i].Split(separators,
                    StringSplitOptions.RemoveEmptyEntries);
            }

            // Adiciona espaço entre texto
            Console.WriteLine();

            // Loop para cada frase
            for (int i = 0; i < sentenceNo; i++)
            {
                // Reinicia variáveis
                longWord = null;
                longWordLength = 0;

                // Imprime número de frase atual
                Console.WriteLine($"Frase {i + 1}:");

                // Imprime número de palavras na frase atual
                Console.WriteLine(
                    $"Número de palavras: {splitSentences[i].Length}");

                // Loop para palavras de cada frase
                foreach (string word in splitSentences[i])
                {
                    // Caso palavra atual seja a maior até aqui registada
                    if (word.Length > longWordLength)
                    {
                        // Guarda tamanho da palavra em variável
                        longWordLength = word.Length;
                        longWord = word;
                    }
                }

                // Imprime maior palavra na frase atual
                Console.WriteLine($"    Maior palavra: \"{longWord}\"");
            }
        }
    }
}
