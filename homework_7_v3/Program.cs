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

int GetANinteger() //Запрашивает значение пока не будит введено целое число
{
    int number = 0;
    bool protection = false;
    while (protection != true)
    {
        Console.Write("Введите целое число: ");
        protection = int.TryParse(Console.ReadLine(), out number);
        if (protection != true) Console.WriteLine("Вы ввели не допустимое значение, повторите ввод: ");
    }
    return number;
}

int[,] MatrixInt(int min = 0, int max = 10) //Получаем матрицу целых чисел
{
    Console.Write("Введите число строк матрици: ");
    int rows = Math.Abs(GetANinteger());
    Console.Write("Введите число столбцов матрици: ");
    int columns = Math.Abs(GetANinteger());

    int[,]  matrix = new int[rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i,j] = new Random().Next(min, max);
        }
    }
    return matrix;
}

double[,] MatrixReal() //Получаем матрицу вещественных чисел
{
    Console.Write("Введите число строк матрици: ");
    int rows = Math.Abs(GetANinteger());
    Console.Write("Введите число столбцов матрици: ");
    int columns = Math.Abs(GetANinteger());

    double[,]  matrix = new double[rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i,j] = Math.Round(new Random().NextDouble(), 2);
        }
    }
    return matrix;
}

void MatrixOutputReal(double[,] matrix) //Выводит в консоль матрицу вещественных чисел
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            string str = string.Join(" ", matrix[i, j], "   ");
            Console.Write(str);
        }
        Console.WriteLine();
    }
}

void MatrixOutput(int[,] matrix) //Выводит в консоль матрицу целых чисел
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            string str = string.Join(" ", matrix[i, j], "   ");
            Console.Write(str);
        }
        Console.WriteLine();
    }
}

void NumberSearch(int[,] matrix) //поиск числа в матрице и вывод в косоль матрицу индексов, искомого числа
{
    Console.WriteLine("Введите искомое число: ");
    int number = GetANinteger();
    int[,] matrixIndex = new int[matrix.GetLength(0) * matrix.GetLength(1), 2];
    int index = 0;
    MatrixOutput(matrix);
    for (int i =0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i,j] == number)
            {
                matrixIndex[index, 0] = i;
                matrixIndex[index, 1] = j;
                index++;
            }
            
        }
    }
    if (index == 0) Console.WriteLine("Искомое число не найдено!");
    else
    {
        int[,] matrixResult = new int[index, 2];
    for (int k =0; k < index; k++)
    {
        for (int l = 0; l < matrixIndex.GetLength(1); l++)
        {
            matrixResult[k,l] = matrixIndex[k,l];   
        }
    }
    Console.WriteLine($"Искомое число {number} найдено {index} раз и находится в следующих координатах: ");
    MatrixOutput(matrixResult);
    }
}

void Average(int[,] matrix) //Находит среднее арифметическое элементов в каждом столбце
{
    Console.Clear();
    MatrixOutput(matrix);
    double[] arrayAverage = new double[matrix.GetLength(1)];
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        double summ = 0;
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            summ += matrix[j,i];
            arrayAverage[i] = Math.Round(summ/matrix.GetLength(0), 2);
        }
    }
    Console.WriteLine($"Среднее арифметическое столбцов матрици: ");
    foreach (double average in arrayAverage)
    {
        Console.Write($" {average} ");
    } 
    Console.WriteLine();
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
        if (paragraph == "1") MatrixOutputReal(MatrixReal());
        if (paragraph == "2") NumberSearch(MatrixInt());
        if (paragraph == "3") Average(MatrixInt());
        if (paragraph == "0") break;
        Console.WriteLine("Нажмите Enter для выхода в меню: ");
        Console.ReadLine();
    }
}

Menu();