using System;
using System.Text;

namespace StringCompression

{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Enter the string: ");
            string inputString = Console.ReadLine().Trim();

            string outputString = CompressString(inputString);
            Console.WriteLine(outputString);
        }

        static string CompressString(string s)
        {
            StringBuilder compressedSequence = new StringBuilder();
            int count = 1;

            for (int i = 1; i < s.Length; i++)
            {
                if (s[i] == s[i - 1])
                {
                    count++;
                }
                else
                {
                    compressedSequence.Append($"({count}, {s[i - 1]}) ");
                    count = 1;
                }
            }

            compressedSequence.Append($"({count}, {s[s.Length - 1]})");

            return compressedSequence.ToString();
        }
    }
}
