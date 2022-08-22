/* Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> нет
*/

Console.Write("Введите число, для определения его четности: ");
float number = float.Parse(Console.ReadLine());

 float action = number % 2;
 if(action == 0) Console.WriteLine("Введенное число, четное: "+number);
 else Console.WriteLine("Введенное число, не четное: "+number);

