// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.WriteLine ("Введите чилсо N");

int count = int.Parse(Console.ReadLine());

for (int i = 1; i <= count; i++ ) {
    double x = Math.Pow (i, 3);
    Console.WriteLine (x);
}
