using System;

namespace Working_with_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            // TRIM gets rid of whitespace at the end of the string
            var fullName = "Caroline Brownlee ";
            // {0} is the placeholder for the name parameter
            System.Console.WriteLine("Trim: {0}", fullName.Trim());
            // TO UPPER AND TO LOWER
            System.Console.WriteLine("To Upper: {0}", fullName.ToUpper());
            // CHAINING EVENTS
            System.Console.WriteLine("Trim and To Lower: {0}", fullName.ToLower().Trim() + "!");

            // SPLIT THE STRING at the whitespace between first and last name by finding the index of whitespace between them
            var index = fullName.IndexOf(' ');
            // takes two parameters, the 0 is the index of the first letter of the first name and index is the whitespace
            var firstName = fullName.Substring(0, index);
            // starts at the index of whitespace and carries to the end of the string
            var lastName = fullName.Substring(index + 1);
            System.Console.WriteLine("First Name: " + firstName);
            System.Console.WriteLine("Last Name: " + lastName);

            // SPLIT METHOD
            // splits at the whitespace
            var names = fullName.Split(' ');
            // takes the index of the two names 
            System.Console.WriteLine("First Name: " + names[0]);
            System.Console.WriteLine("Last Name: " + names[1]);

            var wholeName = "Caroline Marie Brownlee";
            var wholeNameSplit = wholeName.Split(' ');
            System.Console.WriteLine("First Name: " + wholeNameSplit[0]);
            System.Console.WriteLine("Middle Name: " + wholeNameSplit[1]);
            System.Console.WriteLine("Last Name: " + wholeNameSplit[2]);

            // REPLACE
            var fullName3 = fullName.Replace("Caroline", "Joseph");
            System.Console.WriteLine(fullName3);
            fullName.Replace("Caroline", "Joseph");
            var fullName2 = fullName.Replace('C', 'c');
            System.Console.WriteLine(fullName2);
            
            // strings are immutable, so original string never changes
            System.Console.WriteLine(fullName + "!");
            // output Caroline Brownlee !

            // checking to see if the value of a field is null
            // validation
            if (String.IsNullOrWhiteSpace(" "))
                System.Console.WriteLine("Invalid");

            // convert 
            var str = "25";
            var age = Convert.ToInt32(str);
            System.Console.WriteLine(age);

            // converts price to currency with dollar sign
            float price = 29.95f;
            System.Console.WriteLine(price.ToString("C"));
            // output $29.95

            // rounds up to the dollar 
            System.Console.WriteLine(price.ToString("C0"));
            // output $30
        }
    }
}
