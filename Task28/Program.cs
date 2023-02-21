//28 Напишите программу, которая принимает на вход число N 
//и выдаёт произведение чисел от 1 до N.

//4-> 24
//5-> 120 == 1 * 2 * 3 * 4 * 5

int Number(int n)
{
    int count = 1;
    int i = 2;
    if (n < 0)
    {
        i = n;
        n = -1;
    }
    for (; i <= n; i++)
    {
        count = count * i;
    }
    return count;
}

Console.Clear();
Console.Write("Enter a number: ");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine($"{n} -> {Number(n)}");

