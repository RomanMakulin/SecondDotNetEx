// 13. Отсотрировать стобцы матрицы по возрастанию и убыванию значений эементов

int[,] array = new int[4, 4];

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]} \t");
        }
        System.Console.WriteLine();
    }
}
void Filter(int[,] array)
{
    int temp = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = i + 1; k < array.GetLength(0); k++)
            {
                if (array[i, j] > array[k, j])
                {
                    temp = array[k, j];
                    array[k, j] = array[i, j];
                    array[i, j] = temp;
                }
            }
            System.Console.Write($"{array[i, j]} \t");
        }
        System.Console.WriteLine();
    }
}

FillArray(array);
PrintArray(array);
System.Console.WriteLine();
Filter(array);