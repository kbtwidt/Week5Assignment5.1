using System.Runtime.InteropServices.Marshalling;

namespace Week5Assignment5._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Part 1");
            int input;
            Console.Write("Enter a whole number to check for palindrome: ");
            input = int.Parse(Console.ReadLine());
            Console.WriteLine($"\nIs {input} a palindrome: " + IsIntPalindrome(input));

            Console.WriteLine("\nPart 2");
            Console.Write("Enter a whole number: ");
            input = int.Parse(Console.ReadLine());
            Console.WriteLine($"\nThe sum of the digits in {input} is: " + SumDigits(input));

            Console.WriteLine("Part 3");
            Console.Write("Enter a size for an integer array: ");
            int n = int.Parse(Console.ReadLine());
            int[] inputArray = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Enter an integer for array [{i + 1}]: ");
                inputArray[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"Array contains duplicates: " + ContainsDuplicates(inputArray));

        }

        static bool IsIntPalindrome(int input)
        {
            int reversed = 0;
            int holder = input;
            while (holder > 0)
            {
                reversed = (reversed * 10) + (holder % 10);
                holder = holder / 10;
            }
            return (reversed == input ? true:  false);
        }

        static int SumDigits(int input)
        {
            int sum = 0;
            int holder = input;
            while (holder > 0)
            {
                sum += (holder % 10);
                holder /= 10;
            }
            return sum;
        }

        static bool ContainsDuplicates(int[] inputArray)
        {
            HashSet<int> unique = new HashSet<int>();
            foreach (int num in inputArray)
            {
                if (!unique.Add(num))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
