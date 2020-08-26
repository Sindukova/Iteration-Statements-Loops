using System;
using System.Collections.Generic;

namespace IterationStatements
{
    class Program
    {
        public static object Length { get; private set; }

        static void Main(string[] args)
        {
            //TODO

            //Create a List called "numbers" - DONE
            var numbers = new List<int>();


            //Create a variable of type int and initialize the variable with a value of 0
            var num = 0;



            // Create a do-while loop
            do
            {
                ++num;
                // Increment your variable by 1
                // Then add your variable to "numbers"
                numbers.Add(num);
            }
            while (num<100);
            // While your variable is less than 100



            // Create a while loop
            // While your variable is less than 200
            while(num<200)
            {
                num++;
                // Increment your variable by 1
                // Then add your variable to "numbers"
                numbers.Add(num);
            }

            Console.WriteLine("Increase:");

            // Create a foreach loop
            // Write your variable to the console
            foreach (int value in numbers)
            {
                Console.WriteLine($"Values in my list {value}");
                
            }

            Console.WriteLine("Decrease:");
            // Create a for loop
            // in your initializer set the value of i to 199
            // in your conditional, as long as i is less than or equal to the length of "numbers"
            // and as long as i is greater than or equal to 0
            // Decrement i by 1
            for (int i=199; i<=numbers.Count && i>=0; i--)
            {
                // Write to the console "numbers" at index i
                Console.WriteLine($"Values in my list {numbers[i]}");
            }
        }
    }
}
