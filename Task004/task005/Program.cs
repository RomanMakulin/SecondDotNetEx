// 10. Дано натуральное число N. Написать метод(методы) для формирования массива, элементами которого 
// являются цифры числа N.

int n = 532131;
int count = 0;

int CountN(int n, int count)
{
    for (count = 0; n > 1; count++) n = n / 10;
    return count;
}

System.Console.WriteLine($"{CountN(n, count)}");
System.Console.WriteLine();
NewArrN(n, CountN(n, count));

void NewArrN(int n, int count)
{
    int[] array = new int[count];
    for (int i = 0; i < count; i++)
    {
        array[i] = n % 10;
        n = n / 10;
    }
    while (count > 0)
    {
        System.Console.Write($"{array[count - 1]} \t");
        count--;
    }
}