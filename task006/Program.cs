﻿// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
Console.WriteLine($"Введите трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number / 100 > 0)
{
    int result = number % 10;
    Console.WriteLine("Третья цифра числа: " + result);
}
else
{
    Console.WriteLine("Третьей цифры нет!");
} 

