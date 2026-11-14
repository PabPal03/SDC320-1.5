/*******************************************************************
* Name: Pablo Pallas
* Date: 11/11/2026
* Assignment: SDC320 Performance Assessment – Inheritance
** This class represents a Motorized object, which is derived from the
* Vehicle class by adding the engine description and an indicator of
* whether or not the transmission is automatic. A constructor is
* provided to set all class and base class properties. ToString is
* overridden and does NOT call the base class ToString method; rather
* it uses the base class property accessors directly to output the
* base class data.
*/
public class Motorized : Vehicle
{
    public string Engine { get; set; }
    public bool Automatic { get; set; }

    public Motorized(int wheels, string color, bool moving, int seats,
        string engine, bool automatic) : base(wheels, color, moving, seats)
    {
        Engine = engine;
        Automatic = automatic;
    }

    public override string ToString()
    {
        return string.Format(
            "Color: {0}\nWheel Count: {1}\nSeat Count: {2}\nCurrently Moving: {3}\n"
                + "Engine: {4}\nAutomatic Transmission? {5}",
            Color,     
            Wheels,
            Seats,      
            Moving,     
            Engine,     
            Automatic); 
    }
}