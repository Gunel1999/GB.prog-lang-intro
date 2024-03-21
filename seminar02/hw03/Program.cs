//Напишите программу, которая принимает на вход целое число из отрезка [10, 99] и показывает наибольшую цифру числа.
Console.WriteLine("Введите целое число от 10 до 99");
int number = int.Parse(Console.ReadLine());
int a = number / 10;
int b = number % 10;
if (a > b)
{
    Console.WriteLine($"Наибольшая цифра введенного числа - {a}");
}
else
{
    Console.WriteLine($"Наибольшая цифра введенного числа - {b}");
}