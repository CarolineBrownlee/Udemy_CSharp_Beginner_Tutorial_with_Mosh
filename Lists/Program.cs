using System;
using System.Collections.Generic;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int> () {
                1, 2, 3, 4
            };
            numbers.Add(1);
            // To add another list, or an array to the list
            numbers.AddRange(new int[3] { 6, 7, 8 });
            foreach (var number in numbers) 
                System.Console.WriteLine(number);

            // start search from beginning of list
            var index = numbers.IndexOf(1);
                System.Console.WriteLine(index);

            // start search from end of list
            var lastIndex = numbers.LastIndexOf(1);
                System.Console.WriteLine(lastIndex);

            var count = numbers.Count;
                System.Console.WriteLine(count);
            // shortcut
            System.Console.WriteLine(numbers.Count);

            numbers.Remove(1);  
                System.Console.WriteLine("Remove 1: ");
                numbers.ForEach(Console.WriteLine);
            // to remove all 1's in list
            for (var i = 0; i < numbers.Count; i++) {
                if (numbers[i] == 1) {
                    numbers.Remove(numbers[i]);
                }
            }
            System.Console.WriteLine("Remove all 1's: ");
            numbers.ForEach(System.Console.WriteLine);

            // Clear()
            numbers.Clear();
            System.Console.WriteLine("Clear(): ");
            numbers.ForEach(System.Console.WriteLine);
        }
    }
}
