//Задайте массив из 10 элементов, заполненный числами из промежутка [-10, 10]. Замените отрицательные элементы на положительные, а положительные на отрицательные.

int[] array = new int[10];
Console.WriteLine("Введите 10 элементов массива от -10 до 10");
for (int i = 0; i < array.Length; i++)
{
    Console.Write($"Введите {i + 1} элемент массива ");
    array[i] = Convert.ToInt32(Console.ReadLine());
}

for (int i = 0; i < array.Length; i++)
{
    array[i] = array[i] * -1;
    Console.Write(array[i] + " ");
}

