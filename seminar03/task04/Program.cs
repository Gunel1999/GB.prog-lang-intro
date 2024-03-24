//Дано натуральное трёхзначное число. Создайте массив, состоящий из цифр этого числа. Младший разряд числа должен располагаться на 0м индексе массива, старший – на 2-м. Пример 456  =>  [6 5 4] 781  =>  [1 8 7]

Console.WriteLine("Введите трехзначное положительное число");
int number = Convert.ToInt32(Console.ReadLine());
int[] array = new int[3];

if (number > 99 && number < 1000)
{
    for (int i = 0; i < 3; i++)
    {
        array[i] = number % 10;
        number = number / 10;
    }
    Console.WriteLine(string.Join(" ", array));
}
else if (number < 0)
{
    Console.WriteLine("Число отрицательное");
}
else
{
    Console.WriteLine("Число не трехзначное");
}
