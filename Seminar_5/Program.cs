/*
Задача 1: Задайте массив из 10 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму 
отрицательных и положительных элементов массива.
Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных 
равна -20.
Задача 2: Задайте массив из 10 элементов и положительные элементы замените на соответствующие отрицательные, 
и наоборот.
[-4, -8, 8, 2] -> [4, 8, -8, -2]


void summRandom()
{
    int[] arr = new int[10];
    int summPositive = 0;
    int summNopos = 0;
    for (int i = 0; i < arr.Length - 1; i++)
    {
        
        arr[i] = new Random().Next(-9, 10);
        Console.Write(arr[i]);
        if (arr[i] < 0) summPositive = summPositive + arr[i];
        if (arr[i] > 0) summNopos = summNopos + arr[i];
    }
    Console.WriteLine("\n");
    Console.WriteLine(summPositive);
    Console.WriteLine(summNopos);
}

void reRandom()
{
    int[] arr = new int[10];
    int summPositive = 0;
    int summNopos = 0;
    for (int i = 0; i < arr.Length - 1; i++)
    {
        
        arr[i] = new Random().Next(-9, 10);
        if (arr[i] < 0) arr[i] =  arr[i] * -1;
        if (arr[i] > 0) arr[i] =  arr[i] * -1;
    }

    
    Console.WriteLine(summPositive);
    Console.WriteLine(summNopos);
}


Задача 3: Задайте массив из 8 случайных чисел. Напишите программу, которая определяет, присутствует ли
заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет
3; массив [6, 7, 19, 345, 3] -> да

Задача 4: Задайте одномерный массив из 12 случайных чисел. Найдите количество элементов массива,
значения которых лежат в отрезке [10,99].
*Пример для массива из 5, а не 12 элементов. В своём решении сделайте для 12*
[5, 18, 123, 6, 2] -> 1
[1, 2, 3, 6, 2] -> 0
[10, 11, 12, 13, 14] -> 5
*/

int[] arr = new int[8];
Console.WriteLine("Введите искомое число");
int number = int.Parse(Console.ReadLine());
for (int i = 0; i < arr.Length - 1; i++)
{
        
    arr[i] = new Random().Next(-9, 10);
    Console.Write(arr[i]);
}

for ( int i = 0; i < arr.Length; i++)
{
    if (number == arr[i]) Console.WriteLine("ДА");

    else Console.WriteLine("НЕТ");
        break;
}