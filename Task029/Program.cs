// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

Console.Clear();
// Console.Write("Enter a number: ");
// int num = int.Parse(Console.ReadLine()!);
int num = 8;
int[] array = GetBinaryArray(num);
Console.WriteLine($"[{String.Join(", ", array)}]");

// for (int i = 0; i < array.Length - 1; i++)
// {
//     Console.Write($"{array[i]}, ");
// }
// Console.WriteLine($"{array[array.Length - 1]}");


int[] GetBinaryArray(int size)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(0, 100);
    }
    return result;
}

// foreach(var el in array){
//     Console.Write($"{el} ");
// }

// РЕШЕНИЕ ЭТАЛОН

// // Ввод числа с экрана
// int Prompt(string message)
// {
//     Console.Write(message); // Выводим приглашение ко вводу
//     string ReadInput = Console.ReadLine();
//     int result = int.Parse(ReadInput); // приводим к числу
//     return result; // Возвращаем результат
// }

// // Метод для получения случайных значений массива
// int[] GenerateArray(int Length, int minValue, int maxValue)
// {
//     int[] array = new int[Length]; // объявляем массив
//     Random random = new Random();
//     for (int i = 0; i < Length; i++)
//     {
//         array[i] = random.Next(minValue, maxValue + 1); // заполняем случайными цифрами из диапазона SatrArr до EndArr
//     }
//     return array;
// }

// void PrintArray(int[] array);
// {
//     Console.Write("[");
//     for (int i = 0; i < array.Length - 1; i++)
//     {
//         Console.Write($"{array[i]}, "); // вывод значения массива
//     }
//     Console.Write($"{array[array.Lenght - 1]}"); // вывод значения массива
//     Console.Write("]");
// }

// int lenght = Prompt("Длина массива: ");
// int min = Prompt("Начальное значение, для диапазона случайного числа: ");
// int max = Prompt("Конечное значение, для диапазона случайного числа: ");
// int[] array = GenerateArray(lenght, min, max); // заполнение массива случайными числами
// PrintArray(array); // Вывод массива
