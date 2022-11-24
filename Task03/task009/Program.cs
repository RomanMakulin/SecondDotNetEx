// Частотный словарь
// {4, 2, 2, 4, 1, 6, 4, 4, 1, 4}
// 4 - 5 раз, 2 - 2 раза, 1 - 2 раза, 6 - 1 раз

int[,] array = new int[4, 4];
FillArray(array);
PrintArray(array);
System.Console.WriteLine();
void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int k = 0; k < array.GetLength(1); k++) array[i, k] = new Random().Next(0, 6);
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
void ShowMe(int[,] array)
{
    int str = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int k = 0; k < array.GetLength(1); k++)
        {
            for (int j = k + 1; j < array.GetLength(1); j++)
            {
                if (array[i, k] == array[i, j])
                {
                    str += 1;
                }
                if ( j == array.GetLength(1)) 
                {
                    i++;
                    k = 0;
                }
            }
                if (str > 0)
                {
                    System.Console.WriteLine($"{array[i, k]} повторяется {str} раз ");
                }
        }
    }
}
ShowMe(array);

