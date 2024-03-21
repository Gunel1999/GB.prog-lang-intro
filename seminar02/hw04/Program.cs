//Напишите программу, которая на вход принимает натуральное число N, а на выходе показывает его цифры через запятую.

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
string result = "";
while (number > 0)
{
    result = number % 10 + ", " + result;
    number = number / 10;
}
Console.WriteLine(result);