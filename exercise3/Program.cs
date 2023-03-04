//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
//и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет

Console.WriteLine("Введите число от 1 до 7: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num >= 1 && num <= 5)
{
    Console.WriteLine($"{num} - Рабочий день недели");
}
else if (num >= 6 && num <= 7)
{
    Console.WriteLine($"{num} - Выходной день недели");
}
else Console.WriteLine($"{num} - Число не является днем недели");