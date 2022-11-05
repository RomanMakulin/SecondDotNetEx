// 3. Вывести на экран числа от -N до N
void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++) array[i] = new Random().Next(-100, 101);
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++) System.Console.Write($"{array[i]} ");
}
void Filter(int[] array)
{
    int min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        for (int k = i + 1; k < array.Length; k++)
        {
            if (array[k] < array[i])
            {
                int temp = array[k];
                array[k] = array[i];
                array[i] = temp;
            }
        }
        System.Console.Write($"{array[i]} ");
    }
}

System.Console.Write("Введите количество элементов: ");
int n = int.Parse(Console.ReadLine());
int[] array = new int[n];
FillArray(array);
PrintArray(array);
System.Console.WriteLine();
System.Console.WriteLine("Фильтрация от меньшего к большему: ");
Filter(array);