using System.Collections;

namespace ConsoleApp1;

public class Application
{
    public ArrayList ListOfShip
    {
        get => ListOfShip;
        set => ListOfShip = value;
    }

    
    

    public Container CreateGasContainer(double height, double depth, double maxLoadCapacity)
    {
        GasContainer gasContainer = new GasContainer(0, height, depth, maxLoadCapacity, 0);
        gasContainer.setSerialNumber();
        return gasContainer;
    }

    
    
    
    public Container CreateLiquidContainer(double height, double depth, double maxLoadCapacity)
    {
        LiquidContainer liquidContainer = new LiquidContainer(0, height, depth, maxLoadCapacity);
        liquidContainer.setSerialNumber();
        return liquidContainer;
    }

    
    
    
    public Container CreateRefrigeratedContainer(double height, double depth, double maxLoadCapacity, Load load)
    {
        RefrigeratedContainer refrigeratedContainer = new RefrigeratedContainer(0, height, depth, maxLoadCapacity, load);
        refrigeratedContainer.setSerialNumber();
        return refrigeratedContainer;
    }

    
    
    
    public void LoadingLoadIntoContainer(Container container, Load load, double mass)
    {
        container.Loading(mass, load);
    }

    
    
    
    
    public void LoadingContainerOntoShip(Ship ship, Container container)
    {
        if (ship.MaxNumberOfShip < ship.List.Count &&
            ship.MaxWeightOfLoad <= ship.CalculateTotalWeight() + container.Mass)
        {
            ship.List.Add(container);
        }
        else
        {
            throw new ShipOverloadException("The ship is overloaded. No new loads can be loaded.");
        }
    }
    
    
    
    
    

    public void LoadingListOfContainerOntoShip(List<Container> containers, Ship ship)
    {
        double weight = 0;
        foreach (Container container in containers)
        {
            weight += container.MassOfContainer + container.Mass;
        }

        if (ship.MaxWeightOfLoad < weight + ship.CalculateTotalWeight() &&
            ship.MaxNumberOfShip < ship.List.Count + containers.Count)
        {
            Console.WriteLine("Unable to add an entire list of containers.");
            return;
        }
        else
        {
            foreach (Container container in containers)
            {
                ship.List.Add(container);
            }
        }
    }

    
    
    
    
    public void RemoveContainerFromShip(Ship ship, Container container)
    {
        if (ship.List.Contains(container))
        {
            ship.List.Remove(container);
        }
        else
        {
            Console.WriteLine("There is no such container on the ship.");
        }
    }

    
    
    
    public void EmptyingContainer(Container container)
    {
        container.Emptying();
    }
    
    public void ReplaceContainer(){}
    
    public void MovingContainer(){}

    public string PrintContainerInformation(Container container)
    {
        return "Container " + container.serialNumber + " Height: " + container.Height + " Depth: " + container.Depth + ", Max Load Capacity: " + container.MaxLoadCapacity + " Mass of container: " + container.MassOfContainer + " Mass of load: " + container.Mass;
    }

    
    
    
    
    public string PrintShipInformation(Ship ship)
    {
        string information = "Containers:\n";
        foreach (Container container in ship.List)
        {
            information = information + container.serialNumber + "\n";
        }

        return "Ship:\n " + information;
    }
    
}