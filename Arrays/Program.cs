using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // int[] numbers = new int[3];
            // also the same as above
            // 3 indicates length of array (0, 1, 2)
            var numbers = new int[3]; 
            // put value into array at index
            numbers[0] = 1;
            numbers[1] = 5;
            numbers[2] = 10;
            // print at index
            System.Console.WriteLine(numbers[0]);
            System.Console.WriteLine(numbers[1]);
            System.Console.WriteLine(numbers[2]);
            // output 1 5 10

            // array of booleans, automatically initialize as false
            var flags = new bool[3];

            flags[0] = true;
            
            System.Console.WriteLine(flags[0]);
            System.Console.WriteLine(flags[1]);
            System.Console.WriteLine(flags[2]);
            // output true false false

            var names = new string[5] {
                "Caroline", "Jane", "Annie", "Molly", "Joseph"
            };

            System.Console.WriteLine(names[0]);
            System.Console.WriteLine(names[1]);
            System.Console.WriteLine(names[2]);
            System.Console.WriteLine(names[3]);
            System.Console.WriteLine(names[4]);
            // output Caroline Jane Annie Molly Joseph
        }
    }
}
