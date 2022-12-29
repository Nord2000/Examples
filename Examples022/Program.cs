// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
int readInt (string promt) 
{
    int result = 0;
    while(true)
    {
        Console.WriteLine(promt);
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

int[,] initMatrix(int rows, int colums)
{
    int[,] matrix = new int [rows,colums];
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

void bubbleMethod(int[,] matrix)
{
    int temp = 0 ;

    for (int k = 0; k < matrix.GetLength(0); k++)
    {
        for (int j = matrix.GetLength(1) - 1; j >= 1; j--)
        {            
            for (int i = 0; i < j; i++)
            {
                if (matrix[k,i] < matrix[k,i + 1])\\
                {
                    temp = matrix[k,i];
                    matrix[k,i] = matrix[k,i + 1];
                    matrix[k,i + 1] = temp;                    
                }
            }                        
        }
    }
}



int rows = readInt("Введите кол-во строк ");
int colums = readInt("Введите кол-во столбцов ");
int [,] matrix = initMatrix(rows, colums);
printMatrix(matrix);
bubbleMethod(matrix);
printMatrix(matrix);
