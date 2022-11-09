// 24. Найти кубы чисел от 1 до N (+)

System.Console.Write("Введите количество чисел в коллекции: ");
int n = int.Parse(Console.ReadLine());
int[] array = new int[n];

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++) array[i] = new Random().Next(1, 5);
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++) System.Console.Write($"{array[i]} ");
}
void CubeElement(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.WriteLine($"{array[i]}^3 = {(int)Math.Pow(array[i], 3)}");
    }
}

FillArray(array);
System.Console.Write("Рандомная коллекция чисел: ");
PrintArray(array);
System.Console.WriteLine();
CubeElement(array);