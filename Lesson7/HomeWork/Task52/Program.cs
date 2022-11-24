// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int[,] array = new int[5, 5];
FillArray(array);
PrintArray(array);
AvergeInColumn(array);

void AvergeInColumn(int[,] arr)
{
    int sum;
    double averge;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        sum = 0;
        averge = 0;
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            sum = sum + arr[j, i];
        }
        averge = (double) sum / arr.GetLength(0);
        Console.WriteLine("Среднее арифметическое в столце " + (i + 1) + " = " + averge);
    }

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
