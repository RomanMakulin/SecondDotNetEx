// 4. Показать первую цифру дробной части числа
System.Console.Write("Дано дробное число: ");
double n = 34.53123;
System.Console.WriteLine(n);
n = n * 10;
int result1 = Convert.ToInt32(n);
result1 = result1 % 10;
System.Console.WriteLine(result1);