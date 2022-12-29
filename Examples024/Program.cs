// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Перемножить 
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
    Console.WriteLine("Выводим матрицу");
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

int[,] multiplyMatrices(int[,] A, int[,] B)
{   
    if (A.GetLength(1) != B.GetLength(0))
    {
        throw new InvalidOperationException("Колличество столбцов матрицы А не соответствует колличеству строк матрицы B");
    }
    int[,] C = new int [A.GetLength(0),B.GetLength(1)];
    for (int i = 0; i < C.GetLength(0); i++)
    {
        for (int j = 0; j < C.GetLength(1); j++)
        {
            C[i,j] = 0;
            for (int r = 0; r < A.GetLength(1); r++)
            {
                C[i,j] += A[i,r] * B[r,j];
            }
        }
    }
    return C;
}

int rowsA = readInt("Введите кол-во строк матрицы А ");
int columnsA = readInt("Введите кол-во столбцов матрицы А ");

int[,] matrixA = initMatrix(rowsA, columnsA);
printMatrix(matrixA);

int rowsB = readInt("Введите кол-во строк матрицы B ");
int columnsB = readInt("Введите кол-во столбцов матрицы B ");

int[,] matrixB = initMatrix(rowsB, columnsB);
printMatrix(matrixB);

int[,] matrixC = multiplyMatrices (matrixA, matrixB);
printMatrix(matrixC);