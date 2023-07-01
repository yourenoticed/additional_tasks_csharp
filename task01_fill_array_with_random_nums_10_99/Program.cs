int[] FillArray10To99(int size) // also prints it out
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++) {
        result[i] = new Random().Next(10, 100);
    }
    PrintArray(result);
    return result;
}

void PrintArray(int[] array) {
    Console.Write("[");
    for (int i = 0; i < array.Length; i++) {
        if (i == array.Length - 1){
            Console.WriteLine($"{array[i]}]");
        }
        else {
            Console.Write($"{array[i]}, ");
        }
    }
}

int[] array = FillArray10To99(2);