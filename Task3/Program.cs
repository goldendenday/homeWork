﻿//Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.WriteLine("Введите число"); 
int number1 = Convert.ToInt32(Console.ReadLine());
if (number1 % 2 == 0 )
{
    Console.WriteLine(number1 + " является четным");
}
else 
{
    Console.WriteLine(number1 + " не является четным");
}