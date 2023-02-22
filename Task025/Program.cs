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


// РЕШЕНИЕ ЭТАЛОН

// int Prompt(string message)
// {
//     Console.Write(message); //Выводим приглашение ко вводу
//     string readInput = Console.ReadLine()!; // вводим значение
//     int result = int.Parse(readInput); // приводим к числу
//     return result; // возврщаем результат
// }

// int Power(int powerBase, int exponent)
// {
//     int power = 1;
//     for (int i = 0; i < exponent; i++)
//     {
//         power *= powerBase;
//     }
//     return power;
// }

// bool ValidateExponent(int exponent)
// {
//     if (exponent < 0)
//     {
//         Console.Write("Показатель не должен быть меньше нуля");
//         return false;
//     }
//     return true;
// }

// int powerBase = Prompt("Введите основание: ");
// int exponent = Prompt("Введите показатель: ");
// if (ValidateExponent(exponent))
// {
//     Console.Write($"Число {powerBase} в степени {exponent} равно {Power(powerBase, exponent)}");
// }