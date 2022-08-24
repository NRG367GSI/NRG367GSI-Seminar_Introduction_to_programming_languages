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

int protections() //принемает значение и преабразует его в целочисленное значени или выдает предупреждение
{
    Console.Write("Введите значение: ");
    if (int.TryParse(Console.ReadLine(), out int number));
    else number = 999999999;
    return number;
}

int[] array(int size = 10, int min = 100, int max = 1000) //Создает массив и заполняет его случайными целочисленными значениями
{
    int[] array = new int[size];
    
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max);

    }
    return array;

}

int Task_34(int[] array) // Принемает массив и выводит колличество четных элементрв массива
{
    int size = array.Length;
    int even = 0;
    for (int i = 0; i < size; i++)
    {
        int a = array[i];
        if (a % 2 == 0)
        {
            even++;
        }
    }
    return even;
}
//Console.WriteLine(Task_34(array()));

void Task_36(int size = 999999999, int min = 999999999, int max = 999999999)
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
    Console.Write($"{str}, сумма элементов массива с нечетным индексом: {summ}");
}
//Task_36();

void Task_38()
{
    
}






