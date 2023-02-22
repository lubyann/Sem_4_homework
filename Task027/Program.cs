// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// Console.Clear();
// Console.Write("Enter a number: ");
// int num = int.Parse(Console.ReadLine()!);
// int[] array = numberArray(num);


// int[] numberArray(int a)
// {
//     int[] a = new int[num.ToString().Length];
//     for (int i = 0; i < a.Length; i++)
//     {
//         a[i] = num % 10;
//         num /= 10;
//     }
//     return num;
// }
// Console.Write(numberArray);
// // int sumNumber(int num);
// // {

// // }

// РЕШЕНИЕ ЭТАЛОН

int Prompt(string message)
{
    Console.Write(message); // Выводим приглашение ко вводу
    string readInput = Console.ReadLine()!;
    int result = int.Parse(readInput)!; // приводим к числу
    return result; // Возвращаем результат
}

int SumAllDigit(int number)
{
    int result = 0;
    while (number > 0)
    {
        result += number % 10;
        number = number / 10;
    }
    return result;
}

int number = Prompt("Введите число: ");
Console.WriteLine($"Сумма всех чисел в цифре {number} = {SumAllDigit(number)}");