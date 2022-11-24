// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

int[] array = new int[10];
Random random = new Random();

FillArray(array);
Console.WriteLine("[{0}]",string.Join(", ", array));
Summofodd(array);

void Summofodd(int[] array)
{
    int summ = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(i%2 != 0) summ += array[i];
    }
    Console.WriteLine("Сумма элементов стоящих на нечетных позициях = : " + summ);
}

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++) array[i] = random.Next(1,999);
}
