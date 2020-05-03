using System;

namespace Conditional_Statements
{
    class Program
    {
        static void Main(string[] args)
        {
            // var hour = 10;
            // hour = 19;

            // if (hour > 0 && hour < 12) {
            //     System.Console.WriteLine("It is morning.");
            // } else if (hour >= 12 && hour < 18) {
            //     System.Console.WriteLine("It's afternoon.");
            // } else {
            //     System.Console.WriteLine("It is evening.");
            // }

            // ===== Conditional Operator =====
            // var isGoldCustomer = true;

            // // var price;
            // // if (isGoldCustomer) {
            // //     price = 19.95f;
            // // } else {
            // //     price = 29.95f;
            // // }

            // // Another way to say above is with a conditional operator:
            // var price = (isGoldCustomer) ? 19.95f : 29.95f;

            // System.Console.WriteLine(price);

            // ===== Switch/Case =====
            var season = Season.Winter;

            switch (season) {
                case Season.Autumn:
                    System.Console.WriteLine("It is Autumn!");
                    break;
                case Season.Summer:
                    System.Console.WriteLine("It is a good time to go to the beach!");
                    break;
                // case Season.Winter:
                //     System.Console.WriteLine("Get hot chocolate and chicken noodle soup.");
                //     break;
                // case Season.Spring:
                //     System.Console.WriteLine("It's time to plant flowers.");
                //     break;
                // Below is an example of what will run if two cases are true
                case Season.Winter:
                case Season.Spring:
                    System.Console.WriteLine("There is a promo this season!");
                    break;
                default:
                    System.Console.WriteLine("I'm not sure what season this is!");
                    break;
            }
        }
    }
}
