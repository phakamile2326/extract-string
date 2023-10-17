using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace extract_string
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string: ");
            string inputString = Console.ReadLine();
            string extractedSubstring = ExtractSubstringBetweenHashSigns(inputString);

            if(string.IsNullOrEmpty(extractedSubstring) )
            {
                Console.WriteLine("no substring found between '##' .");
            }
            else
            {
                Console.WriteLine("Extracted Substring " +  extractedSubstring);

            }
            Console.ReadLine();
        }
        static string ExtractSubstringBetweenHashSigns(string input)
        {
            int startIndex = input.IndexOf("##");
            int endIndex = input.IndexOf("##" , startIndex +2);

            if (startIndex >=0 && endIndex > startIndex) 
            {
                startIndex += 2;
                return input.Substring(startIndex, endIndex - startIndex);
            }
            return string.Empty;
        }
    }
}
