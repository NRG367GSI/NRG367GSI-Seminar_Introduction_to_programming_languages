/*
Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9

Задача 50. Напишите программу, которая на вход принимает число, и возвращает индексы этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет

Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

int protection() //Запрашивает значение пока не будит введено целое число
{
    int number = 0;
    bool prot = false;
    while (prot == false)
    {
        Console.Write("Введите значение: ");
        prot = int.TryParse(Console.ReadLine(), out number);
        if (prot == false) Console.WriteLine("Вы ввели не допустимое значение, повторите ввод: ");
    }
    return number;
}

void matrixMxN(int min = -9, int max = 9) //Двумерный массив, заполненный случайными вещественными числами
{
    Console.Write("Введите число строк матрици: ");
    int rows = Math.Abs(protection());
    Console.Write("Введите число столбцов матрици: ");
    int columns = Math.Abs(protection());

    double summ = 0;
    double[,] matrix = new double[rows, columns];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j =0; j < matrix.GetLength(1); j++)
        {
            matrix[i ,j] = Math.Round(new Random().Next(min, max) + new Random().NextDouble(), 2);
            Console.Write($" {matrix[i,j]} ");
        }
    Console.WriteLine();
    }
}

void numberSearch(int min = -10, int max = 10) //Поиск индексов заданного числа в заданной матрице со случайными числами
{
    Console.Write("Введите число строк матрици: ");
    int rows = Math.Abs(protection());
    Console.Write("Введите число столбцов матрици: ");
    int columns = Math.Abs(protection());
    Console.Write("Введите искомое значение: ");
    int num = protection();

    int size = 0;
    int count = 0;
    int[,] matrixIndex = new int[rows * columns + 1, 2];
    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j =0; j < matrix.GetLength(1); j++)
        {
            matrix[i ,j] = new Random().Next(min, max);
            if (num == matrix[i,j])
            {
                matrixIndex[count, 0] = i;
                matrixIndex[count, 1] = j;
                count++;
                size++;
                Console.Write($" [{matrix[i,j]}]  ");
            }
            else 
            {
                matrixIndex[count, 0] = -1;
                matrixIndex[count, 1] = -1;
                Console.Write($" {matrix[i,j]}  ");
                count ++;
            }
        }
    Console.WriteLine();
    }
    int index = -1;
    int[,] result = new int[size, 2];
    Console.WriteLine($"Искомое число {num} находится в следующих координатах: ");
    for (int k = 0; k < rows * columns; k++)
    {
        if (matrixIndex[k,0] != -1)
        {
            index++;
            result[index, 0] = matrixIndex[k, 0];
            result[index, 1] = matrixIndex[k, 1];
            Console.WriteLine($"{index + 1} | {result[index, 0]}, {result[index, 1]}");
            Console.WriteLine();
        }
    }
    if (index == -1) Console.WriteLine($"Искомого числа {num} в заданном массиве нет!");
}

void average(int min = 0, int max = 10)
{
    Console.Write("Введите число строк матрици: ");
    int rows = Math.Abs(protection());
    Console.Write("Введите число столбцов матрици: ");
    int columns = Math.Abs(protection());

    int[,] matrix = new int[rows, columns];
    int[,] matrix2 = new int[columns, rows];
    

    for (int i = 0; i < rows; i++)
    {
        //double summ =0;
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = new Random().Next(min, max);
            Console.Write($"  {matrix[i,j]}   ");
            //summ += matrix[i, j];
            //array[i] = summ/columns;

        }
        
        Console.WriteLine();
    }
    Console.WriteLine($"=============================================");
    //foreach (double k in array) Console.Write($" {Math.Round(k, 2)} ");


for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix2[j, i] = matrix[i,j];
        }
    }
    for (int i = 0; i < rows; i++)
    {

        for (int j = 0; j < columns; j++)
        {
            
            Console.Write($"  {matrix2[i,j]}   ");
        }
        
        Console.WriteLine();
    }
}

void Menu() //Вызывает методы
{    
    string paragraph = String.Empty;
    while (paragraph != "1" || paragraph != "2" || paragraph != "3"|| paragraph != "0")
    {
        Console.WriteLine();
        Console.WriteLine("===========================================");
        Console.WriteLine("Введите 1 для перехода к задаче 47: ");
        Console.WriteLine("Введите 2 для перехода к задаче 50: ");
        Console.WriteLine("Введите 3 для перехода к задаче 52: ");
        Console.WriteLine("Введите 0 для выхода из программы: ");
        Console.WriteLine("===========================================");
        paragraph = Console.ReadLine();
        if (paragraph == "1") matrixMxN();
        if (paragraph == "2") numberSearch();
        if (paragraph == "3") average();
        if (paragraph == "0") break;
    }
}

Menu();