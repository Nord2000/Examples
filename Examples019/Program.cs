// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
Console.WriteLine ("Введите кол-во строк");
int rows = int.Parse(Console.ReadLine());
Console.WriteLine ("Введите кол-во столбцов");
int colums = int.Parse(Console.ReadLine());


int [,] matrix = new int [rows,colums];
Random random = new Random();

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix [i,j] = random.Next(-10,10);
    }
}
Console.WriteLine();

for (int y = 0; y < matrix.GetLength(0); y++)
{
    for (int x = 0; x < matrix.GetLength(1); x++)
    {
        Console.Write(matrix[y,x] + "\t");
    }
    Console.WriteLine();
}
