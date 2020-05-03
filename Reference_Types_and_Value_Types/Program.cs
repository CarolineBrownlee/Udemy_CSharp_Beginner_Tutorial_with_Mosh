using System;

namespace Reference_Types_and_Value_Types
{ 
    // class Program
    // {
    //     static void Main(string[] args)
    //     {
    //         var a = 10;
    //         var b = a;
    //         b++;

    //         Console.Write(string.Format("a: {0}, b: {1}", a, b + " // "));
    //         // output 10 11
    //         // Easier way to write that:
    //         Console.WriteLine($"{a} {b}");
    //         // output 10 11

    //         var array1 = new int[3] {
    //             1, 2, 3
    //         };
    //         var array2 = array1;

    //         array2[0] = 0;
    //         System.Console.WriteLine(string.Format("array1[0]: {0}, array2[0]: {1}", array1[0], array2[0]));
    //         // output array1[0]: 0, array2[0]: 0

            
    //     }
    // }
    public class Person {
        public int Age;
    }
      class Program
    {
        static void Main(string[] args)
        {
            var number = 1;
            Increment(number);
             System.Console.WriteLine(number);
            // output 1
            // number doesn't change because Increment is out of scope and thus does nothing

            var Caroline = new Person() {
                Age = 41
            };
            MakeOld(Caroline);
            System.Console.WriteLine(Caroline.Age);
        }

        public static void Increment(int number) {
            number += 10;
        }
        
        public static void MakeOld(Person person) {
            person.Age += 10;
        }
    }
}


