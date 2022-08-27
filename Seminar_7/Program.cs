/*
Задача 1: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на
экран.
m = 3, n = 4.
0 1 2 3
1 2 3 4
2 3 4 5

Задача 2: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
Например, изначально массив выглядел вот так:
1 4 7 2
5 9 2 3
8 4 2 4
Новый массив будет выглядеть вот так:
1 4 7 2
5 81 2 9
8 4 2 4
*/

int getANinteger() //Запрашивает значение пока не будит введено целое число
{
    int number = 0;
    bool prot = false;
    while (prot != true)
    {
        Console.Write("Введите целое число: ");
        prot = int.TryParse(Console.ReadLine(), out number);
        if (prot != true) Console.WriteLine("Вы ввели не допустимое значение, повторите ввод: ");
    }
    return number;
}

void matrixIntOutput(int[,] matrix)
{
    Console.Clear();
    for (int i =0; i < matrix.GetLength(0); i++)
    {
        for (int j =0; j < matrix.GetLength(1); j++)
        {
            int sizeNumber = Convert.ToString(matrix[i,j]).Length;
            Console.SetCursorPosition(i*10,j);
            
            Console.Write(matrix[i,j]);
        }

    }
}

int[,] getSumIndex() //Двумерный массив, каждый элемент в массиве находится по формуле: Aₘₙ = m+n.
{
    Console.Write("Введите число строк матрици: ");
    int rows = Math.Abs(getANinteger());
    Console.Write("Введите число столбцов матрици: ");
    int columns = Math.Abs(getANinteger());

    
    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j =0; j < matrix.GetLength(1); j++)
        {
            matrix[i ,j] = i + j;
        }
    }
    return matrix;
}

int[,] matrixPowNum() //Двумерный массив, элементы, у которых оба индекса чётные, заменяет эти элементы на их квадраты
{
    int[,] matrix = getSumIndex();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j =0; j < matrix.GetLength(1); j++)
        {
            if ( i % 2 == 0 && j % 2 == 0) matrix[i, j] = matrix[i, j] * matrix[i, j];
        }
    }
    return matrix;
}

void menu() //Вызывает методы
{    
    string paragraph = String.Empty;
    while (paragraph != "1" || paragraph != "2" || paragraph != "0")
    {
        Console.WriteLine();
        Console.WriteLine("===========================================");
        Console.WriteLine("Введите 1 для перехода к задаче 1: ");
        Console.WriteLine("Введите 2 для перехода к задаче 2: ");
        Console.WriteLine("Введите 0 для выхода из программы: ");
        Console.WriteLine("===========================================");
        paragraph = Console.ReadLine();
        if (paragraph == "1") matrixIntOutput(getSumIndex());
        if (paragraph == "2") matrixIntOutput(matrixPowNum());
        if (paragraph == "0") break;
    }
}

menu();