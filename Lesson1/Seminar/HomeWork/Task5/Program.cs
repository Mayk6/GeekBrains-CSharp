// Задача 5: Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.

Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

int b = -a;
Console.Write("Целые числа от -N до N: ");

while (b<=a)
{
    Console.Write(b + " ");
    b++;
}
Console.WriteLine();
