using System;
using System.IO;

namespace AOCOneDayAtATime
{
    class Program
    {
        static void Main(string[] args)
        {
                //get file contents
                //putting @ in front of the quotes makes it ignore all escape characters like \
            string fileContents = File.ReadAllText(@"c:\temp\day1input.txt");

                //trim off any blank lines
            fileContents = fileContents.Trim();

                //normalize linebreaks by replacing CRLF with just LF
            fileContents = fileContents.Replace("\r\n", "\n"); 

                //break it up into an array with one entry per file line
            string[] lines = fileContents.Split('\n');

                //convert it into an array of numbers.
            int[] numbers = new int[lines.Length];
            for(int i=0;i<lines.Length;i++)
            {
                numbers[i] = int.Parse(lines[i]);
                Console.WriteLine(i + ": " + numbers[i]);
            }

            Console.WriteLine();

            //check each number against all other numbers
            for (int i = 0; i < numbers.Length; i++)
            {
                //i is the index of the first number to check

                for (int j = 1; j < numbers.Length; j++)
                {
                    //j is the index of the second number

                    if (i != j) //can't use the same number twice
                    {
                        if (numbers[i] + numbers[j] == 2020)
                        {
                            //found it!
                            Console.WriteLine($"index# {i}: {numbers[i]}");
                            Console.WriteLine($"index# {j}: {numbers[j]}");
                            Console.WriteLine($"Sum: {numbers[i] + numbers[j]}");
                            Console.WriteLine($"Product: {numbers[i] * numbers[j]}");
                            Console.ReadKey();//wait for user
                            return;
                        }
                    }
                }
            }
            //didn't find it.
            return;
        }

    }
}
