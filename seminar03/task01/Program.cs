//Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве. Программа должна выдать ответ: Да/Нет.

// int[] array = { 1, 3, 4, 19, 3 };
int[] array = { -4, 3, 4, 1 };
int find = 3;
bool result = false;

for (int i = 0; i < array.Length; i++)
{
    if (array[i] == find)
    {
        result = true;
        break;
    }
}

Console.WriteLine(result ? "Да" : "Нет");
