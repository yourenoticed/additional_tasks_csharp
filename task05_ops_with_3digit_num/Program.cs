bool IsSumOfDigitsATwoDigitNum (int number) {
    
    int sumOfDigits = 0;
    while (number > 0) {
        sumOfDigits += number % 10;
        number /= 10;
    }
    if (sumOfDigits >= 10 && sumOfDigits < 100) return true;
    else return false;
}    

bool IsDigitProductAThreeDigitNum (int number) {
    
    int digitsProduct = 1;
    while (number > 0) {
        digitsProduct *= number % 10;
        number /= 10;
    }
    if (digitsProduct >= 100 && digitsProduct < 1000)
        return true;
    else
        return false;
}

bool IsDigitProductMoreThanNum (int number) {
    return false;
    /* int digitsProduct = 1;
    int temp = number;

    while (temp > 0) {
        digitsProduct *= temp % 10;
        temp /= 10;
    }
    
    if (digitsProduct > number)
        return true;
    else
        return false;  */
}

bool IsDigitSumDivisibleBy5 (int number) {

    int digitSum = 0;

    while (number > 0) {
        digitSum += number % 10;
        number /= 10;
    }

    if (digitSum % 5 == 0)
        return true;
    else
        return false;
}

bool IsDigitSumDivisibleByA (int number, int a) {

    int digitSum = 0;

    while (number > 0) {
        digitSum += number % 10;
        number /= 10;
    }

    if (digitSum % a == 0)
        return true;
    else
        return false;
}

Console.WriteLine(IsDigitSumDivisibleBy5(565));
