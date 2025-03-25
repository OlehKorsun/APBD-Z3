using System.ComponentModel;

namespace ConsoleApp1;

public class LiquidContainer : Container, IHazardNotifier
{
    public LiquidContainer(double mass, double height, double depth, double maxLoadCapacity) : base(mass, height, mass, depth, maxLoadCapacity)
    {
        base.letter = 'L';
        base.uniqueNumber = Container.staticNumber;
        Container.staticNumber++;
    }

    public override void Loading(double mass, Load load)
    {
        if (load.isDangerous1 && this.Mass + mass > this.MaxLoadCapacity / 2)
        {
            Console.WriteLine(Notify("It is not possible to load more than 50% of the dangerous substance", serialNumber));
            return;
        } else if (!load.isDangerous1 && this.Mass + mass > this.MaxLoadCapacity * 0.9)
        {
            Console.WriteLine(Notify("You can't load more than 90% of the substance", serialNumber));
            return;
        }
        else
        {
            this.Mass += mass;
        }
    }

    public override void Emptying()
    {
        this.Mass = 0;
    }


    public string Notify(string message, string containerNumber)
    {
        return message + " " + containerNumber;
    }
    
}