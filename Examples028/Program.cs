// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

Console.WriteLine("Введите число M = ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N = ");
int n = Convert.ToInt32(Console.ReadLine());
int sum = 0;

int sumNaturalNumberAfromB(int m, int n)
{
        for (int i = m; i <= n; i++)
        {
        sum = sum + i;        
        }    
    return sum;
}

Console.WriteLine(sumNaturalNumberAfromB(m, n));



