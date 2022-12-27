// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// 1. Считать размеры матрицы (NxM)

int N = readInt("Введите кол-во строк N = ");
int M = readInt("Введите кол-во столбцов M = ");

// 2. Считать позицию элемента (i,j)

int i = readInt("Введите позицию элемента по вертикали");
int j = readInt("Введите позицию элемента по горизонтали");

// 3. Если вне массива (i<0 || i>=N || j<0 || j>=M) скажет что такого элемента нет, иначе генерируем матрицу и выводим элемента на позиции i,j 
  
if (i < 0 || i >= N || j < 0 || j >= M) 
{
    Console.WriteLine("Элемент c указанной позицией нет");
} 
else
{
    int [,] matrix = initMatrix(N, M);
    printMatrix(matrix);
    printMatrix(matrix);
    Console.WriteLine($"Элемент матрицы на позиции ({i}, {j}) = {matrix[i, j]}");
}

void printMatrix (int [,] matrix)
{
    for (int y = 0; y < matrix.GetLength(0); y++)
    {
        for (int x = 0; x < matrix.GetLength(1); x++)
        {
            Console.Write(matrix[y,x] + "\t");
        }
        Console.WriteLine();
    }
}

int[,] initMatrix(int rows, int colums)
{
    int [,] matrix = new int [rows,colums];
    Random random = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix [i,j] = random.Next(10);
        }
    }
    return matrix;
}

int readInt(string prompt)
{
    Console.WriteLine(prompt);
    return int.Parse(Console.ReadLine()); 
}

