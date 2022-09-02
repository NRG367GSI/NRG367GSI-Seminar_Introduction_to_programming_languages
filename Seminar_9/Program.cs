int[] Array(int[] array)
{
    int index =
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
    for (int j = 0; j < size; j++)
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

int[] arr =new int[5] {1, 2, 3 ,4, 5};
ArrayOtput(Array(arr));