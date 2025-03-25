namespace ConsoleApp1;

public class TemperatureException : Exception
{
    public TemperatureException()
    {
    }

    public TemperatureException(string message)
        : base(message)
    {
    }

    public TemperatureException(string message, Exception inner)
        : base(message, inner)
    {
    }
}