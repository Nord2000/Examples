// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.WriteLine ("Введите трёхзначное число");

string numberStr = Console.ReadLine ();
int number = Convert.ToInt32 (numberStr);
int result = 0;

result = (number % 100) /10;
Console.WriteLine (result);