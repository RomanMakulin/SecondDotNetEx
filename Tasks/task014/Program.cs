//44. Дана последовательность чисел. 
// Получить список уникальных элементов заданной последовательности.
// Пример: [1, 2, 2, 4, 1, 6, 1, 9, 10 ] => [4,  6, 9, 10]

int[] array = { 1, 2, 2, 4, 1, 6, 1, 9, 10 };


void Special(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        for (int k = array.Length - 1; k >= i; k--)
        {
            if (k > i)
            {
                if (array[k] == array[i])
                {
                    array[k] = 0;

                }

            }
            if (i == k)
            {
                array[i] = 0;
            }
        }
        if (array[i] > 0) System.Console.WriteLine($"{array[i]} ");
    }
}

Special(array);

