// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int readInt (string prompt)
{
    int result = 0;
    while(true)
    {
        Console.WriteLine(prompt);
        if (int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не число");
        }
    }
    return result;
}

int[,] initMatrix(int rows, int columns)
{
    int[,] matrix = new int [rows,columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = rnd.Next(1,15);
        }
    }
    return matrix;
}

void printMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write ($"{matrix[i,j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int findMinSumVectorIndex (int[,] matrix)
{
    int minSum = 0;
    int indexOfMinSum = 0;

    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        minSum = minSum + matrix[0,j];
    }
    for (int i = 1; i < matrix.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum = sum + matrix[i,j];
        }
        if (minSum > sum)
        {
            minSum = sum;
            indexOfMinSum = i;
        }
    }
    return indexOfMinSum;
}

int rows = readInt("Введите кол-во строк ");
int columns = readInt("Введите кол-во столбцов ");
int [,] matrix = initMatrix(rows, columns);
printMatrix(matrix);
int indexOfMinSum = findMinSumVectorIndex(matrix);
Console.WriteLine ($"Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов - {indexOfMinSum + 1} строка");
