// Task 8. All even numbers
Console.Write("Введите число: \n");
int a = Convert.ToInt32(Console.ReadLine());
int i = 1;
while (i <= a)
{
    if (i % 2 == 0)
        Console.Write(i);
        Console.Write(" ");
    i++;
}