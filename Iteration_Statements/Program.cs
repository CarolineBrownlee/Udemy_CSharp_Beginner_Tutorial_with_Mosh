using System;
using System.Collections.Generic;

namespace Iteration_Statements
{
    class Program
    {
        static void Main(string[] args)
        {
            // ===== FOR LOOP =====
            // display even numbers from 1 to 10
            for (var i = 1; i < 11; i++)
            {
                if (i % 2 == 0)
                {
                    System.Console.WriteLine(i);
                }
            }

            // reverse it
            for (var i = 10; i > 0; i--)
            {
                if (i % 2 == 0)
                {
                    System.Console.WriteLine(i);
                }
            }

            // ===== FOREACH LOOP =====
            List<string> family = new List<string>() {
                "Jane", "Molly"
            };
            // NSS Curriculum Syntax
            family.ForEach(family => System.Console.WriteLine(family));

            var members = new string[3] {
                "Molly", "Caroline", "Joseph"
            };

            foreach (var person in members)
            {
                System.Console.WriteLine(person);
            }

            var numbers = new int[] {
                1, 2, 3
            };

            foreach (var n in numbers)
            {
                System.Console.WriteLine(n);
            };

            // ===== WHILE LOOP =====
            while (true)
            {
                Console.Write("Enter your name: ");
                var input = Console.ReadLine();
                if (String.IsNullOrWhiteSpace(input))
                {
                    break;
                }
                else
                {
                    System.Console.WriteLine("My name is " + input + "!");
                }
                continue;
            };
        }
    }
}

// ===== for LOOPS =====
// for loops (initialization clause (counter); condition clause (will loop while condition is valid); iteration clause (increment, or decrement the couter variable))
// for (var i = o; i < 10; i++)
// {
//  // statements that will execute 
// }

// ===== foreach LOOPS =====
// foreach Loops are for lists, or arrays
// foreach (var number in numbers)
// {
// statements that will execute
// }

// ===== while LOOPS =====
// while (as long as this condition is valid the loop will execute)
// similar to for loop, but with different syntax
// while (i < 10)
// {
// statements that will execute
// ...
// i++;
// }

// ===== Do-While LOOPS =====
// loop executed at least once because condtion evaluated at the end
// don't always need a counter
// do 
// {
//     ...
//     i++;
// } while (int < 10);

// ==== BREAK AND CONTINUE =====
// BREAK TO JUMP OUT OF THE LOOP
// CONTINUE TO JUMP TO NEXT ITERATION