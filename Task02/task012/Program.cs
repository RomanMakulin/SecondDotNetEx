// 25. Найти сумму чисел от 1 до А (+)

int[] array = { 1, 2, 3, 1, 2 }; // sum = 9;

int sum = 0;
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++) System.Console.Write($"{array[i]} ");
}
int SumElements(int[] array, int sum)
{
    for (int i = 0; i < array.Length; i++)
    {
        sum += array[i];
    }
    return sum;
}

PrintArray(array);
System.Console.WriteLine();
System.Console.WriteLine($"Сумма элементов коллекции: {SumElements(array, sum)}");
