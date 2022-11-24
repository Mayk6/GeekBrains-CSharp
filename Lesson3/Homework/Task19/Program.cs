// Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Palindrome(12321);

void Palindrome (int a){
int b = a;
int reverce = 0;

while (a != 0)
{
    int digit = a%10;
    reverce = reverce*10 + digit;
    a = a/10;
}
if (reverce == b) Console.WriteLine("Число полиндром ");
else Console.WriteLine("Не полиндром");
}