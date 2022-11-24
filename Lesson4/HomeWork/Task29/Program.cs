// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

InitArray();

void InitArray(){
    int[] array = new int[8];
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(1,20);
    }
    Console.WriteLine("[{0}]",string.Join(", ", array));
}
