// 23. Показать таблицу квадратов чисел от 1 до N (++)
int[] array = { 2, 4, 2, 5, 8 };
PrintArray(array);
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++) System.Console.Write($"{array[i]} ");
}
void SqrtTable(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.WriteLine($"{array[i]}^2 = {(int)Math.Pow(array[i], 2)}");
    }
}
System.Console.WriteLine();
SqrtTable(array);