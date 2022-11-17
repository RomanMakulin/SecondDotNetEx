// 54. В матрице чисел найти сумму элементов главной диагонали (+)

int[,] array = new int[4, 4];
FillArray(array);
PrintArray(array);
System.Console.WriteLine();
void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int k = 0; k < array.GetLength(1); k++) array[i, k] = new Random().Next(0, 20);
    }
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int k = 0; k < array.GetLength(1); k++) System.Console.Write($"{array[i, k]} \t");
        System.Console.WriteLine();
    }
}

void SumElDiagonal(int[,] array)
{
    int sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int k = 0; k < array.GetLength(1); k++)
        {
            sum = array[i, k] + sum;
            i++;
        }
    }
    System.Console.WriteLine(sum);
}
SumElDiagonal(array);
