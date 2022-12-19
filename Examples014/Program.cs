// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

int[] Array = new int [100];
Random rand = new Random();
int count = 0;

for (int i = 0; i < Array.Length; i++) {
    Array[i] = rand.Next(100,1000);
   if (Array[i] % 2 == 0 || Array[i] % 4 == 0 || Array[i] % 6 == 0 || Array[i] % 2 == 8  ) {
        count++;
        }
    Console.Write(Array[i] + ", ");   
}   
Console.WriteLine();
Console.WriteLine(count);

