/*Задача 15:
 Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
 и проверяет, является ли этот день выходным.*/

Console.Write("Введите цифру, от 1 до 7: ");
int num = int.Parse(Console.ReadLine());
if (num < 6) Console.WriteLine("Это не выходной день");
else 
{     
    if (num == 6) Console.WriteLine("Выходной день");
    if (num == 7) Console.WriteLine("Выходной день");
}
