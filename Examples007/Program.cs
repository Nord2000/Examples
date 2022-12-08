//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

while (true) {
    Console.WriteLine ("Введите номер дня недели");
    int number = int.Parse(Console.ReadLine());
    if ( number >=1 && number <= 5) {
        Console.WriteLine ("Нет, это не выходной");
    } else if (number >= 6 && number <= 7) {
        Console.WriteLine ("Да это выходной");
    }
    else Console.WriteLine("Не существует такого дня недели");
}