void PrintSquares(int n)
{
    int i = 1;
    while (i <= n)
    {
        Console.Write($"{i * i} ");
        i++;
    }
}

PrintSquares(5);
PrintSquares(10);
PrintSquares(15);