//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.WriteLine("Введите целое число: ");
int number = int.Parse(Console.ReadLine());

for (int index = 1; index <= number; index++)
{
    double result = Math.Pow(index,3);
    Console.Write($"{result} ");
}