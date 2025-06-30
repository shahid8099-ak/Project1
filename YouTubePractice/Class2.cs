namespace YouTubePractice
{
    internal class Class2
    {
        static void Main()
        {
            // Input dividend
            Console.Write("Enter the dividend: ");
            int dividend = Convert.ToInt32(Console.ReadLine());

            // Input divisor
            Console.Write("Enter the divisor: ");
            int divisor = Convert.ToInt32(Console.ReadLine());

            // Check for division by zero
            if (divisor == 0)
            {
                Console.WriteLine("Error: Divisor cannot be zero.");
            }
            else
            {
                int quotient = dividend / divisor;
                int remainder = dividend % divisor;

                Console.WriteLine("Quotient = " + quotient);
                Console.WriteLine("Remainder = " + remainder);
            }
        }
        public static void Test()
        {
            Main();
        }
    }
}
