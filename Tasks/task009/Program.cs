// 12. Для натурального n создать словарь индекс-значение, 
// состоящий из элементов последовательности 3n + 1.
// Для n = 6: {1: 4, 2: 7, 3: 10, 4: 13, 5: 16, 6: 19}

void FillArray(int[] array)
{
    int a = 1;
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = a;
        a += 1;
    }
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++) System.Console.Write($"{array[i]} ");
}
void IndexElement(int[] array)
{
    int a = 1;
    for (int i = 1; i <= array.Length; i++)
    {
        a = 3 * i + 1;
        System.Console.WriteLine($"i({i}): {a} ");
    }
}

System.Console.Write("Введите n: ");
int n = int.Parse(Console.ReadLine());
int[] ArrayN = new int[n];
FillArray(ArrayN);
PrintArray(ArrayN);
System.Console.WriteLine();
IndexElement(ArrayN);