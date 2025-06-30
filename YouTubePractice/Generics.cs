using System;


namespace YouTubePractice;

//This concept is also clear from youtube Bro code 
//https://youtu.be/aNTDJ9bnRU4?si=J9O0QH6ew89wgPAL
internal class Generics
{
    public static void Arrays()
    {
        int[] ints = { 1, 2, 3, 4, 5, };
        string[] strings = { "1", "2", "3", "4", "5" };
        double[] doubles = { 1.0, 2.0, 3.0, 4.0, 5.0 };

        displayElement(ints);
        displayElement(strings);
        displayElement(doubles);

    }

    static void displayElement<T>(T[] array)
    {
        foreach (T item in array)
        {
            Console.WriteLine(item + " ");
        }
    }


    //static void displayElement(string[] array)
    //{
    //    foreach (string item in array)
    //    {
    //        Console.WriteLine(item + " ");
    //    }
    //}
    //static void displayElement(double[] array)
    //{
    //    foreach (double item in array)
    //    {
    //        Console.WriteLine(item + " ");
    //    }
    //}
    public static void Test()
    {
        Arrays();
    }
}
