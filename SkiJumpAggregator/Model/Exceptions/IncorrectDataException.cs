using System;

public class IncorrectDataException : Exception
{
    public IncorrectDataException(string message)
        : base(message)
    {
    }
}