//Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

int [,,] array = new int[2,2,2];
FillArray(array);
PrintArray(array);


void PrintArray(int[,,] arr)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]} ({i},{j},{k}) ");
            }
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}

void FillArray(int[,,] arr)
{
    
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            int k = 0;
            while (k < arr.GetLength(2))
            {
                int number = new Random().Next(10, 100);
                if (FindElement(arr, number)) continue;
                arr[i, j, k] = number;
                k++;
            }
        }
    }
    PrintArray(arr);
}

bool FindElement(int[,,] arr, int number)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                if (arr[i, j, k] == number) return true;
            }
        }
    }
    return false;
}