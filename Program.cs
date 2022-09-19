// Task 4. Compare 2 numbers
Console.Write("Введите первое число: \n");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: \n");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: \n");
int c = Convert.ToInt32(Console.ReadLine());
if (a > b)
{
    if (a > c)    {        Console.Write($"Максимальное число: {a}");    }
    else    {        Console.Write($"Максимальное число: {c}");    }
}
else
{
    if (b > c)    {        Console.Write($"Максимальное число: {b}");    }
    else    {        Console.Write($"Максимальное число: {c}");    }
}