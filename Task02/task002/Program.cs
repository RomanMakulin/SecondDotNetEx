//  1. По двум заданным числам проверять является ли первое квадратом второго

System.Console.Write("Введите число A: ");
int a = int.Parse(Console.ReadLine());
System.Console.Write("Введите число B: ");
int b = int.Parse(Console.ReadLine());
if (b == a * a) System.Console.WriteLine($"{b} квадрат числа {a}");
else System.Console.WriteLine($"{b} не квадрат числа {a}");
