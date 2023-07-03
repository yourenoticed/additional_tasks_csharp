string FoundShrooms(int amount)
{
    if ((amount % 10 == 1) && (amount != 11))
    {
        return $"Мы нашли {amount} гриб";
    }
    else if ((amount % 10 >= 2) && (amount % 10 < 5) && (amount < 10 || amount > 20))
    {
        return $"Мы нашли {amount} гриба";
    }
    else if ((amount > 10) && (amount <= 20))
    {
        return $"Мы нашли {amount} грибов";
    }
    else
    {
        return $"Мы нашли {amount} грибов";
    }    
}
for (int x = 1; x <= 35; x++)
{
    System.Console.WriteLine(FoundShrooms(x));
}