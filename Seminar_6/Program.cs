/*
Задача 1. Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.). 
Элементы двумерного массива задаются случано и лежат в промежутке от -10 до 10
[1 2 3 4 5] -> [5 4 3 2 1]
[6 7 3 6] -> [6 3 7 6]

Задача 2. Вычислить среднее арифметическое положительных элементов в одномерном массиве. 
Элементы массива задаются случано и лежат в промежутке от -10 до 10
[1, -5, 8, 4, -9] -> 4.33
*/
int[] array(int size = 10, int min = -10, int max = 11) //Создает массив и заполняет его случайными целочисленными значениями
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max);

    }
    return array;
}

void avarage(int size = 10, int min = -10, int max = 11) //среднее арифметическое положительных элементов
{
    int[] arr = array(size, min, max);
    double count = 0;
    double summ = 0;
    for (int i = 0; i < size; i++)
    {
        if (arr[i] > 0)
        {
            summ += arr[i];
            count++;
        }
    }
    double result = summ / count;
    var str = "[" + String.Join(", ", arr) + "]";
    Console.WriteLine($"массив{str},сумма: {summ} количество положительных чисел {count} результат: {result:f2}");
}

void reversArray(int size = 10, int min = -10, int max = 11) //Поворот массива
{
int[] arr = array(size, min, max);
Console.WriteLine("[" + String.Join(", ", arr) + "]");
for (int i = 0; i < size/2; i++ )
{
     int a = arr[i];
     arr[i] = arr[size-1-i];
     arr[size-1-i] = a;
}
var str = "[" + String.Join(", ", arr) + "]";
Console.WriteLine(str);
}

void menu() //Вызывает методы
{    
    string paragraph = String.Empty;
    while (paragraph != "1" || paragraph != "2" || paragraph != "0")
    {
        Console.WriteLine("===========================================");
        Console.WriteLine("Введите 1 для перехода к задаче 1: ");
        Console.WriteLine("Введите 2 для перехода к задаче 2: ");
        Console.WriteLine("Введите 0 для выхода из программы: ");
        Console.WriteLine("===========================================");
        paragraph = Console.ReadLine();
        if (paragraph == "1") reversArray();
        if (paragraph == "2") avarage();
        if (paragraph == "0") break;
    }
}

menu();