using System;

namespace WpfApp2.Exceptions;

public class BadEmailException : Exception
{
    public BadEmailException(string message) : base(message)
    {
    }
}