// Вычислить факториал числа N
int n = 4;

int Factorial(int n)
{
    if (n == 1 || n == 0)
    {
        Console.WriteLine("Факториал равен 1");
        return 1;
    }
    else
    {
        Console.WriteLine($"Факториал равен {n} * {n - 1}");
        return n * Factorial(n - 1);
    }
}

Console.WriteLine(Factorial(n));