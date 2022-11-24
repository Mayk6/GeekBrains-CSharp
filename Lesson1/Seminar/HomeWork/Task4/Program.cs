// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.


int a = 5;
int b = 9;
int c = 7;
int max = a;
if (b > max)
{
    max = b;
}
if (c > max)
{
    max = c;
}

Console.WriteLine("Максимальное число: " + max);

//Ниже вариант для ручного ввода

// Console.Write("Введите первое число:");
// int a = Convert.ToInt32(Console.ReadLine()); 
// Console.Write("Введите второе число:");
// int b = Convert.ToInt32(Console.ReadLine()); 
// Console.Write("Введите третье число:");
// int c = Convert.ToInt32(Console.ReadLine()); 
// int max = a;
// if (b > max)
// {
//     max = b;
// }
// if (c > max)
// {
//     max = c;
// }

// Console.WriteLine("Максимальное число: " + max);