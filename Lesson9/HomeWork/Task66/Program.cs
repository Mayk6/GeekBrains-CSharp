﻿// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

int m = 1;
int n = 15;
int sum = 0;
for (int i = m ; i <= n; i++) sum += i;
Console.WriteLine($"Сумма в промежутке от {m} до {n} = {sum}");