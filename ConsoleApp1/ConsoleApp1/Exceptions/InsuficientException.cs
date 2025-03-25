namespace ConsoleApp1;

public class InsuficientException : Exception
{
    public InsuficientException()
    {
    }

    public InsuficientException(string message)
        : base(message)
    {
    }

    public InsuficientException(string message, Exception inner)
        : base(message, inner)
    {
    }
}