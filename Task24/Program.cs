




int GetSum(int n)
{
    int sum = 0;
    for (int i = 1; i <= n; i++)
        sum += i; // sum = sum + i
    return sum;
}

Console.Clear();
Console.Write("Enter a number: ");
int n = int.Parse(Console.ReadLine()!);
// GetSum(n);
//int result = GetSum(n);
Console.WriteLine($"Сумма от 1 до {n} равна {GetSum(n)}");
