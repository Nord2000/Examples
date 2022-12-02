// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.WriteLine("Введите число");

string countStr = Console.ReadLine();

double count = Convert.ToDouble(countStr);

if (count % 2 == 0) {
    Console.WriteLine("Да, делится без остатка (чётное) ");
}
Console.WriteLine("Нет, не делится без остатка (нечётное) ");
