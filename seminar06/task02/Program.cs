string str = "Hello";

char[] CharsFromString(string str)
{
    char[] chars = new char[str.Length];
    for (int i = 0; i < str.Length; i++)
    {
        chars[i] = str[i];
    }
    return chars;
}

void PrintArray(char[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1)
        {
            Console.Write($"{array[i]}, ");
        }
        else
        {
            Console.Write($"{array[i]}");
        }
    }
    Console.Write("]");
}

char[] chars = CharsFromString(str);
PrintArray(chars);