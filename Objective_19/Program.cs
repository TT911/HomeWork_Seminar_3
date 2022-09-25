//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.WriteLine("Введите натуральное число: ");
int number = int.Parse(Console.ReadLine());
int p = 0; 
int num = number;

while (number > 0) 
{
    p = p * 10 + number % 10; 
    number = number / 10;
}

Console.WriteLine(num == p ? "Палиндром" : "Не палиндром");