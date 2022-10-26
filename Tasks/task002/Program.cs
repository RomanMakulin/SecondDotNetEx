// 60. Составить частотный словарь элементов двумерного массива
// Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++) array[i, j] = new Random().Next(1, 7);
    }
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++) System.Console.Write($"{array[i, j]}  ");
        System.Console.WriteLine();
    }
}
int[] ToOneMassiv(int[,] array)
{
    int[] newArr = new int[array.GetLength(0) * array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            newArr[i] = array[i, j];
            System.Console.Write($"{newArr[i]} ");
        }
    }
    return newArr;
}
void RepeatElements(int[] array)
{
    int count = 1;
    int[] array2 = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        for (int k = array.Length - 1; k <= 0; k--)
        {
            if (array[i] == array[k])
            {
                array2[i] = count + 1;
            }
            else
            {
                array2[i] = 1;
            }
            System.Console.Write($"{array2[i]}");
        }
    }
}

System.Console.Write("Введите размер массива (количество рядов): ");
int sizeA = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите размер массива (количество столбцов): ");
int sizeB = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[sizeA, sizeB];
FillArray(array);
PrintArray(array);
System.Console.WriteLine();
ToOneMassiv(array);
System.Console.WriteLine();
RepeatElements(ToOneMassiv(array));
