using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Enter the first value: ");

            float v1 = float.Parse(Console.ReadLine()); 
            

            Console.WriteLine("Second value: ");
            float v2 = float.Parse(Console.ReadLine());


            float result = v1 + v2;
            Console.WriteLine($"Result of the operation: {result}"); 

        }
    }
}
