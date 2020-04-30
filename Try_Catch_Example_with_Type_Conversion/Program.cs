using System;

namespace Try_Catch_Example_with_Type_Conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            // this block will be monitored
            {
                var number = "1234";
                byte b = Convert.ToByte(number);
                System.Console.WriteLine(b);
            }
            // and if an exception, or error occurs, this block will be executed, which prevents the application from crashing and instead displays a friendly message to the user
            catch (System.Exception)
            {
                System.Console.WriteLine("I'm sorry, the number can't be converted to a byte.");
            }
        }
    }
}
