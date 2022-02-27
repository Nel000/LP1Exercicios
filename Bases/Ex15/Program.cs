using System;

namespace Ex15
{
    class Program
    {
        static void Main(string[] args)
        {
            // The Length property provides the number of array elements
            System.Console.WriteLine("parameter count = {0}", args.Length);

            // FOR loop goes through each arg
            for (int i = 0; i < args.Length; i++)
            {
                // Print each arg in order
                System.Console.WriteLine("Arg[{0}] = [{1}]", i, args[i]);
            }
        }
    }
}
