// 34. Написать программу замену элементов массива на противоположные 

int[] array = new int[10];
void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++) array[i] = new Random().Next(-10, 10);
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++) System.Console.Write($"{array[i]} ");
}
void SwitchElements(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) array[i] = array[i] * (-1);
        else array[i] = array[i] * (-1);
        System.Console.Write($"{array[i]} ");
    }
}
FillArray(array);
PrintArray(array);
System.Console.WriteLine();
SwitchElements(array);