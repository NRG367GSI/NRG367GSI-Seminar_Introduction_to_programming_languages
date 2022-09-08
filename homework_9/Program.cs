/*
Все задачи выполнить без циклов, исключительно с помощью рекурсии
Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке
от M до N.
M = 1; N = 5. -> ""1, 2, 3, 4, 5""
M = 4; N = 8. -> ""4, 6, 7, 8""

Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов
в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30

Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных
числа m и n.
m = 2, n = 3 -> A(m,n) = 29
*/

string NaturalNumber(int firstNumber, int secondNumber)
{
    if (firstNumber <= secondNumber) return $" {firstNumber++} " + NaturalNumber(firstNumber, secondNumber);
    else return string.Empty;
}

int NaturalSumm(int firstNumber, int secondNumber)
{
    if (firstNumber < secondNumber) return secondNumber + NaturalSumm(firstNumber, secondNumber - 1);
    else return secondNumber;
}

//В задании ошибка, что б получить проверочное значение m = 3, n = 2
int FuncAkkermana(int m, int n)
{
    if (m == 0) return n + 1;
    else if ( n == 0) return FuncAkkermana(m - 1, 1);
    else return FuncAkkermana(m - 1, FuncAkkermana(m, n - 1));
}
