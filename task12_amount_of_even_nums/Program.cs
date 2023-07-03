int HowManyEvenNums (int[] numbers)
{
    int count = 0;
    foreach (int number in numbers)
    {
        if (number % 2 == 0)
        {
            count++;
        }
    }
    return count;
}

int[] FillArray (int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    { 
        Console.Write("Enter a value: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}
Console.Write("Enter the amount of numbers you wanna input to check if they're even: "); 
int numsSize = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"There are {HowManyEvenNums(FillArray(numsSize))} even numbers");