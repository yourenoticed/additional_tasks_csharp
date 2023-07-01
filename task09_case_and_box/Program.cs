bool CanPutBoxInCase (int a1, int a2, int a3, int b1, int b2, int b3) {
    if (a1 > b1 && a2 > b2 && a3 > b3)
        return true;
    else if (a1 > b3 && a2 > b1 && a3 > b2)
        return true;
    else
        return false;
}

Console.WriteLine(CanPutBoxInCase(10, 10, 10, 5, 6, 6));