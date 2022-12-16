// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int[] Array = new int [8];
Random rand = new Random();

for (int i = 0; i < Array.Length; i++) {
    Array[i] = rand.Next(150);
   Console.Write(Array[i] + ", ");
}
Console.WriteLine();
