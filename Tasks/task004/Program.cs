// 2. Найти максимальное из пяти чисел

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++) array[i] = new Random().Next(5, 100);
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++) System.Console.Write($"{array[i]} ");
}
int MaxElement(int[] array)
{
    int max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
    }
    System.Console.WriteLine(max);
    return max;
}

int max = 0;
System.Console.Write("Введите количество рандомных чисел: ");
int n = int.Parse(Console.ReadLine());
int[] array = new int[n];
FillArray(array);
PrintArray(array);
System.Console.WriteLine();
System.Console.Write("Максимальный элемент: ");
MaxElement(array);