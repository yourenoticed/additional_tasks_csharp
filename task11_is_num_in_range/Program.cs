void IsNumInRange1_6_To_3_8(double firstNum, double secondNum, double thirdNum)
{
    double[] array = {firstNum, secondNum, thirdNum};
    foreach (double i in array)
    {
        if ((i >= 1.6) && (i <= 3.8))
        {
            System.Console.Write($"{i} ");
        }
    }
    System.Console.WriteLine();
}
IsNumInRange1_6_To_3_8(12, 3.2, 1.9);

void IsNumInRange0_7_To_5_1(double firstNum, double secondNum, double thirdNum)
{
    double[] array = {firstNum, secondNum, thirdNum};
    foreach (double i in array)
    {
        if ((i >= 0.7) && (i <= 5.1))
        {
            System.Console.Write($"{i} ");
        }
    }
    System.Console.WriteLine();
}

