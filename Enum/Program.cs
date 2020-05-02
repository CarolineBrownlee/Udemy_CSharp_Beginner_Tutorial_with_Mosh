using System;

namespace Enum
{

    public enum ShippingMethod {
        // if don't set values, the first is set to zero and the rest increment by one, but poor practice not to give them a value
        RegularAirMail = 1,
        RegisteredAirMail = 2,
        Express = 3
    }
    class Program
    {
        static void Main(string[] args)
        {
        // Enum = Set of name/value pairs
        // Enum is a place to store related constants
        // Enum is internally an integer 

        // converting Enum to an integer
            var method = ShippingMethod.Express;
            System.Console.WriteLine((int)method);
            // output 3

        // converting Enum from an integer
            var methodId = 3;
            System.Console.WriteLine((ShippingMethod)methodId);
            // output Express

        // converting method to a string
            System.Console.WriteLine(method.ToString());
            // output Express

        // convert string to Enum
            var methodName = "Express";
            var shippingMethod = (ShippingMethod)Enum.Parse(typeof(ShippingMethod), methodName);
            
        }
    }
}
