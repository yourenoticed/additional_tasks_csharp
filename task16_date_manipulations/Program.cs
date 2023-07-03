bool DateValid (int month, int day)
{
    const int daysInFebruary = 28;
    const int daysInOddMonths = 31;
    const int daysInEvenMonths = 30;
    const int[] oddMonths = {0, 2, 4, 6, 7, 9, 11};
    const int[] evenMonths = {1, 3, 5, 8, 10};
    if ((month > 0) && (month <= 12) && (day > 0))
    {
        if ((month == 2) && (day <= daysInFebruary))
        {
            return true;
        }
        else if ((oddMonths.Contains(month)) && (day <= daysInOddMonths))
        {
            return true;
        }
        else if ((evenMonths.Contains(month)) && (day <= daysInEvenMonths))
        {
            return true;
        }
        else return false;
    }
    else return false;
}

string thePreviousDay (int month, int day)
{
    string[] days = new string[31];
    string[] months = {"January", "February", "March", "April", "May", "June", "July", "August", "September",
    "October", "November", "December"};
    int[] oddMonths = {0, 2, 4, 6, 7, 9, 11};
    int[] evenMonths = {1, 3, 5, 8, 10};
    const int daysInFebruary = 28;
    const int daysInOddMonths = 31;
    const int daysInEvenMonths = 30;

    for (int i = 0; i < days.Length; i++)
    {
        days[i] = $"{i + 1}";
    } 

    if (DateValid(month, day))
    {
        if (day == 1)
        {
            if (month == 1)
            {
                return $"{months[months.Size - 1]} {days[daysInOddMonths - 1]}";
            }
            else if (month == 3)
            {
                return $"{months[month - 2]} {days[daysInFebruary - 1]}";
            }
            else if (oddMonths.Contains(month - 1))
            {
                return $"{months[month - 2]} {days[daysInEvenMonths - 1]}";
            }
            else
            {
                return $"{months[month - 2] {days[daysInOddMonths - 1]}}";
            }
        }
        else
            return $"{months[month - 1] {days[day - 1]}}";
    }
    else
        return "Date is not valid";
}

string theNextDay (int month, int day)


{
    string[] days = new string[31];
    const string[] months = {"January", "February", "March", "April", "May", "June", "July", "August", "September",
    "October", "November", "December"};
    const int[] oddMonths = {0, 2, 4, 6, 7, 9, 11};
    const int[] evenMonths = {1, 3, 5, 8, 10};
    const int daysInFebruary = 28;
    const int daysInOddMonths = 31;
    const int daysInEvenMonths = 30;

    for (int i = 0; i < days.Length; i++)
    {
        days[i] = $"{i + 1}";
    } 

    if (DateValid(month, day))
    {
        if ((day == 30) && (evenMonths.Contains(month)))
        {
            return $"{months[month]} {days[0]}";
        }
        else if ((month == 2) && (day == 28))
        {
            return $"{months[month]} {days[0]}";
        }
        else if ((day == 31))
        {
            if (month == 12)
            {
                return $"{months[0]} {days[0]}";
            }
            else
                return $"{months[month]} {days[0]}";
        }
        else
        {
            return $"{months[month] {days[day]}}";
        }
    }
    
    else
        return "Date is not valid";
}

string dateManipulations (int month, int day)
{
    return $"The previous day is {thePreviousDay(month, day)}\nThe next day is {theNextDay(month, day)}";
}

Console.WriteLine(dateManipulations(3, 3));