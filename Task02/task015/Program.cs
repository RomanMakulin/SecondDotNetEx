// 28. Подсчитать сумму цифр в числе (+)
int n = 55; // 10
int sum = 0;
int SumElementsNumber(int n, int sum)
{
    for (int i = 0; n > 0; i++, n = n / 10) sum += n % 10;
    return sum;
}
System.Console.WriteLine($"Сумма элементов числа = {SumElementsNumber(n, sum)}");