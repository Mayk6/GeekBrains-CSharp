//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

int[] array = new int[10];
Random random = new Random();

FillArray(array);
Console.WriteLine("[{0}]",string.Join(", ", array));
ParityCheck(array);

void ParityCheck(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i]%2 == 0) count++;
    }
    Console.WriteLine("Количество четных чисел в массиве: " + count);
}

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++) array[i] = random.Next(100,999);
}

