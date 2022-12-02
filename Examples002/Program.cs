// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.


Console.WriteLine("Введите три числа в столбик (через Enter)");

string numberStr1 = Console.ReadLine();
string numberStr2 = Console.ReadLine();
string numberStr3 = Console.ReadLine();


int number1 = Convert.ToInt32(numberStr1);
int number2 = Convert.ToInt32(numberStr2);
int number3 = Convert.ToInt32(numberStr3);
int max = 0;
int max_1 = 0;

if (number1 > number2) {
    max_1 = number1;
} else {
    max_1 = number2;
} if (max_1 > number3) {
    max = max_1;
} else { 
    max = number3;
}

Console.WriteLine ($"Максимальное число {max}");