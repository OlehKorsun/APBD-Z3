namespace ConsoleApp1;

public class RefrigeratedContainer : Container
{
    public RefrigeratedContainer(double mass, double height, double depth, double maxLoadCapacity, Load load) : base(mass, height, mass, depth, maxLoadCapacity)
    {
        letter = 'C';
        uniqueNumber = staticNumber;
        staticNumber++;
        Load = load;
    }

    public Load Load { get; set; }
    
    public override void Emptying()
    {
        this.Mass = 0;
    }
    
    public override void Loading(double mass, Load load)
    {
        if (mass == 0)
        {
            throw new ArgumentException("Mass must be greater than zero.");
        }
        
        if (Mass + mass > MaxLoadCapacity)
        {
            throw new OverfillException("The mass must be lower than maximum weight of container.");
        }

        if (!Load.type.Equals(load.type))
        {
            throw new LoadTypeException("The load type of container must be equal to load type.");
        }

        if (Load.temperature < load.temperature)
        {
            throw new TemperatureException("The temperature of load must be greater or equal to container temperature.");
        }
        
        Mass += mass;
    }
    
}