// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int[,] array = new int[3, 5];
FillArray(array);
PrintArray(array);
SmallestSumInRow(array);

void FillArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(10, 100);
        }
    }
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void SmallestSumInRow(int[,] arr)
{
    int sum;
    int temp = int.MaxValue;
    int index = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        sum = 0;
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            sum = sum + arr[i, j];
        }
        if (sum <= temp)
        {
            temp = sum;
            index = i + 1;
        }
    }
    Console.WriteLine($"Строка № {index} с намиеньшей суммой равной {temp}");
}