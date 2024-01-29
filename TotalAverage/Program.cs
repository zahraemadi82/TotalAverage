// See https://aka.ms/new-console-template for more information
double sum = 0;
double countSum = 0;
for (int i = 1; i <= 20; i++)
{
    Console.Write($"Enter Number {i} : ");
    double number = Convert.ToDouble(Console.ReadLine());
    if (number > 20 || number < 0)
    {
        Console.WriteLine("Invalid input");
    }
    else
    {
        sum += number;
        countSum += 1;
    }
}

sum /= countSum;
Console.WriteLine(sum);
