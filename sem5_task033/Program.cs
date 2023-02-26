﻿// Напишите программу, 
// которая определяет, присутствует ли заданное число в массиве.

// 4; массив[6, 7, 19, 345, 3]->нет

// 3; массив[6, 7, 19, 345, 3]->да*/

// Console.Write("Enter a number: ");
// int num = int.Parse(Console.ReadLine()!);
// int[] array = { 4, 18, 20, 3, 2, 7 };

// int[] array(int num)
// {
//     int i = 0;
//     if (i < array.Lenght)
//     {
//     }
// }

Console.Clear();
Console.Write("Введите элементы массива через пробел: ");
string elements = Console.ReadLine();
int[] baseArray = GetArrayFromString(elements);
Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine());
if (FindElement(baseArray, n))
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}


int[] GetArrayFromString(string stringArray)
{
    string[] nums = stringArray.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    int[] res = new int[nums.Length];

    for (int i = 0; i < nums.Length; i++)
    {
        res[i] = int.Parse(nums[i]);
    }
    return res;
}

bool FindElement(int[] array, int el)//[1,2,3,4] 5
{
    foreach (var item in array)//
    {
        if (el == item) // 5 == 4
            return true;
    }
    return false;
}