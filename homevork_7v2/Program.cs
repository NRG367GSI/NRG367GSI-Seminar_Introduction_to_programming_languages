// Черновик домашней работы версия 2

int GetNumber() //РЕКУРСИВНО Запрашивает значение пока не будит введено целое число
{
    Console.Write("Введите целое число: ");
    if (!int.TryParse(Console.ReadLine(), out int number))
    {
        Console.WriteLine("Вы ввели не допустимое значение, повторите ввод: ");
        GetNumber();
    }
    return number;
}

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

void MatrixOutput(double[,] matrix) //Выводит целочисленную матрицу
{
    Console.Clear();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i,j] < 0) Console.SetCursorPosition(i * 10, j);
            else Console.SetCursorPosition(1 + i * 10, j);
            Console.Write(matrix[i, j]);
        }
    }
}

void MatrixIntOutput(int[,] matrix) //Выводит целочисленную матрицу
{
    Console.Clear();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i,j] < 0) Console.SetCursorPosition(i * 10, j);
            else Console.SetCursorPosition(1 + i * 10, j);
            Console.Write(matrix[i, j]);
        }
    }
    Console.WriteLine();
}

double[,] MatrixReal() //Двумерный массив, заполненный случайными вещественными числами
{
    Console.Write("Введите число строк матрици: ");
    int rows = Math.Abs(GetANinteger());
    Console.Write("Введите число столбцов матрици: ");
    int columns = Math.Abs(GetANinteger());

    double[,] matrix = new double[rows, columns];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j =0; j < matrix.GetLength(1); j++)
        {
            matrix[i ,j] = Math.Round(new Random().NextDouble(), 2);
        }
    }
    return matrix;
}

int[,] Matrix(int min = -10, int max = 10) //Двумерный массив, заполненный случайными вещественными числами
{
    Console.Write("Введите число строк матрици: ");
    int rows = Math.Abs(GetNumber());
    Console.Write("Введите число столбцов матрици: ");
    int columns = Math.Abs(GetNumber());

    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j =0; j < matrix.GetLength(1); j++)
        {
            matrix[i ,j] = new Random().Next(min, max);
        }
    }
    return matrix;
}

void NumberSearch(int[,] matrix)
{
    int number = GetNumber();
    
    int[,] indexMatrix = new int[matrix.GetLength(0) * matrix.GetLength(1) + 1, 2];
    int index = 0;
    
    for (int i = 0; i < matrix.GetLength(i); i++)
    {
        for (int j = 0; j < matrix.GetLength(j); j++)
        {
            if (number == matrix[i, j])
            {
                indexMatrix[index, 0] = i;
                indexMatrix[index, 1] = j;
                index++;
            }
        }
    }
    MatrixIntOutput(matrix);
    MatrixIntOutput(indexMatrix);
}

// не доделано решил потом вернуться

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}
int m = 6;
int n = 6;
int[,] array = new int[m, n];

FillArray(array);
PrintArray(array);
Console.WriteLine();

int x = 0;
int y = 0;
int min = array[0, 0];
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        if (array[i, j] < min)
        {
            min = array[i, j];
            x = i;
            y = j;
        }
    }
}
Console.WriteLine("Наименьший элемент: " + min);

int Factorial(int n)
{
    if (n < 10)
    {
        n ++;
        Factorial(n);
    }
    return n;
}

