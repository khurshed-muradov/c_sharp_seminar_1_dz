﻿// Напишите программу, которая на вход принимает число и выдаёт, является ли число четным (делится ли оно без остатка).
// 4 -> Да
// -3 -> Нет
// 7 -> Нет

Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine()!);
if (number % 2 == 0)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}
