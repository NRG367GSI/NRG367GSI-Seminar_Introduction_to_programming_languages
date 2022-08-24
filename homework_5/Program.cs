/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных
чисел в массиве.
[345, 897, 568, 234] -> 2

Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0

Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/

int protections() //принемает значение и преабразует его в целочисленное значени или выдает значение ошибки
{
    Console.Write("Введите значение: ");
    if (int.TryParse(Console.ReadLine(), out int number));
    else number = 999999999;
    return number;
}

int[] array(int size = 10, int min = 10, int max = 10) //Создает массив и заполняет его случайными значениями
{
    int[] array = new int[size];
    
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max);

    }
    return array;

}

void Task_34(int size = 10, int min = 100, int max = 1000) //Принемает размер массива и диапазон значений и выводит колличество четных элементрв массива
{
    int[] arr = array(size, min, max);
    int even = 0;
    for (int i = 0; i < size; i++)
    {
        if (arr[i] % 2 == 0)
        {
            even++;
        }
    }
    var strArr = "[ " + String.Join(", ", arr) + " ]";
    Console.WriteLine($"Массив: {strArr}");
    Console.WriteLine($"Колличество четных элементов массива: {even}");
}

void Task_36(int size = 999999999, int min = 999999999, int max = 999999999) //Задает массив заполненный случайными значениями и находит сумму четных пазиций
{
    while (size == 999999999 || min == 999999999 || max == 999999999 || size <= 0 || min > max)
    {
        Console.Write("Введите размер массива: ");
        size = protections();

        Console.Write("Введите min массива: ");
        min = protections();

        Console.Write("Введите max массива: ");
        max = protections();
        if (size == 999999999 || min == 999999999 || max == 999999999 || size <= 0 || min > max) Console.WriteLine("Вы ввели не корректное значение, повторите ввод: ");
    }
    int summ = 0;
    int[] arr = array(size, min, max);
    for (int i = 0; i < size; i++)
    {
        if ( i % 2 != 0)
        {
            summ = summ +arr[i];
        }
    }
    var str = "[" + String.Join(", ", arr) + "]";
    Console.WriteLine($"{str}, сумма элементов массива с нечетным индексом: {summ}");
}

void Task_38(int size = 10, int min = -10, int max = 10) //Задает массив вещественных чисел. Находит разницу между максимальным и минимальным элементов массива
{
    double[] array = new double[size];
    double minNum = 0;
    double maxNum = 0;
    for (int i = 0; i < size; i++) 
    {
        array[i] = Math.Round(new Random().Next(min, max) + new Random().NextDouble(), 2);
        if (minNum > array[i]) minNum = array[i];
        if (maxNum < array[i]) maxNum = array[i];
    }
    var strArr = String.Join(", ", array);
    Console.WriteLine($"Массив: {strArr}");
    Console.WriteLine($"min = {minNum:f2}, max = {maxNum:f2}, max - min = {maxNum - minNum:f2}");
}

void menu() //Вызывает заданные методы
{    
    string paragraph = String.Empty;
    while (paragraph == "0" || paragraph != "1" || paragraph != "2" || paragraph != "3" )
    {
        Console.WriteLine("===========================================");
        Console.WriteLine("Введите 1 для перехода к задаче 1: ");
        Console.WriteLine("Введите 2 для перехода к задаче 2: ");
        Console.WriteLine("Введите 3 для перехода к задаче 3: ");
        Console.WriteLine("Введите 0 для выхода из программы: ");
        Console.WriteLine("===========================================");
        paragraph = Console.ReadLine();
        if (paragraph == "1") Task_34();
        if (paragraph == "2") Task_36();
        if (paragraph == "3") Task_38();
        if (paragraph == "0") break;
    }
}

menu();


