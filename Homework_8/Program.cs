/*
Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
*/

int[,] FillMatrix(int rows = 3, int columns = 5, int min = -10, int max = 10) //Матрица заполненная случайными целыми значениями 
{
    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i,j] = new Random().Next(min, max);   
        }
    }
    return matrix;
}

void MatrixIntOutput(int[,] matrix) //Выводит матрецу в консоль
{
    Console.WriteLine("===========================================");
    if (matrix.GetLength(0) < 15 || matrix.GetLength(1) < 15)
    {
        //Console.Clear();
        for (int i =0; i < matrix.GetLength(0); i++)
        {
            for (int j =0; j < matrix.GetLength(1); j++)
            {   
                if (matrix[i,j] < 0)
                {
                    string str = string.Join(" ", matrix[i, j], "   ");
                    Console.Write(str);
                    //Console.SetCursorPosition(i*10, j);
                    //Console.Write(matrix[i,j]);
                }
                else
                {
                    string str = string.Join("  ", matrix[i, j], "   ");
                    Console.Write(str);
                    //Console.SetCursorPosition(i*10 +1, j);
                    //Console.Write(matrix[i,j]);
                }
            }
            Console.WriteLine();
        }
        
    }
    else
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
}

void SearchMax(int[,] matrix) //
{
    MatrixIntOutput(matrix);
    int max = matrix[0,0];
    int maxRows = 0;

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        if (max < matrix[i,0])
        {
            max = matrix[i,0];
            maxRows = i;
        }
    }
    matrix[maxRows,0] = matrix[0,0];
    matrix[0,0] = max;
    Console.WriteLine($"maxRows = {maxRows}, max = {max}, matrix[0,0] = {matrix[0,0]}, matrix[maxRows,0] = {matrix[maxRows,0]} ");
}

int[,] SortingColumns(int[,] matrix) //
{
    MatrixIntOutput(matrix);
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            int max = matrix[j,i];
            int maxColumns = j;
            for (int k = j; k < matrix.GetLength(0); k++)
            {
                if (max < matrix[k,i])
                {
                    max = matrix[k,i];
                    maxColumns = k;  
                }
                matrix[maxColumns,i] = matrix[j,i];
                matrix[j,i] = max;   
            }
        }
    }
    return matrix;
}

int[,] SortingRows(int[,] matrix) //Сортирует строки матреци по убыванию
{
    MatrixIntOutput(matrix);
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            int max = matrix[i,j];
            int maxRows = j;
            for (int k = j; k < matrix.GetLength(1); k++)
            {
                if (max < matrix[i,k])
                {
                    max = matrix[i,k];
                    maxRows = k;
                }
            }
            matrix[i, maxRows] = matrix[i,j];
            matrix[i,j] = max;
        }
    }
    return matrix;
}

//MatrixIntOutput(SortingRows(FillMatrix(10, 5)));

/*
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
*/

void MinSummRows(int[,] matrix) //Выводит минемальную сумму строк матрици
{
    int summ = 0;
    
    MatrixIntOutput(matrix);
    Console.WriteLine();
    int[] arraySumm = new int[matrix.GetLength(0) + 1];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            summ += matrix[i,j];
        }
        arraySumm[i] = summ;
    }
    int min = arraySumm[0];
    for (int k = 0; k < matrix.GetLength(0); k++)
    {
        if (min > arraySumm[k])
        {
            min = arraySumm[k];
            arraySumm[k + 1] = min;
        }
        Console.Write($" {arraySumm[k]}  ");
    }
    Console.WriteLine($"Минемальная сумма строк: {min}  ");
}

//MinSummRows(FillMatrix(10,15));

/*
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
*/

int[,] MultiplicationMatrix()
{
    int[,] firstMatrix = new int[3, 3] {{2, 4, 0},
                                        {3, 2, 0},
                                        {0, 0, 0}};

    int[,] secondMatrix = new int[3, 3] {{3, 4, 0},
                                        {3, 3, 0},
                                        {0, 0, 0}};
    
                    
    int[,] productMatrix = new int[3,3];

    for (int i = 0; i < 3; i++)
    {
        
        for (int j = 0; j < 3; j++)
        {
            
            for (int k = 0; k < 3; k++)
            {
                int summ = 0;
                for (int l = 0; l < 3; l++)
                {
                    summ += firstMatrix[j,i] * secondMatrix[l,k];
                    //Console.Write($"   {j}, {l}  &  {l}, {k}     =   {j} {k}|");
                }
                productMatrix[j,k] = summ;
                Console.WriteLine(summ);
            }
            Console.WriteLine();
            
        }
        Console.WriteLine();
    }
    Console.WriteLine();
    return productMatrix;
}

int[,] mult()
{
    int[,] ar1 = new int[3, 3] {{2, 4, 0},
                                        {3, 2, 0},
                                        {0, 0, 0}};

    int[,] ar2 = new int[3, 3] {{3, 4, 0},
                                        {3, 3, 0},
                                        {0, 0, 0}};
    int[,] m = new int[ar1.GetLength(0), ar2.GetLength(1)];
 
    for (int i = 0; i < ar1.GetLength(0); ++i)
        for (int j = 0; j < ar2.GetLength(0); ++j)
            for (int k = 0; k < ar2.GetLength(1); ++k)
                m[i, k] += ar1[i, j] * ar2[j, k];
            return m;
}
 
MatrixIntOutput(mult());