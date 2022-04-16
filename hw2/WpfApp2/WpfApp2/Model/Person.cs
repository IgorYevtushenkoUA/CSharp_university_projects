using System;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;
using WpfApp2.Exceptions;

namespace WpfApp2.Model;

public class Person
{
    private static readonly string[] ChineseZodiacs =
        {"Monkey", "Rooster", "Dog", "Pig", "Rat", "Ox", "Tiger", "Rabbit", "Dragon", "Snake", "Horse", "Goat"};

    private static readonly string[] Months =
    {
        "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November",
        "December"
    };

    private string _name;
    private string _surname;
    private DateTime _birthDate;
    private string _email;
    private readonly bool _isAdult;
    private readonly string _sunSign;
    private readonly string _chineseSign;
    private readonly bool _isBirthday;

    private string namePattern = "^[a-zA-Z]+(([- ][a-zA-Z ])?[a-zA-Z]*)*$";
    private string Name
    {
        get => _name;
        set
        {
            if (Regex.IsMatch(value, namePattern))
            {
                _name = value;
            }
            else
            {
                throw new BadNameException("Incorrect name");
            }
        }
    }

    private string Surname
    {
        get => _surname;
        set
        {
            if (Regex.IsMatch(value, namePattern))
            {
                _surname = value;
            }
            else
            {
                throw new BadNameException("Incorrect surname");
            }
        }
    }

    private DateTime BirthDate
    {
        get => _birthDate;
        set => _birthDate = value;
    }

    private string Email
    {
        get => _email;
        set
        {
            if (new EmailAddressAttribute().IsValid(value))
            {
                _email = value;
            }
            else
            {
                throw new BadEmailException("Incorrect email");
            }
        }
    }

    // equals to  public string SunSign { get { return _sunSign; } }
    internal string SunSign => _sunSign;

    internal string ChineseSign => _chineseSign;

    internal bool IsAdult => _isAdult;

    internal bool IsBirthday => _isBirthday;

    internal Person(string name, string surname, DateTime birthDate, string email)
    {
        Name = name;
        Surname = surname;
        _birthDate = birthDate;
        Email = email;
        
        int age = CalculateAge();
        _isAdult = age >= 18;
        _isBirthday = ((DateTime.Today.Day == BirthDate.Day) && (DateTime.Today.Month == BirthDate.Month));
        _sunSign = CalculateWesternZodiac();
        _chineseSign = CalculateChineseZodiac();
    }

    private string CalculateChineseZodiac()
    {
        var year = BirthDate.Year;
        var res = ChineseZodiacs[year % 12];
        return res;
    }

    private string CalculateWesternZodiac()
    {
        // var month = BirthDate.Month - 1;
        var month = BirthDate.Month;
        var day = BirthDate.Day;
        var astro = "";
        if (Months[month].Equals("December"))
        {
            if (day < 22)
                astro = "Sagittarius";
            else
                astro = "Capricorn";
        }

        else if (Months[month].Equals("January"))
        {
            if (day < 20)
                astro = "Capricorn";
            else
                astro = "Aquarius";
        }

        else if (Months[month].Equals("February"))
        {
            if (day < 19)
                astro = "Aquarius";
            else
                astro = "Pisces";
        }

        else if (Months[month].Equals("March"))
        {
            if (day < 21)
                astro = "Pisces";
            else
                astro = "Aries";
        }
        else if (Months[month].Equals("April"))
        {
            if (day < 20)
                astro = "Aries";
            else
                astro = "Taurus";
        }

        else if (Months[month].Equals("May"))
        {
            if (day < 21)
                astro = "Taurus";
            else
                astro = "Gemini";
        }

        else if (Months[month].Equals("June"))
        {
            if (day < 21)
                astro = "Gemini";
            else
                astro = "Cancer";
        }

        else if (Months[month].Equals("July"))
        {
            if (day < 23)
                astro = "Cancer";
            else
                astro = "leo";
        }

        else if (Months[month].Equals("August"))
        {
            if (day < 23)
                astro = "Leo";
            else
                astro = "Virgo";
        }

        else if (Months[month].Equals("September"))
        {
            if (day < 23)
                astro = "Virgo";
            else
                astro = "libra";
        }

        else if (Months[month].Equals("October"))
        {
            if (day < 23)
                astro = "Libra";
            else
                astro = "Scorpio";
        }

        else if (Months[month].Equals("November"))
        {
            if (day < 22)
                astro = "Scorpio";
            else
                astro = "Sagittarius";
        }

        return astro;
    }

    private int CalculateAge()
    {
        var currentDate = DateTime.Today;
        var age = currentDate.Year - BirthDate.Year;
        if ((BirthDate.Month == currentDate.Month && BirthDate.Day > currentDate.Day)
            || BirthDate.Month > currentDate.Month)
        {
            age--;
        }

        if (age >= 0 && age <= 135)
        {
            return age;
        }
        else
        {
            throw new ArgumentException("Incorrect Age");
        }
    }

    internal Person(string name, string surname, string email) :
        this(name, surname, DateTime.Today, email)
    {
    }

    internal Person(string name, string surname, DateTime birthDate) :
        this(name, surname, birthDate, "default@gmail.com")

    {
    }
}