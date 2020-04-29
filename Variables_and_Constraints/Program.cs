using System;

namespace Variables_and_Constraints
{
    class Program
    {
        static void Main(string[] args)
        {
            float totalPrice = 20.50f;
            var character = 'A';
            string sentence = "This is a sentence.";
            bool isLearning = true;
            Console.WriteLine(totalPrice);
            Console.WriteLine(character);
            Console.WriteLine(sentence);
            System.Console.WriteLine(isLearning);

            // ===== Format String =====
            System.Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue);
            // output 0 225
            System.Console.WriteLine("{0} {1}", float.MinValue, float.MaxValue);
            // output -3.4028235E+38 3.4028235E+38

            // ===== Constant =====
            const float Pi = 3.14f;
            System.Console.WriteLine(Pi);
            // output 3.14
        }
    }
}
