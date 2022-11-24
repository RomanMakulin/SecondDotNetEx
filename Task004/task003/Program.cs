// 9. Задана матрица неотрицательных чисел. Посчитать сумму элементов в каждом столбце. 
// Определить, какой столбец содержит максимальную сумму.

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

FillArray(array);
PrintArray(array);
System.Console.WriteLine();
SumColumns(array);

void SumColumns(int[,] array)
{
    int[] sumArr = new int[array.GetLength(1)];
    int sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[j, i];
        }
        sumArr[i] = sum;
        sum = 0;
    }
    int max = sumArr[0];
    int min = sumArr[0];
    int count1 = 0;
    int count2 = 0;
    for (int i = 0; i < sumArr.Length; i++)
    {
        if (max < sumArr[i])
        {
            max = sumArr[i];
            count1 = i;
        }
        if (min > sumArr[i])
        {
            min = sumArr[i];
            count2 = i;
        }
        System.Console.Write($"{sumArr[i]} \t");
    }
    System.Console.WriteLine();
    System.Console.Write($"Макимальная сумма - {max}, строчка - {count1}. ");
    System.Console.WriteLine();
    System.Console.Write($"Минимальная сумма - {min}, строчка - {count2}. ");
}