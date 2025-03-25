using System.Collections;

namespace ConsoleApp1;

public class Ship(double maxVelocity, int maxNumberOfShip, double maxWeightOfLoad, List<Container> List)
{
    public List<Container> List
    {
        get => List;
        set => List = value;
    }

    public double MaxVelocity
    {
        get => maxVelocity;
        set => maxVelocity = value;
    }

    public int MaxNumberOfShip
    {
        get => maxNumberOfShip;
        set => maxNumberOfShip = value;
    }

    public double MaxWeightOfLoad
    {
        get => maxWeightOfLoad;
        set => maxWeightOfLoad = value;
    }

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