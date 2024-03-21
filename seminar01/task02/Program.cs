Console.WriteLine("Введите целое положительное число N:");
int num = Convert.ToInt32(Console.ReadLine());

if (num > 0)
{
    int count = -num;
    while (count <= num)
    {
        Console.Write(count + " ");
        count++;
    }
}
else
{
    Console.WriteLine("Введено некорректное число");
}
