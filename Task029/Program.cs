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