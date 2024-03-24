//Найдите произведения пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новый массив.
//[1 3 2 4 2 3] => [3 6 8]
//[2 3 1 7 5 6 3] => [6 18 5] (элемент 7 не имеет пары)

Console.WriteLine("Введите размер массива");

int[] array = new int[Convert.ToInt32(Console.ReadLine())];

Console.WriteLine("Введите элементы массива");
for (int i = 0; i < array.Length; i++)
{
    array[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("Ваш массив: ");
Console.WriteLine(string.Join(", ", array));

int size = array.Length / 2;

int[] newArray = new int[size];

for (int i = 0; i < size; i++)
{
    newArray[i] = array[i] * array[array.Length - 1 - i];
}

Console.WriteLine("Новый массив: ");
Console.WriteLine(string.Join(", ", newArray));

