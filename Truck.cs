/*******************************************************************
* Name: Pablo Pallas
* Date: 11/11/2026
* Assignment: SDC320 Performance Assessment – Inheritance
** This class represents a Truck object, which is derived from the
* Motorized class by adding a description of the load the truck can
* carry and an indicator of whether or not it is capable of towing.
* A constructor is provided to set all class and base class
* properties. ToString is overridden and calls the base class
* ToString method to get the formatted base class data, then adds
* this class's information.
*/
public class Truck : Motorized
{
    public string Load { get; set; }
    public bool Towing { get; set; }

    public Truck(int wheels, string color, bool moving, int seats,
        string engine, bool automatic, string load, bool towing)
        : base(wheels, color, moving, seats, engine, automatic)
    {
        Load = load;
        Towing = towing;
    }
    public override string ToString()
    {
        return base.ToString();
    }
}