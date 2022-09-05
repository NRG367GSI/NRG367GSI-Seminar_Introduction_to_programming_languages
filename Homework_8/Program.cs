
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

int[,] MultiplekationMatrix(int[,] firstMatrix, int[,] secondMatrix) //Умножение матриц
{
    int[,] mult = new int[firstMatrix.GetLength(0), secondMatrix.GetLength(1)];
 
    for (int i = 0; i < firstMatrix.GetLength(0); ++i)
        for (int j = 0; j < secondMatrix.GetLength(0); ++j)
            for (int k = 0; k < secondMatrix.GetLength(1); ++k)
                mult[i, k] += firstMatrix[i, j] * secondMatrix[j, k];
            return mult;
}

int[,,] Sequence(int width = 2, int height = 2, int depth = 2, int fromNumber = 10, int toNumber = 100) //Задает  трехмерный массив
{
    int unique = 0;
    int[,,] seq = new int[width, height, depth];

    for (int i =0; i < width; i++)
    {
        for (int j = 0; j < height; j++)
        {
            for (int k = 0; k < depth; k++)
            {
                foreach (int l in seq)
                {
                    while (l == unique)
                    {
                        unique = new Random().Next(fromNumber, toNumber);
                        seq[i,j,k] = unique;
                    }
                }
            }
        }
    }
    return seq;
}
   
void OutputArray(int[,,] arr) //Выводит в консоль трехмерный массив
{
    for (int i =0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {  
                Console.Write($" {arr[i,j,k]} ({i}, {j}, {k})  ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
} 

void Menu() //Вызывает методы
{    
    string paragraph = String.Empty;
    while (paragraph != "1" || paragraph != "2" || paragraph != "3"|| paragraph != "4"|| paragraph != "0")
    {
        Console.WriteLine();
        Console.WriteLine("===========================================");
        Console.WriteLine("Введите 1 для перехода к задаче 54: ");
        Console.WriteLine("Введите 2 для перехода к задаче 56: ");
        Console.WriteLine("Введите 3 для перехода к задаче 58: ");
        Console.WriteLine("Введите 4 для перехода к задаче 60: ");
        Console.WriteLine("Введите 0 для выхода из программы: ");
        Console.WriteLine("===========================================");
        paragraph = Console.ReadLine();
        if (paragraph == "1") MatrixIntOutput(SortingRows(FillMatrix(10, 5)));
        if (paragraph == "2") MinSummRows(FillMatrix(10,15));
        if (paragraph == "3") MatrixIntOutput(MultiplekationMatrix(FillMatrix(), FillMatrix()));
        if (paragraph == "4") OutputArray(Sequence());
        if (paragraph == "0") break;
        Console.WriteLine("Нажмите Enter для выхода в меню: ");
        Console.ReadLine();
    }
}

Menu();