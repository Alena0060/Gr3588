﻿// Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
string? num1Line = Console.ReadLine();
string? num2Line = Console.ReadLine();

if (num1Line != null && num2Line != null)
{
int num1 = int.Parse(num1Line);
int num2 = int.Parse(num2Line);

    if (num2 * num2 == num1)
    {
        Console.WriteLine("Yes");
    }
    else
    {
        Console.WriteLine("No");
    }
}