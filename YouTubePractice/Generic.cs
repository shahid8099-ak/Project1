using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YouTubePractice;

internal class Generic
{
   internal static void Main(string[] args)
    {
        int[] ints = {1, 2, 3, 4, 5,};
        string[] strings = { "1", "2", "3", "4", "5" };
        double[] doubles = {1.0, 2.0, 3.0, 4.0, 5.0};

        displayElement(ints);
        displayElement(strings);
        displayElement(doubles);

    }

    internal static void Main()
    {
        throw new NotImplementedException();
    }

    static void displayElement(int[] array)
    {
        foreach (int item in array)
        {
            Console.WriteLine(item + " ");
        }
    }
    static void displayElement(string[] array)
    {
        foreach (string item in array)
        {
            Console.WriteLine(item + " ");
        }
    }
    static void displayElement(double[] array)
    {
        foreach (double item in array)
        {
            Console.WriteLine(item + " ");
        }
    }

    
}