// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// 1. Считать размерность массива NxM; 
// 2. Считать элементы массива;(Заполняем матрицу)
// 3. Ср.ар столбцов массива;

int readInt(string prompt)
{
    Console.WriteLine(prompt);
    return int.Parse(Console.ReadLine()); 
}

int N = readInt("Введите кол-во строк N = ");
int M = readInt("Введите кол-во столбцов M = ");


int [,] matrix = new int [N,M];
Random random = new Random();

for (int i = 0; i < N; i++)
{
    for (int j = 0; j < M; j++)
    {
        matrix [i,j] = random.Next(100);
    }
}
Console.WriteLine();

for (int j = 0; j < M; j++)
{
    double sum = 0;
    for (int i = 0; i < N; i++)
    {
        sum += matrix[i, j];
    }
    Console.Write($"{Math.Round(sum / N, 2)}|");    
}



