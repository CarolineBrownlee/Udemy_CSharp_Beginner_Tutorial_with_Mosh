using System;

namespace Type_Conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            // ===== Implicit Type Conversion =====
            // When the compiler knows that the data types are compatible and no data loss will happen, the values can be converted implicitly.
            byte b = 1;
            // System.Console.WriteLine(b);
            // output 1 
            int i = b;
            // output 1
            // System.Console.WriteLine(i);

            // ===== Explicit Type Conversion =====
            // int x = 1;
            // byte y = x;
            // output ERROR can't convert an integer to a byte, won't compile
            // three bytes out of four bytes will be lost
            // if you want to tell the compiler that you're aware of the data loss, you can     cast, like this:
            int c = 1;
            byte d = (byte)c;

            // ===== Non-Compatible Types =====
            string s = "5";
            System.Console.WriteLine(s);

            int p = Convert.ToInt32(s);
            System.Console.WriteLine(p);

            // OR
            int j = int.Parse(s);
            System.Console.WriteLine(j);

            // ===== CONVERSIONS =====
            // to convert the given value to a byte
            ToByte();
            // to convert the given value to a short
            // The short type reduces the memory usage of integers. It represents a number in 2 bytes—16 bits—half the size of an int.
            ToInt16();
            // to convert the given value to an integer
            ToInt32();
            // to convert the given value to a long
            // A constant or variable defined as long can store a single 64-bit signed integer.
            ToInt64();
        }
    }
}
