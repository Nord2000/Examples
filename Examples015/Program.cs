// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

int[] array = new int [6];
Random rand = new Random();
int sum = 0;

for (int i = 0; i < array.Length; i++) {
    array[i] = rand.Next(-15, 15);

        if (i % 2 == 1) {
            sum = sum + array[i];
        }
        Console.Write(array[i] + ", ");
}
Console.WriteLine();
Console.WriteLine(sum);







