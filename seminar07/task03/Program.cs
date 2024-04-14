Console.Write("Введите слово: ");
string word = Console.ReadLine();

void PrintConstants(string word, int count)
{
    if (count == word.Length) return;
    string vowels = "aeiouy";
    if (char.IsAsciiLetter(word[count]) && !vowels.Contains(char.ToLower(word[count])))
    {
        Console.Write($"{word[count]} ");
    }
    PrintConstants(word, ++count);
}

PrintConstants(word, 0);