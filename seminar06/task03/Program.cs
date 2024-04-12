int CountWowels(string str)
{
    str = str.ToLower();
    string vowels = "aeiouy";
    int count = 0;
    for (int i = 0; i < str.Length; i++)
    {
        for (int j = 0; j < vowels.Length; j++)
        {
            if (str[i] == vowels[j])
            {
                count++;
            }
        }
    }
    return count;
}

Console.Write("Введите строку: ");
string userInput = Console.ReadLine();
int count = CountWowels(userInput);
Console.WriteLine(count);