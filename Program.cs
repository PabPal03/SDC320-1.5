/*******************************************************************
* Name: Pablo Pallas
* Date: 11/11/2026
* Assignment: SDC320 Performance Assessment – Inheritance
** Main application class.
*/
public class InheritanceTest
{
    static void Main(string[] args)
    {
        Console.WriteLine("Pablo Pallas - Week 1 Inheritance Performance Assessment");

        //Create a vehicle object & print the contents to the console
        Vehicle v = new Vehicle(3, "Red", false, 2);
        Console.WriteLine();
        Console.WriteLine(v); 

        //Create a bicycle object & print the contents to the console
        Bicycle b = new Bicycle(2, "Blue", true, 1, 12, 36, 26.5);
        Console.WriteLine();
        Console.WriteLine(b); 

        //Create a motorized object & print the contents to the console
        Motorized m = new Motorized(4, "Orange", false, 2, "3.6L V6", true);
        Console.WriteLine();
        Console.WriteLine(m);

        //Create a car object & print the contents to the console
        Car c = new Car(4, "Maroon", false, 5, "2.4L 4-CYL", false, true, "None");
        Console.WriteLine();
        Console.WriteLine(c); 

        //Create a truck object & print the contents to the console
        Truck t = new Truck(6, "Black", true, 6, "V8 Hemi", false, "2 ton", true);
        Console.WriteLine();
        Console.WriteLine(t); 

        //Print the car's properties using the get accessors
        Console.WriteLine();
        Console.WriteLine("Color: {0}", c.Color);
        Console.WriteLine("# of Seats: {0}", c.Seats);
        Console.WriteLine("Engine Size: {0}", c.Engine);
        Console.WriteLine("Automatic Transmission? {0}", c.Automatic);
        Console.WriteLine("Has Sunroof? {0}", c.SunRoof);
        Console.WriteLine("Storage: {0}", c.Storage);
        Console.WriteLine(); 
    }
}