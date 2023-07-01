bool CanVasyaStickHisHeadOut (int aSide, int bSide, int diameter) {
    if (aSide - diameter >= 2 && bSide - diameter >= 2)
        return true;
    else
        return false;
}

Console.WriteLine(CanVasyaStickHisHeadOut(10, 10, 9));
