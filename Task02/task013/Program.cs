// 26. Возведите число А в натуральную степень B используя цикл (+)
// Example: 2^3 = 8;
int a = 2;
int b = 3;
int ExponentAtoB(int a, int b, int result)
{
    for (int i = 0; i < b; i++) result = result * a;
    return result;
}
int result = 1;
System.Console.WriteLine($"{ExponentAtoB(a, b, result)}");