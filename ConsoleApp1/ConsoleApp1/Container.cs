namespace ConsoleApp1;

public abstract class Container(double mass, double height, double massOfContainer, double depth, double maxLoadCapacity)
{
    public string serialNumber { get; private set;  }
    public static string firstPart = "KON";
    public char letter { get; set;  }
    public static int staticNumber { get; set;  }
    public int uniqueNumber { get; set;  }
    
    public double Mass
    {
        get => mass;
        set => mass = value;
    }

    public double Height
    {
        get => height;
        set => height = value;
    }

    public double MassOfContainer
    {
        get => massOfContainer;
        set => massOfContainer = value;
    }

    public double Depth
    {
        get => depth;
        set => depth = value;
    }

    public string SerialNumber
    {
        get => serialNumber;
        set => serialNumber = value ?? throw new ArgumentNullException(nameof(value));
    }
    
    public double MaxLoadCapacity
    {
        get => maxLoadCapacity;
        set => maxLoadCapacity = value;
    }

    public void setSerialNumber()
    {
        serialNumber = firstPart+"-"+letter+"-"+uniqueNumber;
    }

    
    public abstract void Emptying();
    
    //public abstract void Loading(double mass);
    public abstract void Loading(double mass, Load load);
    
}