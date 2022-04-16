using System;

namespace WpfApp2.Exceptions;

public class BadNameException : Exception
{
    public BadNameException(String message) : base(message)
    {
    }
}