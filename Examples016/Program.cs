// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

int[] array = new int [6];
Random rand = new Random();

for (int i = 0; i < array.Length; i++) {
    array[i] = rand.Next(1, 30); 
    Console.Write(array[i] + ", ");
}
Console.WriteLine();

int max = array[0];
int min = array[0];
int difference = 0;


        for (int i = 0; i < array.Length; i++){
            if (min > array[i]) {
                min = array[i];
            }
            
        }

        for (int i = 0; i < array.Length; i++){
            if (max < array[i]) {
                max = array[i];
            }
            
        }
    difference = max - min;
Console.WriteLine ($"dif {difference}");


               
                               
            