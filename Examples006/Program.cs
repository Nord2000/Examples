﻿// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет

int number = ReadInt("Введите число: ");
int count = number.ToString().Length;
Console.Write(Array(number, count));

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
int Array(int a, int b)
{
int result = 0;
    if (b < 3)
    {
        Console.Write("Третьей цифры нет, держи: ");
    }
    else
    {
        int c = 1;
        for (int i = b; i > 3; i--)
        {
            c = c * 10;
        }

        result = (a / c) % 10;
    }
return result;
}


