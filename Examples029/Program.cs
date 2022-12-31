// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
uint m = 2;
uint n = 3;

uint Fun(uint n, uint m)
{
    if (n == 0)
        return m + 1;
    else if ((n != 0) && (m == 0))
        return Fun(n - 1, 1);
    else
        return Fun(n - 1, Fun(n, m - 1));
}

Console.WriteLine(Fun(m,n));
