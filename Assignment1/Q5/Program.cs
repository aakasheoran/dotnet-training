using System;
using System.Collections.Generic;

namespace Q5
{
    internal class Program
    {
        static bool FiveOne()
        {
            int MAX = 256;
            Console.WriteLine("C# program to check the presence/count of characters of 1st string in the 2nd string");
            Console.Write("Enter 1st string: ");
            string? str1 = Console.ReadLine();
            Console.Write("Enter 2nd string: ");
            string? str2 = Console.ReadLine();
            int[] count1 = new int[MAX];
            int[] count2 = new int[MAX];
            for (int i = 0; i < str1.Length; i++)
                count1[str1[i]]++;
            for (int i = 0; i < str2.Length; i++)
                count2[str2[i]]++;
            Console.WriteLine("Frequency of characters for 1st string: ");
            for (int i = 0; i < str1.Length; i++)
                Console.WriteLine($"{str1[i]} -> {count1[str1[i]]}");
            Console.WriteLine("Frequency of characters for 2nd string: ");
            for (int i = 0; i < str2.Length; i++)
                Console.WriteLine($"{str2[i]} -> {count2[str2[i]]}");
            for (int i = 0; i < str1.Length; i++)
            {
                if (count1[str1[i]] >= 0)
                    if (count2[str1[i]] == 0)
                        return false;
            }
            return true;
        }
        static void FiveTwo()
        {
            int MAX = 256;
            Console.WriteLine("C# program to print the characters which is repeating maximum and minimum number of times in the input string.");
            Console.Write("Enter the string: ");
            string? str = Console.ReadLine();
            int[] count = new int[MAX];
            for (int i = 0; i < str.Length; i++)
                count[str[i]]++;
            List<int> temp = new();
            for (int i = 0; i < count.Length; i++)
                if (count[i] > 0)
                    temp.Add(count[i]);
            temp.Sort();
            if (temp[temp.Count - 1] != 1)      // maximum and minimum are same
            {
                int index = Array.IndexOf(count, temp[temp.Count - 1]);
                Console.WriteLine("Element which is repeated max number of times is: {0}", char.ConvertFromUtf32(index));
            }
            Console.WriteLine("Element(s) which is/are occurring only once are[repeated minimum number of times]: ");
            for (int i = 0; i < count.Length; i++)
            {
                if (count[i] == 1)
                    Console.Write($"{char.ConvertFromUtf32(i)} ");
            }
        }
        static void FiveThree()
        {
            Console.WriteLine("C# program to read a string and split it into words and print it.");
            Console.Write("Enter the string[space separated]: ");
            string str = Console.ReadLine();
            string[] strArr = str.Split(' ');
            Console.WriteLine("Below are the words after splitting the input string using space:");
            foreach(string item in strArr)
                Console.WriteLine(item);
        }
        static void FiveFour()
        {
            Console.WriteLine("C# program to read a string and split it into substrings of given length.");
            Console.Write("Enter the string: ");
            string str = Console.ReadLine();
            Console.Write("Enter the length for the substrings: ");
            int subSize = Convert.ToInt32(Console.ReadLine());
            for (int i=0; i<str.Length; i+=subSize)
            {
                if (subSize > str.Length - i)
                    subSize = str.Length - i;
                Console.WriteLine(str.Substring(i, subSize));
            }
        }
        static void Main(string[] args)
        {
            // 5.1. Write a C# program to accept 2 strings and check whether all characters from 1st string are present in 2nd string and to find how many times the 1st string is repeated in the 2nd string.
            //bool result = FiveOne();
            //if (result)
            //    Console.WriteLine("All characters from first string are present in second");
            //else
            //    Console.WriteLine("All of the characters from first string are not present in the second one");

            // 5.2. Write a C# program to read a string find the characters which is repeating maximum and minimum number of times.
            //FiveTwo();

            // 5.3.Write a C# program to read a string and split it into words and print it.
            //FiveThree();

            // 5.4.Write a C# program to read a string and split it into substrings of given length.
            //FiveFour();
        }
    }
}