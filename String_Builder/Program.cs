using System;
using System.Collections.Generic;

namespace String_Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            var sentence = "This is going to be a really really really really really really long text.";
            var summary = StringUtility.SummerizeText(sentence);
            System.Console.WriteLine(summary);
            // const int maxLength = 5;
            // if (sentence.Length < maxLength)
            //     System.Console.WriteLine(sentence);
            // else {
            //    var words = sentence.Split(" ");
            //    var totalCharacters = 0;
            //    var summaryWords = new List<string>();

            //    foreach(var word in words)
            //    {
            //        summaryWords.Add(word);

            //        totalCharacters = word.Length + 1;
            //        if (totalCharacters > maxLength)
            //         break;
            //    }

            //    var summary = String.Join(" ", summaryWords) + "...";
            //     System.Console.WriteLine(summary);
            }
    }    
}
