string GetLetters(string s)
{
    string letters = "";
    foreach (char c in s)
    {
        if (char.IsAsciiLetter(c))
        {
            letters += c;
        }
    }
    return letters;
}

Console.WriteLine("Введите строку:");
string str = Console.ReadLine();
string letters = GetLetters(str);
Console.WriteLine(letters);
