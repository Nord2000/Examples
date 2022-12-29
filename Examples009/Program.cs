// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

Console.WriteLine("Введите координаты точек x1,y1,z1 и x2,y2,z2 (Через Enter)");

int x1 = int.Parse(Console.ReadLine());
int y1 = int.Parse(Console.ReadLine());
int z1 = int.Parse(Console.ReadLine());
int x2 = int.Parse(Console.ReadLine());
int y2 = int.Parse(Console.ReadLine());
int z2 = int.Parse(Console.ReadLine());

double distance (int x1, int y1, int z1, int x2, int y2, int z2){

    double result = 0;
    result = Math.Sqrt(Math.Pow((x2 - x1),2) + Math.Pow((y2 - y1),2) + Math.Pow((z2 - z1),2));
    return result;
}
Console.WriteLine ($"Расстояние между точками = {distance (x1,y1,z1,x2,y2,z2)}");