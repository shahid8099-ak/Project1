namespace YouTubePractice
{
    internal class Calculator
    {
        static void Main()
        {
            while (true)
            {
                // Display menu
                Console.WriteLine("=========================");
                Console.WriteLine("     Calculator Menu     ");
                Console.WriteLine("=========================");
                Console.WriteLine("1. Add");
                Console.WriteLine("2. Subtract");
                Console.WriteLine("3. Multiply");
                Console.WriteLine("4. Divide");
                Console.WriteLine("5. Exit");
                Console.Write("Enter your choice (1-5): ");

                string input = Console.ReadLine();
                int choice;

                // Validate numeric input
                if (!int.TryParse(input, out choice))
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                    PauseAndClear();
                    continue;
                }

                // Switch case for user choice
                switch (choice)
                {
                    case 1:
                        Add();
                        break;
                    case 2:
                        Subtract();
                        break;
                    case 3:
                        Multiply();
                        break;
                    case 4:
                        Divide();
                        break;
                    case 5:
                        Console.WriteLine("Exiting calculator. Goodbye!");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }

                PauseAndClear();
            }
        }

        static void Add()
        {
            (double a, double b) = GetTwoNumbers();
            Console.WriteLine($"Result: {a} + {b} = {a + b}");
        }

        static void Subtract()
        {
            (double a, double b) = GetTwoNumbers();
            Console.WriteLine($"Result: {a} - {b} = {a - b}");
        }

        static void Multiply()
        {
            (double a, double b) = GetTwoNumbers();
            Console.WriteLine($"Result: {a} * {b} = {a * b}");
        }

        static void Divide()
        {
            (double a, double b) = GetTwoNumbers();
            if (b == 0)
                Console.WriteLine("Error: Cannot divide by zero.");
            else
                Console.WriteLine($"Result: {a} / {b} = {a / b}");
        }

        static (double, double) GetTwoNumbers()
        {
            Console.Write("Enter first number: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter second number: ");
            double b = Convert.ToDouble(Console.ReadLine());

            return (a, b);
        }

        static void PauseAndClear()
        {
            Console.WriteLine("\nPress Enter to continue...");
            Console.ReadLine();
            Console.Clear();
        }
        public static void Test()
        {
            Main();
        }
    }

}
