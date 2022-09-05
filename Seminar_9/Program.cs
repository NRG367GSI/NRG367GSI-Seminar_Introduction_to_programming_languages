int GetANinteger() //Запрашивает значение пока не будит введено целое число
{
    int number = 0;
    bool prot = false;
    while (!prot)
    {
        Console.Write("Введите целое число: ");
        prot = int.TryParse(Console.ReadLine(), out number);
        if (!prot) Console.WriteLine("Вы ввели не допустимое значение, повторите ввод: ");
    }
    return number;
}

int[] Array(int[] array)
{
    int size = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            size ++;
        }
    }
    int[] even = new int[size];
    size = 0;
    for (int j = 0; j < array.Length; j++)
    {
        if (array[j] % 2 == 0)
        {
            even[size] = array[j];
            size++;
        }
    }
    return even;
}

void ArrayOtput(int[] array)
{
    for (int j = 0; j < array.Length; j++)
    Console.Write($" {array[j]} ");
}

int[] UserInput()
{
    Console.WriteLine("Сколько элементов в массиве?: ");
    int size = GetANinteger();
    int[] fillarray = new int[size];
    for (int i = 0; i < size; i++)
    {
        Console.WriteLine($"Осталось ввести значений {size - 1}, введите целое число: ");
        fillarray[i] = GetANinteger();
    }
    return fillarray;
}

void ParseRows(string[] rows)
{
    
    for (int i = 0; i < rows.Length; i++)
    {
        if (Int.TryParse(rows[i], out  num))
    }
}

int[] arr =new int[5] {1, 2, 3 ,4, 5};

ArrayOtput(Array(UserInput()));

//https://www.jetbrains.com/ru-ru/lp/mono/

int[,] SortingColumns(int[,] matrix) //Сортирует колонны по убыванию
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