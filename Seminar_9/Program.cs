int[] Array(int[] array)
{
    int[] even = new int[array.Length];
    int size = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            even[i] = array[i];
            size ++;
        }
    }
    for (int k = 0; )
    return even;
}

void ArrayOtput(int[] array)
{
    for (int j = 0; j < array.Length; j++)
    Console.Write($" {array[j]} ");
}

int[] arr =new int[5] {1, 2, 3 ,4, 5};
ArrayOtput(Array(arr));