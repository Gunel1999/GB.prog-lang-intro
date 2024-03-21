Console.WriteLine("Введите трехзначное число:");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 99 && number < 1000 || number < -99 && number > -1000)
{
    int middle = (number / 10) % 10;
    int last = number % 10;
    int counter = 0;
    double result = 1;

    if (last < 0)
    {
        last = last * -1;
    }

    while (counter < last)
    {
        result = middle * result;
        counter++;
    }

    if (middle < 0)
    {
        result = 1 / result;
    }
    Console.WriteLine(result);
}
else
{
    Console.WriteLine("Число не трехзначное");
}