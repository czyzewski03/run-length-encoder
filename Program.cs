using System;
using System.Text;

namespace RunLengthEncoder
{
    class Program
    {
        static string encode(string text)
        {
            StringBuilder output = new StringBuilder();

            int counter = 1;
            for (int i = 0; i < text.Length; i++)
            {
                char currentChar = text[i];
                char nextChar;

                try
                {
                    nextChar = text[i + 1];
                }
                catch (IndexOutOfRangeException)
                {
                    output.Append(counter);
                    output.Append(currentChar);
                    break;
                }

                if (currentChar == nextChar)
                {
                    counter++;
                }
                else
                {
                    output.Append(counter);
                    output.Append(currentChar);
                    counter = 1;
                }
            }

            return (Convert.ToString(output));
        }
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("error: please enter some text to encode");
                return;
            }

            string encoded = encode(args[0]);
            Console.WriteLine(encoded);
        }
    }
}