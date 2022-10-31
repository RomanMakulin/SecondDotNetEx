// 15. Написать программу получающую набор произведений чисел от 1 до N.
// Пример: пусть N = 4, тогда
// [ 1, 2, 6, 24 ]
void MultiplicationElements(int[] array)
{
    int a = 1;
    for (int i = 0; i < array.Length; i++)
    {
        a = a * (i + 1);
        System.Console.Write($"{a} ");
    }
}
int n = int.Parse(Console.ReadLine());
int[] array = new int[n];
MultiplicationElements(array);