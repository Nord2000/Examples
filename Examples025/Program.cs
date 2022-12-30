// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
//Массив размером 2 x 2 x 2

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

int[,,] initMatrix(int rows, int columns, int plane)
{
    int[,,] matrix = new int [rows,columns,plane];
    Random rnd = new Random();
    
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int p = 0; p < matrix.GetLength(2); p++)
            {
                matrix[i,j,p] = rnd.Next(10, 99);
            }
        }        
    }
    return matrix;
}

void printMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int p = 0; p < matrix.GetLength(2); p++)
            {
                Console.Write($"{matrix[i, j, p] }({i},{j},{p})|");
            }
            Console.WriteLine();
        }        
    }
}

int rows = readInt("Введите кол-во строк трёхмерной матрицы ");
int columns = readInt("Введите кол-во столбцов трёхмерной матрицы ");
int plane = readInt("Введите кол-во  трёхмерной матрицы ");
int [,,] matrix = initMatrix(rows, columns, plane);
printMatrix(matrix);