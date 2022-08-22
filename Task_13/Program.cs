/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

Console.Write("Введите трехзначное число: ");
string number = Console.ReadLine();
int size = number.Length;

if ( size < 3) Console.WriteLine("Третьей цифры нет!");

else
{   
    string value = Convert.ToString(number[2]);
    bool result = Int32.TryParse(value, out int can);
    if (result == true) Console.WriteLine("Третье число, введенного числа: " + can);
    else Console.WriteLine("Вы ввели не число!");
}
