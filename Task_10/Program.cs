/*
Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/
Console.Write("Введите трехзначное число: ");
string number = Console.ReadLine();
int size = number.Length;

if ( size != 3) Console.WriteLine("Вы ввели не трехзначное значение!");

else
{   
    string value = Convert.ToString(number[1]);
    bool result = Int32.TryParse(value, out int can);
    if (result == true) Console.WriteLine("Второе число, введенного числа: " + can);
    else Console.WriteLine("Вы ввели не число!");
}



