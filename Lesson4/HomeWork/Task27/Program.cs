// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Summnumb(1234);

void Summnumb(int number){
    int summ = 0;
    for (; number >= 1; number /= 10)
    {
        summ = summ + number%10;
    }
    Console.WriteLine("Сумма цифр в числе: " + summ);
}
