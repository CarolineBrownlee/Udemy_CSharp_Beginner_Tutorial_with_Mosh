using System;
using Classes.Math;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            var Caroline = new Person();
            Caroline.FirstName = "Caroline";
            Caroline.LastName = "Brownlee";
            Caroline.Introduce();

            var calculator = new Calculator(); 
            var result = calculator.Add(1, 2); 
            Console.WriteLine(result);
        }
    }
}
