Console.WriteLine("Введите трехзначное число:");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 99 && number < 1000 || number < -99 && number > -1000)
{
    int firstDigit = number / 100 * 10;
    int lastDigit = number % 10;
    int result = firstDigit + lastDigit;
    Console.WriteLine($"Сумма первой и последней цифры трехзначного числа {number} равна {result}");
}
else
{
    Console.WriteLine("Число не трехзначное");
}