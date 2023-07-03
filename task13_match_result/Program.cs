string matchResult (int points)
{
    if (points == 0) return "Defeat";
    else if (points == 1) return "Draw";
    else if (points == 2) return "Victory";
    else return "Invalid amount of points";
}

Console.WriteLine(matchResult(1));