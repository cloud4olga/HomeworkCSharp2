﻿// Напишите программу, которая принимает на вход трехзначное число и на выходе показывает вторую цифру этого числа
// 456 -> 5; 782 -> 8; 918 -> 1;

int number = new Random().Next(100, 1000);
Console.WriteLine(number);
int a = (number - (number / 100 *100) - (number % 10)) / 10;
Console.WriteLine(a);

