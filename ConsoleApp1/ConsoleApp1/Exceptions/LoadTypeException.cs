namespace ConsoleApp1;

public class LoadTypeException : Exception
{
    public LoadTypeException()
    {
    }

    public LoadTypeException(string message)
        : base(message)
    {
    }

    public LoadTypeException(string message, Exception inner)
        : base(message, inner)
    {
    }
}