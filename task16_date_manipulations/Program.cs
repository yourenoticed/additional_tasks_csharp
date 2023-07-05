bool DateValid (int month, int day, int year)
{
    
    const int daysInOddMonths = 31;
    const int daysInEvenMonths = 30;
    int daysInFebruary = 28;
    if (year % 4 == 0)
    {
        daysInFebruary = 29;
    }
    int[] oddMonths = {0, 2, 4, 6, 7, 9, 11};
    int[] evenMonths = {1, 3, 5, 8, 10};
    if ((month > 0) && (month <= 12) && (day > 0) && (year > 0))
    {
        if ((month == 2) && (day > daysInFebruary))
        {
            return false;
        }
        else if ((oddMonths.Contains(month - 1)) && (day > daysInOddMonths))
        {
            return false;
        }
        else if ((evenMonths.Contains(month - 1)) && (day > daysInEvenMonths))
        {
            return false;
        }
        else
            return true;
    }
    else
        return false;
}

string thePreviousDay (int month, int day, int year)
{
    const int daysInOddMonths = 31;
    const int daysInEvenMonths = 30;
    string[] days = new string[31];
    string[] months = {"January", "February", "March", "April", "May", "June", "July", "August", "September",
    "October", "November", "December"};
    int[] oddMonths = {0, 2, 4, 6, 7, 9, 11};
    int[] evenMonths = {1, 3, 5, 8, 10};
    int daysInFebruary = 28;
    

    for (int i = 0; i < days.Length; i++)
    {
        days[i] = $"{i + 1}";
    } 

    if (year % 4 == 0)
    {
        daysInFebruary = 29;
    }

    if (DateValid(month, day, year))
    {
        if (day == 1)
        {
            if (month == 1)
            {
                return $"{months[months.Length - 1]} {days[daysInOddMonths - 1]} {year - 1}";
            }
            else if (month == 3)
            {
                return $"{months[month - 2]} {days[daysInFebruary - 1]} {year}";
            }
            else if (oddMonths.Contains(month - 1))
            {
                return $"{months[month - 2]} {days[daysInEvenMonths - 1]} {year}";
            }
            else
            {
                return $"{months[month - 2]} {days[daysInOddMonths - 1]} {year}";
            }
        }
        else
            return $"{months[month - 1]} {days[day - 2]} {year}";
    }
    else
        return "Date is not valid";
}

string theNextDay (int month, int day, int year)
{
    const int daysInOddMonths = 31;
    const int daysInEvenMonths = 30;
    string[] days = new string[31];
    string[] months = {"January", "February", "March", "April", "May", "June", "July", "August", "September",
    "October", "November", "December"};
    int[] oddMonths = {0, 2, 4, 6, 7, 9, 11};
    int[] evenMonths = {1, 3, 5, 8, 10};
    int daysInFebruary = 28;
    

    if (year % 4 == 0)
    {
        daysInFebruary = 29;
    }

    for (int i = 0; i < days.Length; i++)
    {
        days[i] = $"{i + 1}";
    } 

    if (DateValid(month, day, year))
    {
        if ((day == daysInEvenMonths) && (evenMonths.Contains(month - 1)))
        {
            return $"{months[month]} {days[0]} {year}";
        }
        else if ((month == 2) && (day == daysInFebruary))
        {
            return $"{months[month]} {days[0]} {year}";
        }
        else if ((day == daysInOddMonths))
        {
            if (month == 12)
            {
                return $"{months[0]} {days[0]} {year + 1}";
            }
            else
                return $"{months[month]} {days[0]} {year}";
        }
        else
        {
            return $"{months[month - 1]} {days[day]} {year}";
        }
    }
    
    else
        return "Date is not valid";
}

string DateManipulations (int month, int day, int year)
{
    if (!DateValid(month, day, year))
    {
        return "Date is not valid";
    }
    return $"The previous day is {thePreviousDay(month, day, year)}\nThe next day is {theNextDay(month, day, year)}";
}

Console.WriteLine(DateManipulations(2, 29, 2000));