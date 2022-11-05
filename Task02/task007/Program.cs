//  8. Показать четные числа от 1 до N
int[] array = new int[5];
void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++) array[i] = new Random().Next(1, 20);
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++) System.Console.Write($"{array[i]} ");
}
void Chet(int[] array)
{
    for (int i = 0; i < array.Length; i++) if (array[i] % 2 == 0) System.Console.Write($"{array[i]} ");
}
FillArray(array);
System.Console.Write("Набор чисел: ");
PrintArray(array);
System.Console.WriteLine();
System.Console.Write("Четные числа: ");
Chet(array);