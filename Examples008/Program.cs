// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.


 string count = Console.ReadLine();
 char[] reCount = count.ToCharArray();

Array.Reverse(reCount);
string finCount = new string(reCount);

if (count == finCount){
    Console.WriteLine ("Да");
} if (count != finCount) {
    Console.WriteLine ("Нет");
}