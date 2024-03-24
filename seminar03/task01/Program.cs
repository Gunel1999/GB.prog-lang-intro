//Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве. Программа должна выдать ответ: Да/Нет.

// int[] array = { 1, 3, 4, 19, 3 };
// int[] array = { -4, 3, 4, 1 };
// int find = 3;
bool result = false;

Console.WriteLine("Введите число для поиска");
int find = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите размер массива");
int[] array = new int[Convert.ToInt32(Console.ReadLine())];
Console.WriteLine("Введите элементы массива");
for (int i = 0; i < array.Length; i++)
{
    array[i] = Convert.ToInt32(Console.ReadLine());
}

for (int i = 0; i < array.Length; i++)
{
    if (array[i] == find)
    {
        result = true;
        break;
    }
}

Console.WriteLine(result ? "Да" : "Нет");
