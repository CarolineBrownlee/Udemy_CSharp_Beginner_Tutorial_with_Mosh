using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstName = "Caroline";
            var lastName = "Brownlee";
            var myFullName = string.Format("My name is {0} {1}.", firstName, lastName);

            System.Console.WriteLine(myFullName);

            var names = new string[2] {
                "Caroline", "Doug"
            };

            var formattedString = string.Join(", ", names);
            System.Console.WriteLine(formattedString);

            // ===== Verbatum Strings =====
            var text = "Hi John,\nLook into the following paths:\nc:\\folder1\\folder2\nc:\\folder3\\folder4";
            System.Console.WriteLine(text);
            // Cleaner way to do that is using a verbatum string:
            var text2 = 
            @"Hi John, 
Look into the following paths:
c:\folder1\folder2\
c:\folder3\folder4]\";
            System.Console.WriteLine(text2);
        }
    }
}
