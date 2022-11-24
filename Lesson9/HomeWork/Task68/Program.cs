// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

Console.WriteLine(AckermanFunction(-1, 0));

int AckermanFunction(int m, int n)
{
    if (m == 0) return n + 1;
    if (m > 0 && n == 0) return AckermanFunction(m - 1, 1);
    if (m > 0 && n > 0) return AckermanFunction(m - 1, AckermanFunction(m, n - 1));
    if (m < 0 || n < 0)
    Console.WriteLine($"Число m = {m} или число n = {n} отрицательно, программа не может быть выполненена.");
    return 0;
}
