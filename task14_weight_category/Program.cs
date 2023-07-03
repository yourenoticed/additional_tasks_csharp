string weightCategory (int weight)
{
    if (weight < 60)
    {
        return "Лёгкий вес";
    }
    if (weight >= 60 && weight < 64)
    {
        return "Первый полусредний вес";
    }
    if (weight >= 64 && weight < 69)
    {
        return "Полусредний";
    }
    else
    {
        return "Неизвестная категория";
    }
}

Console.WriteLine(weightCategory(64));