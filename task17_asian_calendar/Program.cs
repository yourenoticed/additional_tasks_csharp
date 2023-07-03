string AsianYear(int year)
{
    string[] animals = {"rat", "cow", "tiger", "hare", "dragon", "snake", "horse", "sheep",
    "monkey", "cock", "dog", "pig"};
    string[] colors = {"green", "fiery", "yellow", "metal", "black"};
    return $"{year} is the year of {colors[(year - 4) % 5]} {animals[(year - 4) % 12]}";
}

System.Console.WriteLine(AsianYear(1984));