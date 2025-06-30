namespace YouTubePractice;

public class Inheritance
{
    public static void Test()
    {
        Test1();
    }
    public static void Test1()
    {
        Car car = new Car();    
        Bike bike = new Bike(); 
        Truck truck = new Truck();  

        Console.WriteLine(car.speed);   
        Console.WriteLine(car.wheel);
        car.go();
        
        Console.ReadKey();
        
    }
    public class Vehical
    {
        public int speed = 0;

        public void go()
        {
            Console.WriteLine("This vehical is moving");
        }
    }
    public class Car : Vehical 
    {
        public int wheel = 4;
    }
    public class Bike : Vehical
    {
        public int wheel = 2;
    }
    public class Truck : Vehical
    {
        public int wheel = 6;
    }
}
