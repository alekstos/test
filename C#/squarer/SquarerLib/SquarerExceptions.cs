namespace SquarerLib;

public class SquarerException : Exception
{
    public SquarerException() { }

    public SquarerException(string message)
        : base(message)
    { }
}
