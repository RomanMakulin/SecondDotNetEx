// 59. В прямоугольной матрице найти строку с наименьшей суммой элементов.

int[,] array = new int[4, 4];

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++) array[i, j] = new Random().Next(1, 100);
    }
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++) System.Console.Write($"{array[i, j]} \t");
        System.Console.WriteLine();
    }
}
void ChangeColumns(int[,] array)
{
    int[] collection = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }
        collection[i] = sum;
        System.Console.Write($"{collection[i]} \t");
        if (i == array.GetLength(1) - 1)
        {
            int min = collection[0];
            int minIndex = 0;
            for (int k = 0; k < collection.Length; k++)
            {
                if (collection[k] < min)
                {
                    min = collection[k];
                    minIndex = k;
                }
            }
            System.Console.WriteLine(minIndex);
        }
    }
}

FillArray(array);
PrintArray(array);
System.Console.WriteLine();
ChangeColumns(array);
