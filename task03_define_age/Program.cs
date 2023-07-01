int Age(int birthYear, int birthMonth, int currentYear, int currentMonth) {
    
    if (birthMonth <= currentMonth) {
        return currentYear - birthYear;
    }
    else
        return currentYear - birthYear - 1;
}

Console.WriteLine(Age(2000, 7, 2023, 6));