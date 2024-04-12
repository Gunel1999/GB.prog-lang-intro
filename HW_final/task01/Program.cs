//Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.
//Пример: 
//M = 1; N = 5 -> "1, 2, 3, 4, 5" 
//M = 4; N = 8 -> "4, 5, 6, 7, 8"

void PrintNumbers(int m, int n)
{
    if (m > n) return;
    if (m == n) Console.Write(m);
    else Console.Write(m + ", ");
    PrintNumbers(m + 1, n);
}

PrintNumbers(1, 5);
Console.WriteLine();
PrintNumbers(4, 8);