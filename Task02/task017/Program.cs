// 30. Показать кубы чисел, заканчивающихся на четную цифру (+)

System.Console.Write("Input collection length: ");
int n = int.Parse(Console.ReadLine());
int[] array = new int[n];

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++) array[i] = new Random().Next(0, 5);
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++) System.Console.Write($"{array[i]} ");
}
void CubeChetElements(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (Math.Pow(array[i], 2) % 2 == 0 && Math.Pow(array[i], 2) > 0)
        {
            System.Console.Write($"{Math.Pow(array[i], 2)} ");
        }
    }
}

FillArray(array);
PrintArray(array);
System.Console.WriteLine();
CubeChetElements(array);