namespace YouTubePractice;

public class Abstraction
{
    public static void Test()
    {
        Test1();
    }
    public static void Test1()
    {
        Calculator2 calculator2 = new Calculator2();
        Icalculator icalculator = calculator2;
        Console.WriteLine(icalculator);

    }
       
    public interface Icalculator
    {
        public int Addition(int a, int b);  
        public int Substraction (int a, int b);
        public int Multiplication (int a, int b);
        public int Division (int a, int b); 

    }
    public class Calculator2 : Icalculator
    {
        public int Addition(int a, int b)
        {
            var result = 2 + 1;
            return result;
        }

        public int Division(int a, int b)
        {
            var result = 2 / 1;
            return result;
        }

        public int Multiplication(int a, int b)
        {
            var result = 2 * 1;
            return result;
        }

        public int Substraction(int a, int b)
        {
            var result = 2 - 1;
            return result;
        }
       
    }
   

}
