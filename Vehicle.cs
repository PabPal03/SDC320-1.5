/*******************************************************************
* Name: Pablo Pallas
* Date: 11/11/2026
* Assignment: SDC320 Performance Assessment – Inheritance
** This class represents a Vehicle object, which is the "ultimate" base
* class in this application. All other classes are derived from this
* class at some level. This class includes Wheels, Color, Moving, and
* Seats properties. The constructor takes parameters to set all
* properties. ToString is overridden to provide the formatted data.
*/
public class Vehicle
{
    //Class properties
    public int Wheels { get; set; }
    public string Color { get; set; }
    public bool Moving { get; set; }
    public int Seats { get; set; }

    public Vehicle(int wheels, string color, bool moving, int seats)
    {
        Wheels = wheels;
        Color = color;
        Moving = moving;
        Seats = seats;
    }

        public override string ToString()
    {
        return string.Format(
            "Color: {0}\nWheel Count: {1}\nSeat Count: {2}\nCurrently Moving: {3}",
            Color, Wheels, Seats, Moving);
    }
}