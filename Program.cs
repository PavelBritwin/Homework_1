// Task 2. Compare 2 numbers
Console.Write("Введите первое число: \n");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: \n");
int b = Convert.ToInt32(Console.ReadLine());
if (a > b)
{
    Console.Write($"Первое число {a} больше второго {b}");
}
else if (a < b)
{
    Console.Write($"Второе число {b} больше первого {a}");
}
else
{
    Console.Write("Введенные числа равны");
}