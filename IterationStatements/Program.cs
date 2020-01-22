using System;
using System.Collections.Generic;

namespace IterationStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //DONE - Create a List called "numbers"
            var numbers = new List<int>();

            //Create a variable of type int with an initializer of 0
            var i = 0; 



            //DONE - Create a do-while loop
            {
                // Increment your variable by 1
                // Then add your variable to "numbers"
            }
            // While your variable is less than 100
            do
            {
                //execute this scope at least once
                i++; // Increment your variable by 1
                numbers.Add(i); // Then add your variable to "numbers"

            }
            while (i < 100); // While your variable i is less than 100


            // Create a while loop
            // While your variable is less than 200
            while (i < 200)
  
            {

                i++;
                numbers.Add(i);

                // Increment your variable by 1
                // Then add your variable to "numbers"
            }

            Console.WriteLine("Increase:");

            // Create a foreach loop
            // Write your variable to the console
            foreach (var num in numbers)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine("");
            Console.WriteLine("Decrease:");

           
            // DONE 
            // Create a for loop
            // in your initializer set the value of i to 199
            // in your conditional, as long as i is less than or equal to the length of "numbers"
            // and as long as i is greater than or equal to 0
            // Decrement i by 1

            for (int j = 199; j < numbers.Count && j >= 0; j--)
            {
                Console.WriteLine(numbers[j]); // Write to the console "numbers" at index i
            }

            Console.WriteLine(numbers.Count);
        }
    }
}
