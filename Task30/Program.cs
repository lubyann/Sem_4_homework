﻿//30 Напишите программу, которая выводит массив из 8 элементов, 
//заполненный нулями и единицами в случайном порядке.

//[1,0,1,1,0,1,0,0]
// a = new Random().Next()
// int a = new Random().Next(2)

Console.Clear();
// Console.Write("Enter a number: ");
// int num = int.Parse(Console.ReadLine()!);
int num = 8;
int[] array = GetBinaryArray(num);
Console.WriteLine($"[{String.Join(", ", array)}]");

for (int i = 0; i < array.Length - 1; i++)
{
    Console.Write($"{array[i]}, ");
}
Console.WriteLine($"{array[array.Length - 1]}");


int[] GetBinaryArray(int size)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(2);
    }
    return result;
}

foreach(var el in array){
    Console.Write($"{el} ");
}