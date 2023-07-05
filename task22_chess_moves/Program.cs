bool DoesRookThreatCD(int rookX, int rookY, int c, int d)
{
    if (ChessCoordValid(rookX, rookY, c, d))
    {
        if ((rookX == c) || (rookY == d))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    else
    {
        return false;
    }
}

bool ChessCoordValid(int firstX, int firstY, int secondX, int secondY)
{
    if ((firstX > 0) && (firstY > 0) && (firstX <= 8) && (firstY <= 8) && (secondX > 0) && (secondY > 0) && (secondX <= 8) && (secondY <= 8))
    {
        return true;
    }
    else
    {
        return false;
    }
}

bool DoesBishopThreatCD(int bishopX, int bishopY, int c, int d)
{
    if (ChessCoordValid(bishopX, bishopY, c, d))
    {
        for (int count = 1; count < 7; count++)
        {
            if (bishopX + count == c || bishopX - count == c)
            {
                if (bishopY + count == d || bishopY - count == d)
                {
                    return true;
                }
            }
        }
        return false;
    }
    else
    {
        return false;
    }
}

bool CanKingMoveToCD(int kingX, int kingY, int c, int d)
{
    if (ChessCoordValid(kingX, kingY, c, d))
    {
        if ((kingX + 1 == c) || (kingX - 1 == c) || (kingX == c))
        {
            if ((kingY + 1 == d) || (kingY - 1 == d) || (kingY == d))
            {
                return true;
            }

        }
        else if ((kingY + 1 == d) || (kingY - 1 == d) || (kingY == d))
        {
            if ((kingX + 1 == c) || (kingX - 1 == c) || (kingX == c))
            {
                return true;
            }
        }
        return false;
    }
    else
    {
        return false;
    }
}

bool DoesQueenThreatCD(int queenX, int queenY, int c, int d)
{
    if (ChessCoordValid(queenX, queenY, c, d))
    {
        if ((queenX == c) || (queenY == d))
        {
            return true;
        }
        for (int count = 1; count < 7; count++)
        {
            if (queenX + count == c || queenX - count == c)
            {
                if (queenY + count == d || queenY - count == d)
                {
                    return true;
                }
            }
        }
        return false;
    }
    else
    {
        return false;
    }
}

bool CanWhitePawnMoveToCD(int pawnX, int pawnY, int c, int d)
{
    if (ChessCoordValid(pawnX, pawnY, c, d))
    {
        if ((pawnX == c) && (pawnY + 1 == d))
        {
            return true;
        }
        else if ((pawnY == 2) && (pawnX == c) && (pawnY + 2 == d))
        {
            return true;
        }
        return false;
    }
    else
    {
        return false;
    }
}

bool DoesWhitePawnThreatCD(int pawnX, int pawnY, int c, int d)
{
    if (ChessCoordValid(pawnX, pawnY, c, d))
    {
        if ((pawnX + 1 == c && pawnY + 1 == d) || (pawnX - 1 == c && pawnY + 1 == d))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    else
    {
        return false;
    }
}

bool CanBlackPawnMoveToCD(int pawnX, int pawnY, int c, int d)
{
    if (ChessCoordValid(pawnX, pawnY, c, d))
    {
        if ((pawnX == c) && (pawnY - 1 == d))
        {
            return true;
        }
        else if ((pawnY == 7) && (pawnX == c) && (pawnY - 2 == d))
        {
            return true;
        }
        return false;
    }
    else
    {
        return false;
    }
}

bool DoesBlackPawnThreatCD(int pawnX, int pawnY, int c, int d)
{
    if (ChessCoordValid(pawnX, pawnY, c, d))
    {
        if ((pawnX + 1 == c && pawnY - 1 == d) || (pawnX - 1 == c && pawnY - 1 == d))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    else
    {
        return false;
    }
}

bool DoesKnightThreatCD(int knightX, int knightY, int c, int d)
{
    if (ChessCoordValid(knightX, knightY, c, d))
    {
        if (((knightX + 1 == c) || (knightX - 1 == c)) && (knightY + 2 == d))
        {
            return true;
        }
        else if (((knightX + 2 == c) || (knightX - 2 == c)) && (knightY + 1 == d))
        {
            return true;
        }
        else if (((knightX + 1 == c) || (knightX - 1 == c)) && (knightY - 2 == d))
        {
            return true;
        }
        else if (((knightX + 2 == c) || (knightX - 2 == c)) && (knightY - 1 == d))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    else
    {
        return false;
    }
}