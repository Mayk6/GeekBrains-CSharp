Console.WriteLine("Эта программа выясняет является ли первое число квадратом второго");
Console.Write("Введите первое число: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int y = Convert.ToInt32(Console.ReadLine());

if (y == (x*x))
{
    Console.WriteLine("Перове число является квадратом второго");
}
else
{
    Console.WriteLine("Перове число не является квадратом второго");
}

