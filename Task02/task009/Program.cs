// Написать таблицу умножения

int[,] array = new int[11, 11];
void SqrtTable(int[,] array)
{
    for (int i = 2; i < array.GetLength(1); i++)
    {
        for (int j = 2; j < array.GetLength(0); j++)
        {
            System.Console.Write($"{j}x{i} = {j * i} \t");
        }
        System.Console.WriteLine();
    }
}
SqrtTable(array);