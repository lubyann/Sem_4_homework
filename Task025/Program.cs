// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Clear();
Console.Write("Enter a number A: ");
int numA = int.Parse(Console.ReadLine()!);
Console.Write("Enter a number B: ");
int numB = int.Parse(Console.ReadLine()!);
int n = numB;

if (numB < 0)
{
    Console.Write("Введите натуральное число");
}

int degree(int n)
{
    int num = 1;
    for (int i = 0; i < n; i++)
    {
        num = num * numA;
    }
    return num;
}

if (numB > 0) 
Console.Write($"{numA}, {numB} -> {degree(n)}");

