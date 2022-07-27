namespace Q4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a calculator in Console to perform basic arithmetic operations.
            Console.WriteLine("A console calculator to perfrom basic arithmetic operations");
            Console.WriteLine("Enter two integers first, then select operation you want to perform");
            Console.Write("Enter 1st number: ");
            string num1String = Console.ReadLine();
            Console.Write("Enter 2nd number: ");
            string num2String = Console.ReadLine();
            bool isNum1Int = int.TryParse(num1String, out int num1);
            bool isNum2Int = int.TryParse(num2String, out int num2);
            if (!isNum1Int || !isNum2Int)
            {
                Console.WriteLine("Exiting, please enter integers only");
                return;
            }
            int choiceNum = 0;
            Console.WriteLine("Choose an operation to perform on the two entered numbers");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");
            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();
            choiceNum = Convert.ToInt32(choice);
            switch (choiceNum)
            {
                case 1:
                    Console.WriteLine($"=> {num1} + {num2} = {num1 + num2}");
                    break;
                case 2:
                    Console.WriteLine($"=> {num1} - {num2} = {num1 - num2}");
                    break;
                case 3:
                    Console.WriteLine($"=> {num1} * {num2} = {num1 * num2}");
                    break;
                case 4:
                    Console.WriteLine($"=> {num1} / {num2} = {num1 / num2}");
                    break;
                default:
                    Console.WriteLine("Enter a valid choice");
                    break;
            }
        }
    }
}