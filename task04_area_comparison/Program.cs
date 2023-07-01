const double pi = 3.14;

string CircleSquareAreaComparison (int radius, int side) {
    double circleArea = Math.Pow(radius, 2) * pi;
    int squareArea = side * side;
    if (circleArea > squareArea) {
        return $"The circle area ({circleArea}) is more than the square area ({squareArea})";
    }
    else if (circleArea < squareArea) {
        return $"The square area ({squareArea}) is more than the circle area ({circleArea})";
    }
    else
        return $"The square and circle areas ({circleArea}) are equal";
}

Console.WriteLine (CircleSquareAreaComparison(3, 6));