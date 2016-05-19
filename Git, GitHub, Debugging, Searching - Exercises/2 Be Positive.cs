using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class BePositiveMain
{
    public static void Main()
    {
        int countSequences = int.Parse(Console.ReadLine());

        for (int i = 0; i < countSequences; i++)
        {
            // This overload of Split() removes all spaces and 
            // then removes all empty strings "" found between two adjacent spaces
            string[] input = Console.ReadLine().Trim().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var numbers = new List<int>();

            for (int j = 0; j < input.Length; j++)
            {
                // Index must be "j", not "i"
                int num = int.Parse(input[j]);
                numbers.Add(num);
            }

            bool found = false;

            for (int j = 0; j < numbers.Count; j++)
            {
                int currentNum = numbers[j];
                // currentNum may equal 0
                if (currentNum >= 0)
                {
                    if (found)
                    {
                        Console.Write(" ");
                    }

                    Console.Write(currentNum);

                    found = true;
                }
                // Checks if the next index (j + 1) is inside the bounds of "numbers"
                else if ((j + 1) < numbers.Count)
                {
                    currentNum += numbers[j + 1];

                    // currentNum may equal 0
                    if (currentNum >= 0)
                    {
                        if (found)
                        {
                            Console.Write(" ");
                        }

                        Console.Write(currentNum);

                        found = true;
                    }

                    // Skips the next element
                    j++;
                }
            }

            if (!found)
            {
                Console.WriteLine("(empty)");
            }
            // Prints a new line at the end of the current line
            else
            {
                Console.WriteLine();
            }
        }
    }
}