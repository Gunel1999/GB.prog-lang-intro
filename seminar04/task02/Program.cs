int[] CreateRndArray(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(min, max);
    }
    return array;
}
void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}
int DivByFinBy(int[] array, int div, int fin)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % div == 0 && array[i] % 10 == fin) count++;
    }
    return count;
}

Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите минимальное значение массива: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите максимальное значение массива: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] globalArray = CreateRndArray(size, min, max);
PrintArray(globalArray);

Console.Write("Введите делитель: ");
int div = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите конечное значение: ");
int fin = Convert.ToInt32(Console.ReadLine());

int count = DivByFinBy(globalArray, div, fin);
Console.WriteLine($"Количество чисел кратных {div} и оканчивающихся на {fin}: {count}");
