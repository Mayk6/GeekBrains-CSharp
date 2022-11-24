// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

int[,] array = new int[4, 4];
FillArray(array);
PrintArray(array);
Console.WriteLine(PrintArrayElement(array,4,3));


int PrintArrayElement(int[,] arr, int row, int column)
{
    if (row > arr.GetLength(0) || column > arr.GetLength(1))
    {
        Console.WriteLine("Такого элемента нет");
        return 0;
        
    }
    else return arr[row-1, column-1];
}

void FillArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 100);
        }
    }

}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

