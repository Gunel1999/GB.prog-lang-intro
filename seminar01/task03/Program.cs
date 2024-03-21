Console.WriteLine("Введите трехзначное целое число:");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 100 && number < 999)
{
    int firstDigit = number / 100;
    int lastDigit = number % 10;
    int result = firstDigit + lastDigit;
    Console.WriteLine($"Сумма первой и последней цифр числа {number} равна {result}");
}
else
{
    Console.WriteLine("Введено неверное значение");
}