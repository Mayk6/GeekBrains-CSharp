// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4. 

int[,] array = new int[4,4];
int temp = 1;
int i = 0;
int j = 0;

while (temp <= array.GetLength(0) * array.GetLength(1))
{
  array[i, j] = temp;
  temp++;
  if (i <= j + 1 && i + j < array.GetLength(1) - 1)
    j++;
  else if (i < j && i + j >= array.GetLength(0) - 1)
    i++;
  else if (i >= j && i + j > array.GetLength(1) - 1)
    j--;
  else
    i--;
}

WriteArray(array);

void WriteArray (int[,] arr)
{
  for (int i = 0; i < arr.GetLength(0); i++)
  {
    for (int j = 0; j < arr.GetLength(1); j++)
    {
      if (arr[i,j] / 10 <= 0)
      Console.Write($" {arr[i,j]} ");

      else Console.Write($"{arr[i,j]} ");
    }
    Console.WriteLine();
  }
}