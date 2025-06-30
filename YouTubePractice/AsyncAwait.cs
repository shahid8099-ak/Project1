using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YouTubePractice
{
    //This concept is clear on Youtube Adil Sri's channel 
    //https://youtu.be/e6S79YqOTAc?si=1k56Z185274f_ixL
    internal class AsyncAwait
    {
        public static async void Task1()
        {
            await Task.Run(() =>
            {
                Console.WriteLine("Task1 is running ...");
                Thread.Sleep(4000);
                Console.WriteLine("Task1 is completed...");
            });
            
        }
        public static async void Task2()
        {
            await Task.Run(() =>
            {
                Console.WriteLine("Task2 is running ...");
                Thread.Sleep(2000);
                Console.WriteLine("Task2 is completed...");
            });
        }
        public static async void Task3()
        {
            await Task.Run(() =>
            {
                Console.WriteLine("Task3 is running ...");
                Thread.Sleep(5000);
                Console.WriteLine("Task3 is completed...");
            });
        }
        public static async void Task4()
        {
            await Task.Run(() =>
            {
                Console.WriteLine("Task4 is running ...");
                Thread.Sleep(1000);
                Console.WriteLine("Task4 is completed...");
            });
        }
        public static void Test()
        {
            Task1();
            Task2();
            Task3();
            Task4();
            Console.ReadLine();
        }
    }
}
