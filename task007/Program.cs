﻿// Задача 15: Напишите программу, которая принимает на вход цифру,
//  обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите цифру: ");
int number  = Convert.ToInt32(Console.ReadLine());
bool weekend (int number)
{
    return (number == 6 || number == 7);
}
Console.WriteLine(weekend(number));