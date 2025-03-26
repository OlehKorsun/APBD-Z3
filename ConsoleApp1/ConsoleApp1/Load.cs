namespace ConsoleApp1;

public class Load
{
    public Load(bool isDangerous, double? temperature, string type)
    {
        this.temperature = temperature;
        this.type = type;
        this.isDangerous = isDangerous;
    }
    public bool isDangerous
    { get; set; }

    public double? temperature
    { get; set; }

    public string type
    { get; set; }
}