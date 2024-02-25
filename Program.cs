namespace MethodsandTryParsepart2Salvador
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Question 2:");
            Console.WriteLine($"1. 12 + 5 = {Math.Round(Addition(12, 5), 2)}");
            Console.WriteLine($"2. 902 / 73 = {Math.Round(Division(902, 73), 2)}");
            Console.WriteLine($"3. 658 * 23 = {Math.Round(Multiplication(658, 23), 2)}");
            Console.WriteLine($"4. 5 - 72 = {Math.Round(Subtract(5, 72), 2)}");
            Console.WriteLine($"5. 72 * 3 / 4 = {Math.Round(Division(Multiplication(72, 3), 4), 2)}");
            Console.WriteLine($"6. 17 + 42 * 76 - 19 / 12 = {Math.Round(Addition(17, Subtract(Multiplication(42, 76), Division(19, 12))), 2)}");
            Console.WriteLine($"7. 82.7 * (52.33 * 84) - 12 / 54 = {Math.Round(Subtract(Multiplication(82.7, Multiplication(52.33, 84)), Division(12, 54)), 2)}");
            Console.WriteLine($"8. Volume of right circular cone with r=5 and h=5 = {Math.Round(ConeVolume(5, 5), 2)}");

            Console.WriteLine("\nQuestion 3:");
            int userInput = GetUserInput();
            PrintStars(userInput);
        }

        static double Addition(double a, double b)
        {
            return a + b;
        }

        static double Subtract(double a, double b)
        {
            return a - b;
        }

        static double Multiplication(double a, double b)
        {
            return a * b;
        }

        static double Division(double a, double b)
        {
            return a / b;
        }

        static double ConeVolume(double r, double h)
        {
            return Math.PI * (r * r) * (h / 3);
        }

        static int GetUserInput()
        {
            int number;
            bool isValidInput;
            do
            {
                Console.WriteLine("Enter a number:");
                isValidInput = int.TryParse(Console.ReadLine(), out number);
                if (!isValidInput)
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }
            } while (!isValidInput);
            return number;
        }

        static void PrintStars(int count)
        {
            for (int i = 0; i < count; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}
