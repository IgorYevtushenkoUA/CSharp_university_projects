using System;

namespace WpfApp2.Exceptions;

public class BadAgeException : Exception
{
    public BadAgeException(string message) : base(message)
    {
    }
}