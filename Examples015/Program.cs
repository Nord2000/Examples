// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

int[] Array = new int [6];
Random rand = new Random();
int sum = 0;

for (int i = 0; i < Array.Length; i++) {
    Array[i] = rand.Next(-15, 15);

        if (i % 2 == 1) {
            sum = sum + Array[i];
        }
        Console.Write(Array[i] + ", ");
}
Console.WriteLine();
Console.WriteLine(sum);







