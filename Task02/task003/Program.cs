// 2. Даны два числа. Показать большее и меньшее число
System.Console.Write("Введите число A: ");
int a = int.Parse(Console.ReadLine());
System.Console.Write("Введите число B: ");
int b = int.Parse(Console.ReadLine());
if (a > b) System.Console.WriteLine($"Число {a} - большее. Число {b} - меньшее");
else System.Console.WriteLine($"Число {b} - большее. Число {a} - меньшее");
if (a == b) System.Console.WriteLine("Числа равны");