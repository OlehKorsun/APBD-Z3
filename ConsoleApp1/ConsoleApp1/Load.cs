namespace ConsoleApp1;

public class Load(bool isDangerous, double? temperature, string type)
{
    public bool isDangerous1
    {
        get => isDangerous;
        set => isDangerous = value;
    }

    public double? temperature
    {
        get => temperature;
        set => temperature = value;
    }

    public string type
    {
        get => type;
        set => type = value;
    }
}