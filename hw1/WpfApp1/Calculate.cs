using System;
using System.Windows;

namespace WpfApp1;

public class Calculate
{
    private static readonly string[] ChineseZodiacs =
    {
        "Monkey", "Rooster", "Dog", "Pig", "Rat", "Ox", "Tiger", "Rabbit", "Dragon", "Snake", "Horse", "Goat"
    };

    private static readonly string[] Months =
    {
        "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November",
        "December"
    };


    public void CalculateBirthday(DateTime date, DateTime currentDate)
    {
        if (date.Month == currentDate.Month && date.Day == currentDate.Day)
        {
            MessageBox.Show("Happy Birthday");
        }
    }

    public String CalculateAge(DateTime date, DateTime currentDate)
    {
        var age = currentDate.Year - date.Year;
        if ((date.Month == currentDate.Month && date.Day > currentDate.Day)
            || date.Month > currentDate.Month)
        {
            age--;
        }

        if (age >= 0 && age <= 135)
        {
            return "Year: " + age;
        }
        else
        {
            throw new ArgumentException("Incorrect Age");
        }
    }

    public string CalculateWesternZodiac(DateTime date)
    {
        var month = date.Month - 1;
        var day = date.Day;
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

        return "WesternZodiacs: " + astro;
    }

    public string CalculateChineseZodiac(DateTime date)
    {
        var year = date.Year;
        var res = ChineseZodiacs[year % 12];
        return "ChineseZodiac: " + res;
    }
}