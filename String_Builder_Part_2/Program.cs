using System;
using System.Text;


namespace String_Builder_Part_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // String Builder allows manipulation of a string
            var builder = new StringBuilder("Hello World!");
            builder.Append('-', 10);
            builder.AppendLine();
            // builder.Append("Header");
            // builder.AppendLine();
            // builder.Append('-', 10);
            // builder.Replace('-', '+');
            // Can chain events, show below from above code
            builder.Append("Header").AppendLine().Append('-', 10).Replace('-', '+');
            // removes starting at index 0 and ending at index 10
            builder.Remove(0, 10);
            builder.Insert(0, new String('-', 10));

            System.Console.WriteLine("first character: " + builder[0]); 


            Console.WriteLine(builder);
        }
    }
}
