// 36. Задать массив, заполнить случайными положительными трёхзначными числами. 
// Показать количество нечетных\четных чисел
System.Console.Write("Write array size: ");
int n = int.Parse(Console.ReadLine());
int[] array = new int[n];
void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++) array[i] = new Random().Next(100, 1000);
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++) System.Console.Write($"{array[i]} ");
}
int Chet(int[] array, int chet)
{
    for (int i = 0; i < array.Length; i++) if (array[i] % 2 == 0) chet += 1;
    return chet;
}
int Nechet(int[] array, int nechet)
{
    for (int i = 0; i < array.Length; i++) if (array[i] % 2 != 0) nechet += 1;
    return nechet;
}

FillArray(array);
PrintArray(array);
System.Console.WriteLine();
int chet = 0;
int nechet = 0;
System.Console.WriteLine($"Кол-во четных эллементов коллекции: {Chet(array, chet)}");
System.Console.WriteLine($"Кол-во не четных эллементов коллекции: {Nechet(array, nechet)}");