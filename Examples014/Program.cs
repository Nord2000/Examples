// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

int[] array = new int [100];
Random rand = new Random();
int count = 0;

for (int i = 0; i < array.Length; i++) {
    array[i] = rand.Next(100,1000);
   if (array[i] % 2 == 0 || array[i] % 4 == 0 || array[i] % 6 == 0 || array[i] % 2 == 8  ) {
        count++;
        }
    Console.Write(array[i] + ", ");   
}   
Console.WriteLine();
Console.WriteLine(count);

