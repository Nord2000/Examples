// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Введите два числа в столбик (через Enter)");

string numberStr1 = Console.ReadLine();
string numberStr2 = Console.ReadLine();

int number1 = Convert.ToInt32(numberStr1);
int number2 = Convert.ToInt32(numberStr2);
int max = 0;
int min = 0;

if (number1 > number2) {
    max = number1;
} else {
    max = number2;
} if (number1 > number2) {
    min = number2;
} else {
    min = number1;
}

Console.WriteLine ($"Максимальное число {max}, минимальное число {min}");
