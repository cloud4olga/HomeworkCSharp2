﻿// Напишите программу, которая приниимает на вход цифру, обозначающую день недели, и проверяет, 
// является ли этот день выходным. 6-> да; 7-> да; 1-> нет;

Console.WriteLine("Введите цифру от 1 до 7");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 1 || number > 7)
{
    Console.WriteLine("Ошибка. Введите цифру строго от 1 до 7");
}
else {
    switch (number)
    {
        case 1: Console.WriteLine("Нет, сегодня не выходной день");
        break;
        case 2: Console.WriteLine("Нет, сегодня не выходной день");
        break;
        case 3: Console.WriteLine("Нет, сегодня не выходной день");
        break;
        case 4: Console.WriteLine("Нет, сегодня не выходной день");
        break;
        case 5: Console.WriteLine("Нет, сегодня не выходной день");
        break;
        case 6: Console.WriteLine("Да, сегодня выходной день");
        break;
        case 7: Console.WriteLine("Да, сегодня выходной день");
        break;
    }
}