// Задайте произвольную строку. Выясните, является ли она палиндромом.

bool Palindrom(string str)
{
    for (int i = 0; i < str.Length / 2; i++)
    {
        if (str[i] != str[str.Length - 1 - i])
            return false;
    }
    return true;
}

Console.WriteLine("Введите строку");
string str = Console.ReadLine();
bool result = Palindrom(str);
Console.WriteLine(result ? "Палиндром" : "Не палиндром");
