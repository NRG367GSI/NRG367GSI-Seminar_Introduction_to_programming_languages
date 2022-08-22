/*
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет,
является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/
string[] array = {"!", "нет", "нет", "нет","нет", "нет", "да", "да"};
Console.Write("Введите номер дня недели:");
string dayNumber = Console.ReadLine();
bool can = Int32.TryParse(dayNumber, out int dayNumberTrue);
if (can != true) Console.WriteLine("Вы ввели не число!");
else
{
    if (dayNumberTrue < 1 || dayNumberTrue > 7) Console.WriteLine("Такого дня недели нет!");

    else
    {
        string youCanRelax = array[dayNumberTrue];
        Console.WriteLine(youCanRelax);
    }
}



