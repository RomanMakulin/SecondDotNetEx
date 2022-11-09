// 29. Написать программу вычисления произведения чисел от 1 до N (+)
System.Console.Write("Введите количество чисел в коллекции: ");
int n = int.Parse(Console.ReadLine());
int[] array = new int[n];
FillArray(array);
PrintArray(array);
System.Console.WriteLine();

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++) array[i] = new Random().Next(0, 5);
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++) System.Console.Write($"{array[i]} ");
}
int Multiply(int[] array, int result)
{
    for (int i = 0; i < array.Length; i++) result *= array[i];
    return result;
}

int result = 1;
System.Console.WriteLine($"Произведение чисел коллекции: {Multiply(array, result)}");