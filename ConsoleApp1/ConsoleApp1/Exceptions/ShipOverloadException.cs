namespace ConsoleApp1;

public class ShipOverloadException : Exception
{
    public ShipOverloadException()
    {
    }

    public ShipOverloadException(string message)
        : base(message)
    {
    }

    public ShipOverloadException(string message, Exception inner)
        : base(message, inner)
    {
    }
}