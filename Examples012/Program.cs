// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.WriteLine ("Ведите число");

string num = Console.ReadLine();
int sum = 0; 

for (int i = 0; i < num.Length; i++)
{
    int number = Convert.ToInt32(num[i].ToString());
    sum += number;
}
Console.WriteLine(sum);