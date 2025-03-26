namespace ConsoleApp1;

public class Ship
{

    public Ship(double maxVelocity, int maxNumberOfShip, double maxWeightOfLoad, List<Container> list)
    {
        this.MaxVelocity = maxVelocity;
        this.MaxNumberOfShip = maxNumberOfShip;
        this.MaxWeightOfLoad = maxWeightOfLoad;
        this.List = list;
    }
    
    public List<Container> List { get; set; }

    public double MaxVelocity
    { get; set; }

    public int MaxNumberOfShip
    { get; set; }

    public double MaxWeightOfLoad
    { get; set; }

    public double CalculateTotalWeight()
    {
        double mass = 0;
        foreach (Container container in List)
        {
            mass += container.Mass;
        }
        return mass;
    }
    
    
}