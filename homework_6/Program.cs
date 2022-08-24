/*
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3

Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются
пользователем. b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Доп. задча: Задайте двумерный массив со случайными числами от -10 до 10. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.)
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Сумма элементов главной диагонали: 1+9+2 = 12
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

void Task_41() //Принемает пользовательский ввод "М" чисел и выводит в консоль колличество положительных.
{
    Console.Write("Сколько чисел вы введете?:");
    int m = Math.Abs(protection());
    int count = 0;
    int[] array = new int[m];
    for (int i = 0; i < m; i++)
    {
        Console.Write($"Введите значение : {i + 1}:");
        Console.Write("Если вы хототе прирвать ввод наберите - 1234567890 ");
        array[i] = protection();
        if (array[i] == 1234567890) break;
        else if (array[i] > 0) count++;
    
        Console.WriteLine($"Вы ввели  положительных чисел {count}, осталось ввести: {m - i - 1}:");
    }
}

void Task_43()
{
    string[,] variables = {
        {"Введите b1: ", "Введите k1: "},
        {"Введите b2: ", "Введите k2: "}
                };
    double[,] matrix = new double[2, 2];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j =0; j < matrix.GetLength(1); j++)
        {
            Console.Write(variables[i,j]);
            matrix[i ,j] = Convert.ToDouble(protection());
        }
    }
    double x = (matrix[1,0] - matrix[0,0]) / (matrix[0,1] - matrix[1,1]);
    double y = (matrix[0,1] * (matrix[1,0] - matrix[0,0])) / (matrix[0,1] - matrix[1,1]) + matrix[0,0];
    Console.WriteLine($"Координаты точки пересечения двух прямых X: {x} и Y: {y}");
}

void Task_optional(int min = -9, int max = 9)
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
    if (rows > columns) for (int k = 0; k < columns; k++) summ += matrix[k,k];
    else for (int k = 0; k < rows; k++) summ += matrix[k,k];
    Console.WriteLine($"Сумма элементов матрици по диагонали: {Math.Round(summ, 2)}");
}   

void menu() //Вызывает методы
{    
    string paragraph = String.Empty;
    while (paragraph != "1" || paragraph != "2" || paragraph != "0")
    {
        Console.WriteLine("===========================================");
        Console.WriteLine("Введите 1 для перехода к задаче 41: ");
        Console.WriteLine("Введите 2 для перехода к задаче 43: ");
        Console.WriteLine("Введите 3 для перехода к дополнительной задаче: ");
        Console.WriteLine("Введите 0 для выхода из программы: ");
        Console.WriteLine("===========================================");
        paragraph = Console.ReadLine();
        if (paragraph == "1") Task_41();
        if (paragraph == "2") Task_43();
        if (paragraph == "3") Task_optional();
        if (paragraph == "0") break;
    }
}

menu();