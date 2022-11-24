// Задача 21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
double[] Dot_a = {7,-5,0};
double[] Dot_b = {1,-1,9};

Console.WriteLine("Расстояние между точками : " + Distance(Dot_a,Dot_b));

double Distance(double[] A, double[] B){
double distance = 0;
distance = Math.Sqrt(Math.Pow(B[0]-A[0], 2) + Math.Pow(B[1]-A[1], 2) + Math.Pow(B[2] - A[2], 2));
return Math.Round(distance,2);
}
