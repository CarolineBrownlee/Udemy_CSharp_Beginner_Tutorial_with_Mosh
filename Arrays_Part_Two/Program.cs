using System;

namespace Arrays_Part_Two
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new[] {
                3, 7, 6, 3, 1, 4
            };
            // Length
            System.Console.WriteLine("Length: " + numbers.Length);

            // IndexOf()
            var index = Array.IndexOf(numbers, 7);
            System.Console.WriteLine("Index of 7: " + index);

            // Clear()
            Array.Clear(numbers, 0, 2);
            foreach(var numb in numbers) {
                System.Console.WriteLine(numb);
            };

            // Copy()
            var another = new int[4];

            Array.Copy(numbers, another, 4);
            System.Console.WriteLine("Effect of Copy()");
            foreach(var num in another) {
                System.Console.WriteLine(num);
            };

            // Sort()
            Array.Sort(numbers);
            System.Console.WriteLine("Effect of Sort()");
            foreach(var n in numbers) {
                System.Console.WriteLine(n);
            };

            // Reverse()
            Array.Reverse(numbers);
            System.Console.WriteLine("Effects of Reverse()");
            foreach(var n in numbers) {
                System.Console.WriteLine(n);
            };
        }
    }
}
