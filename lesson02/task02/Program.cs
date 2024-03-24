Console.WriteLine("Введите натуральное число:");
int number = Convert.ToInt32(Console.ReadLine());
int[] array = new int[number];
int count = 0;

while (count < array.Length)
{
    array[count] = count + 1;
    Console.Write(array[count] + " ");
    count++;
}