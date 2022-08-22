/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/

double pow(int num = 2, int degree = 2)
{
    double numb = 1;
    for (int i = 0; i != degree; i++) numb*=num;
    return numb;
}

int terms(int numbers = 1234)
{
    string gap = numbers.ToString();
    int size = gap.Length;
    int summ = 0;
    for (int i = 0; i < size; i++) 
    {
        int pars = Int32.Parse(gap[i].ToString());
        summ = pars + summ;
    }
return summ;    
}

string array(int sise = 8, int minValue = 0, int maxValue = 100)
{
    int[] array = new int[sise];
    for (int i = 0; i < sise; i++)
    {
        array[i] = new Random().Next(minValue, maxValue);
    }
    var str = "[" + String.Join(", ", array) + "]";

    return str;
}

void requestArray(int size = 3)
{
    string[] str ={"Введите размер массива: ", "Введите минемальное значение массива: ", "Введите максимальное значение массива: "};
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
    {
        Console.Write(str[i]);
        int prot = protections();
        if ( prot != 999999999) arr[i] = prot;//int.Parse(Console.ReadLine());
        else Console.WriteLine("Введено не допустимое значение!");
    }
    Console.WriteLine(array(arr[0], arr[1], arr[2]));
}

int protections()
{
    Console.Write("Введите значение: ");
    if (int.TryParse(Console.ReadLine(), out int number));
    else number = 999999999;
    return number;
}

void requestTerms()
{
    Console.Write("Введите значение сумму элементов которого хотите получить: ");
    int req = protections();
    if (req != 999999999) Console.WriteLine(terms(req));
    else Console.WriteLine("Вы ввели не корректоное значение!");
}

void requestPow()
{
    Console.Write("Введите основание степени: ");
    int num = protections();
    Console.Write("Введите степень: ");
    int deg = protections();
    if (num != 999999999 && deg != 999999999) Console.WriteLine($"{num} в степене {deg} равно {pow(num, deg)}");
    else Console.WriteLine("Введены не допустимые значения!");
}

void menu()
{    
    string paragraph = String.Empty;
    while (paragraph != "1" || paragraph != "2" || paragraph != "3")
    {
        Console.WriteLine("===========================================");
        Console.WriteLine("Введите 1 для перехода к задаче 25: ");
        Console.WriteLine("Введите 2 для перехода к задаче 27: ");
        Console.WriteLine("Введите 3 для перехода к задаче 29: ");
        Console.WriteLine("Введите 0 для выхода из программы: ");
        Console.WriteLine("===========================================");
        paragraph = Console.ReadLine();
        if (paragraph == "1") requestPow();
        if (paragraph == "2") requestTerms();
        if (paragraph == "3") requestArray();
        if (paragraph == "0") break;
    }
}
menu();