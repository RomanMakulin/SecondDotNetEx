// 35. Определить, присутствует ли в заданном массиве, некоторое число
int[] array = { 4, 2, 1, 6, 2, 10 };
int n = int.Parse(Console.ReadLine());
void FindN(int[] array, int n)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == n)
        {
            System.Console.WriteLine($"Значение {n} в коллекции найдено");
            break;
        }
    }
}
FindN(array, n);