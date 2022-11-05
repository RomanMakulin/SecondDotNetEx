//  4. Найти максимальное из трех чисел

System.Console.Write("Введите количество чисел: ");
int n = int.Parse(Console.ReadLine());
int[] array = new int[n];
void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++) array[i] = new Random().Next(0, 1000);
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++) System.Console.Write($"{array[i]} ");
}
int MaxEl(int[] array)
{
    int max = array[0];
    for (int i = 0; i < array.Length; i++) if (array[i] > max) max = array[i];
    return max;
}
int max = 0;
FillArray(array);
System.Console.Write($"Рандомные {n} числа: ");
PrintArray(array);
System.Console.WriteLine();
System.Console.Write($"Максимальный элемент: {MaxEl(array)}");