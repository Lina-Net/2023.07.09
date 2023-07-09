// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
Console.Write("Введите число: N =  ");
int N = Convert.ToInt32(Console.ReadLine());


for (int m = 1; m <= N; m++)
    Console.WriteLine(Math.Pow(m, 3));
