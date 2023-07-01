bool ContainsNSameDigits (int number, int n) {
    
    Dictionary<int, int> counter = new Dictionary<int, int>();
    
    while (number > 0) {
        if (counter.ContainsKey(number % 10))
        {
            counter[number % 10]++;
        }
        else
        {
            counter[number % 10] = 1;
        }
        number /= 10;
    }

    foreach(int value in counter.Keys)
    {
        if (counter[value] == n)
        {
            return true;
        }
    }
    return false;
}


Console.WriteLine(ContainsNSameDigits(44555, 3));