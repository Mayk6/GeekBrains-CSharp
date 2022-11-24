// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

int[,] array1 = new int[2, 2];
int[,] array2 = new int[2, 2];


FillArray(array1);
FillArray(array2);
PrintArray(array1);
PrintArray(array2);
ArrayMultiplication(array1, array2);

void FillArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(1, 10);
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

void ArrayMultiplication(int[,] arr1, int[,] arr2)
{
    int[,] arrmulti = new int[arr1.GetLength(0), arr1.GetLength(1)];
    for (int i = 0; i < arrmulti.GetLength(0); i++)
    {
        for (int j = 0; j < arrmulti.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < arrmulti.GetLength(1); k++)
            {
                sum += arr1[i, k] * arr2[k, j];
            }
            arrmulti[i, j] = sum;
        }
    }
    PrintArray(arrmulti);
}