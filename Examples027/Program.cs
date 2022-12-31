// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
Console.WriteLine("Введите число");
int N = Convert.ToInt32(Console.ReadLine());

string naturalOfNumberN(int N)
{
    if(N < 1) return String.Empty;
    return $"{N} {naturalOfNumberN(N - 1)}";
}

Console.WriteLine(naturalOfNumberN(N));
