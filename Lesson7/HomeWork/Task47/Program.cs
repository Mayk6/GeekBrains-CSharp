// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

Console.WriteLine("Введите кол-во строк");
int columsn = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кол-во столбцов");
int rows = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[columsn, rows];
FillArray(array);
PrintArray(array);


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

