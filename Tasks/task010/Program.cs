// 14. Подсчитать сумму цифр в вещественном числе.
int SumEl(int n, int result)
{
    while (n > 0)
    {
        result += n % 10;
        n = n / 10;
    }
    return result;
}
int n = new Random().Next(30, 1000000);
int result = 0;
System.Console.WriteLine($"Дано рандомное число: {n} ");
System.Console.Write($"Сумма элементов числа: {SumEl(n, result)} ");
