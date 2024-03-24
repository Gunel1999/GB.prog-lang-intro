// int n = 10;
int[] array = { 1, 12, 31, 4, 18, 15, 16, 17, 18, 10 };
int count = 0;

while (count < array.Length)
{
    if (array[count] % 2 == 0)
    {
        Console.Write(array[count] + " ");
    }
    count++;
}