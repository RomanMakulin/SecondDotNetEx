// 56. Написать программу, которая обменивает элементы первой строки и последней строки (+)

int[,] array = new int[4, 4];
FillArray(array);
PrintArray(array);

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int k = 0; k < array.GetLength(1); k++) array[i, k] = new Random().Next(0, 10);
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
void SwitchRow(int[,] array)
{
    int temp = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        temp = array[0, i];
        array[0, i] = array[array.GetLength(0) - 1, i];
        array[array.GetLength(0) - 1, i] = temp;
    }
    for (int i = 0; i < array.GetLength(0); i++)
    {
        temp = array[0, i];
        array[0, i] = array[array.GetLength(0) - 1, i];
        array[array.GetLength(0) - 1, i] = temp;
        for (int k = 0; k < array.GetLength(1); k++)
        {
            System.Console.Write($"{array[i, k]} \t");
        }
        System.Console.WriteLine();
    }
}
System.Console.WriteLine();
SwitchRow(array);