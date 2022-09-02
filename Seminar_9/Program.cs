int GetANinteger() //Запрашивает значение пока не будит введено целое число
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

int[] Array(int[] array)
{
    //int[] index = new int[array.Length];
    int size = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            //index
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

int[] arr =new int[5] {1, 2, 3 ,4, 5};

ArrayOtput(Array(UserInput()));