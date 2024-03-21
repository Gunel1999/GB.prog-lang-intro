Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 0)
{
    number = number * (-1);
}

if (number > 99)
{
    while (number > 999)
    {
        number = number / 10;
    }
    int result = number % 10;
    Console.WriteLine($"Третяя цифра числа {result}");
}
else
{
    Console.WriteLine("Третьей цифры нет");
}
