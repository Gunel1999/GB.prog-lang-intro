Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int SumOfDigits(int num)
{
    if (num == 0) return 0;
    return num % 10 + SumOfDigits(num / 10);
}

int sum = SumOfDigits(number);
Console.WriteLine($"Сумма цифр числа {number}");
Console.WriteLine(sum);