// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

Exponentional(3,3);


void Exponentional(int number, int exponent){
    int num_ex = 1;
    for (int i = 0; i < exponent; i++)
    {
        num_ex *= number;
    }
    Console.WriteLine("Результат: " + num_ex);
}

