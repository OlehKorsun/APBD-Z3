namespace ConsoleApp1;

public class GasContainer : Container, IHazardNotifier
{
    public GasContainer(double mass, double height, double depth, double maxLoadCapacity, double pressure) : base(mass, height, mass, depth, maxLoadCapacity)
    {
        base.letter = 'G';
        base.uniqueNumber = Container.staticNumber;
        Container.staticNumber++;
    }

    public double Pressure
    {
        get => Pressure;
        set => Pressure = value;
    }


    public override void Emptying()
    {
        this.Mass = 0.05*this.Mass;
    }


    public String Notify(string message, string containerNumber)
    {
        return message + " " + containerNumber;
    }

    public override void Loading(double mass, Load load)
    {
        if (mass == 0.0)
        {
            throw new ArgumentException("Mass must be greater than zero.");
        }
        
        if (this.Mass + mass > MaxLoadCapacity)
        {
            throw new OverfillException("The mass must be lower than maximum weight of container.");
        }
        this.Mass += mass;
    }
    
}