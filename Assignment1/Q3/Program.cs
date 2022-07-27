using System;
using System.Globalization;

namespace Q3
{
    internal class Program
    {
        static void ThreeOne()
        {
            Console.WriteLine("C# program to perform addition on two floating point numbers");
            Console.Write("Enter 1st floating point number: ");
            string num1String = Console.ReadLine();
            Console.Write("Enter 2nd floating point number: ");
            string num2String = Console.ReadLine();
            // Using Parse
            //float num1 = float.Parse(num1String);
            //float num2 = float.Parse(num2String);
            //Console.WriteLine($"The sum of {num1} and {num2} is: {num1 + num2}");

            // Using TryParse
            //bool isNum1Float = float.TryParse(num1String, out float num1);
            //if (!isNum1Float)
            //    Console.WriteLine("You need to enter float, you entered: {0}", num1String);
            //bool isNum2Float = float.TryParse(num2String, out float num2);
            //if (!isNum2Float)
            //    Console.WriteLine("You need to enter float, you entered: {0}", num2String);
            //if (isNum1Float && isNum2Float)
            //{
            //    Console.WriteLine($"The sum of {num1} and {num2} is: {num1 + num2}");
            //}

            // Using convert method
            float num1 = Convert.ToSingle(num1String);
            float num2 = Convert.ToSingle(num2String);
            Console.WriteLine($"The sum of {num1} and {num2} is: {num1 + num2}");
        }
        static void ThreeTwo()
        {
            Console.WriteLine("C# program to perform addition on two integers");
            Console.Write("Enter 1st integer: ");
            string num1String = Console.ReadLine();
            Console.Write("Enter 2nd integer: ");
            string num2String = Console.ReadLine();
            // Using Parse
            //int num1 = int.Parse(num1String);
            //int num2 = int.Parse(num2String);
            //Console.WriteLine($"The sum of {num1} and {num2} is: {num1 + num2}");

            // Using TryParse
            //bool isNum1Int = int.TryParse(num1String, out int num1);
            //if (!isNum1Int)
            //    Console.WriteLine("You need to enter an integer, you entered: {0}", num1String);
            //bool isNum2Int = int.TryParse(num2String, out int num2);
            //if (!isNum2Int)
            //    Console.WriteLine("You need to enter an integer, you entered: {0}", num2String);
            //if (isNum1Int && isNum2Int)
            //{
            //    Console.WriteLine($"The sum of {num1} and {num2} is: {num1 + num2}");
            //}

            // Using convert method
            int num1 = Convert.ToInt32(num1String);
            int num2 = Convert.ToInt32(num2String);
            Console.WriteLine($"The sum of {num1} and {num2} is: {num1 + num2}");
        }
        static void ThreeThree()
        {
            Console.WriteLine("C# program to print the difference in years between two dates");
            Console.Write("Enter 1st date: ");
            string num1String = Console.ReadLine();
            Console.Write("Enter 2nd date: ");
            string num2String = Console.ReadLine();
            // Using DateTime.Parse
            //var date1 = DateTime.Parse(num1String);
            //var date2 = DateTime.Parse(num2String);
            //Console.WriteLine($"Date1 is: {date1}\nDate2 is: {date2}");
            //Console.WriteLine($"Difference between the year component of the above dates is: {date1.Year - date2.Year}");

            // Using DateTime.ParseExact
            //var date1 = DateTime.ParseExact(num1String, "dd-MM-yyyy", CultureInfo.CurrentCulture);
            //var date2 = DateTime.ParseExact(num2String, "dd-MM-yyyy", CultureInfo.CurrentCulture);
            //Console.WriteLine($"Date1 is: {date1}\nDate2 is: {date2}");
            //Console.WriteLine($"Difference between the year component of the above dates is: {date1.Year - date2.Year}");

            // Using convert method
            var date1 = Convert.ToDateTime(num1String);
            var date2 = Convert.ToDateTime(num2String);
            Console.WriteLine($"Difference between the year component of the above dates is: {date1.Year - date2.Year}");
        }
        static string ThreeFour()
        {
            Console.WriteLine("C# program to check whether the entered number is positive or negative");
            Console.Write("Enter the number: ");
            string numString = Console.ReadLine();
            bool isNum = int.TryParse(numString, out int num);
            if (!isNum)
                return $"{numString} is not an integer";
            if (num == 0)
                return $"0 is neither negative nor positive";
            if (num < 0)
                return $"{num} is a negative integer";
            return $"{num} is a positive integer";
        }
        static void Main(string[] args)
        {
            // 3.1. Write a C# program to perform addition on two floating point numbers which are taken from console. (using parse, tryparse and convert)
            //ThreeOne();

            // 3.2.Write a C# program to perform addition on two integers numbers which are taken from console. (using parse, tryparse and convert)
            //ThreeTwo();

            // 3.3. Write a C# program to print the difference in years between two dates which are taken form console. (using DateTime.Parse/DateTime.ParseExact and convert)
            //ThreeThree();

            // 3.4. Write a C# program to get a number from the console and print whether it is positive or negative. (using parse, tryparse and convert)
            //string result = ThreeFour();
            //Console.WriteLine(result);
        }
    }
}