int[] CreateRndArray(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max + 1);
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
int ArrayToNum(int[] array)
{
    int num = 0;
    for (int i = 0; i < array.Length; i++)
    {
        num = num * 10 + array[i];
    }
    return num;
}

Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());

int min = 1;
int max = 10;

if (size < 1 || size > 8)
{
    Console.WriteLine("Размер массива должен быть от 1 до 8");
    return;
}



int[] globalArray = CreateRndArray(size, min, max);
PrintArray(globalArray);
int num = ArrayToNum(globalArray);
Console.WriteLine(num);

