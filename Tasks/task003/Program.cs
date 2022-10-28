// 1. По двум заданным числам проверить является ли одно квадратом второго 

System.Console.Write("Введите число a: ");
int a = int.Parse(Console.ReadLine());
System.Console.Write("Введите число b: ");
int b = int.Parse(Console.ReadLine());
int Sqrt(int a, int b)
{
    if (b == a*a) System.Console.WriteLine($"Число {b} является квадратом числа {a} ");
    else System.Console.WriteLine("Не квадрат");
    return a;
}
Sqrt(a, b);