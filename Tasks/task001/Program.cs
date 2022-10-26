// Дана последовательность чисел. Получить список неповторяющихся элементов исходной последовательности
// Пример: [1, 2, 3, 5, 1, 5, 3, 10] => [1, 2, 3, 5, 10]

void RepeatElements(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        for (int k = i + 1; k < array.Length; k++)
        {
            if (array[i] == array[k]) array[k] = 0;
        }
        if (array[i] > 0) System.Console.Write($"{array[i]} ");
    }
}
int[] array = { 1, 2, 3, 5, 1, 5, 3, 10 };
RepeatElements(array);

