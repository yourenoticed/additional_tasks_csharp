string cardsName (int m, int k)
{
    string[] cards = {"spades", "clubs", "diamonds", "hearts", "Six", "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King", "Ace"};
    if ((m >= 1) && (m <= 4) && (k >= 6) && (k <= 14))
    {
        return $"{cards[k - 2]} of {cards[m - 1]}";
    }
    else
    {
        return "Invalid number either for color or card";
    }
}

Console.WriteLine(cardsName(4, 14));