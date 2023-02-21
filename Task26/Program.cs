// 26 Напишите программу,
//  которая принимает на вход число и выдаёт количество цифр в числе.

// 456 -> 3
// 78 -> 2
// 89126 -> 5

int CountNumbers(int n) //123
{
    int count = 0; // count 0

    if (n < 0)
        n *= (-1); // n = n * (-1)
    while (n > 0) // 0> 0
    {
        n /= 10;
        count++;
    }
    return count;
}

Console.Clear();
Console.Write("Enter a number: ");
int n = int.Parse(Console.ReadLine()!);
// GetSum(n);
//int result = GetSum(n);
Console.WriteLine($"{n} -> {CountNumbers(n)}");