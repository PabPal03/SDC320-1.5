/*******************************************************************
* Name: Pablo Pallas
* Date: 11/11/2026
* Assignment: SDC320 Performance Assessment – Inheritance
** This class represents a Bicycle object, which is derived from the
* Vehicle class by adding the number of gears, the seat height, and
* the tire size. A constructor is provided to set all class and base
* class properties. ToString is overridden and calls the base class
* ToString method to get the base class data, then adds this class's
* information.
*/
public class Bicycle : Vehicle
{
    public int Gears { get; set; }
    public double SeatHeight { get; set; }
    public double TireSize { get; set; }

    public Bicycle(int wheels, string color, bool moving, int seats,
        int gears, double seatHeight, double tireSize)
        : base(wheels, color, moving, seats)
    {
        Gears = gears;
        SeatHeight = seatHeight;
        TireSize = tireSize;
    }

    public override string ToString()
    {
        return string.Format(
            "{0}\nNumber of Gears: {1}\nBicycle Height: {2}",
            base.ToString(), Gears, SeatHeight);
    }
}