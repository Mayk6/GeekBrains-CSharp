// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

int[] array = new int[10];
Random random = new Random();

FillArray(array);
Console.WriteLine("[{0}]",string.Join(", ", array));
Diff(array);

void Diff(int[] array)
{
    int min = array[0];
    int max = array[0];
    foreach (int i in array)
    {
      if (i < min) min = i;
      if (i > max) max = i;   
    }
    Console.WriteLine($"Максимальный элемент = {max}\nМинимальный элемент = {min}");
    Console.WriteLine($"Разница между максимальным и минимальным элементом = {max-min}");
}

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++) array[i] = random.Next(-100,100);
}