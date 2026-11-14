/*******************************************************************
* Name: Pablo Pallas
* Date: 11/11/2026
* Assignment: SDC320 Performance Assessment – Inheritance
** This class represents a Car object, which is derived from the
* Motorized class by adding an indicator of whether or not the car
* has a sunroof and a description of its storage area. A constructor
* is provided to set all class and base class properties. ToString is
* overridden and calls the base class ToString method to get the
* formatted base class data, then adds this class's information.
*/
public class Car : Motorized
{
    public bool SunRoof { get; set; }
    public string Storage { get; set; }

    public Car(int wheels, string color, bool moving, int seats,
        string engine, bool automatic, bool sunRoof, string storage)
        : base(wheels, color, moving, seats, engine, automatic)
    {
        SunRoof = sunRoof;
        Storage = storage;
    }

    public override string ToString()
    {
        return string.Format("{0}\nStorage: {1}\nHas Sunroof? {2}",
            base.ToString(), Storage, SunRoof);
    }
}