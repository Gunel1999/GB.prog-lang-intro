// int n = 5;
int[] array = { 2, 3, 6, 9, 10 };
int count = 0;
int max = array[0];

while (count < array.Length)
{
    if (array[count] > max)
        max = array[count];
    count++;
}

Console.WriteLine(max);