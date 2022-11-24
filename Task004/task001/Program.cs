// 1 . Дана матрица. Вывести на экран все нечетные столбцы, 
// у которых первый элемент больше последнего.

int[,] array = new int[4, 4];

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++) array[i, j] = new Random().Next(0, 10);
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

FillArray(array);
PrintArray(array);
System.Console.WriteLine();
Columns(array);

void Columns(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (j % 2 == 0 && array[0, j] > array[array.GetLength(0) - 1, j])
            {
                System.Console.Write($"{array[i, j]} \t");
            }
        }
        System.Console.WriteLine();
    }
}