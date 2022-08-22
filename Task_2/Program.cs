/* Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/
Console.WriteLine("Введите число 1: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число 2: ");
int number2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Вы ввели число 1: "+number1+" и число 2: "+number2);
if(number1 > number2)
{
    Console.WriteLine(number1+" > "+number2);
}
else
{
    Console.WriteLine(+number2+" > "+number1);
}

