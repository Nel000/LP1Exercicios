using System;

namespace Ex17
{
    class Program
    {
        static void Main(string[] args)
        {
            // Stores user input
            int n;

            // Request input from user
            Console.Write("Insert a number: ");
            
            // Store user input in given variable
            n = Convert.ToInt32(Console.ReadLine());

            // If number is divisible by 3 and 5, prints 'FizzBuzz!'
            if (n % 3 == 0 && n % 5 == 0)
                Console.WriteLine("FizzBuzz!");
            // Else if number is only divisible by 3, prints 'Fizz!'
            else if (n % 3 == 0)
                Console.WriteLine("Fizz!");
            // Else if number is only divisible by 5, prints 'Buzz!'
            else if (n % 5 == 0)
                Console.WriteLine("Buzz!");
            // Else, prints number accompanied by '!'
            else
                Console.WriteLine($"{n}!");
        }
    }
}
