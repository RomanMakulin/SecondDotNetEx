// 5. Дано число. Проверить кратно ли оно 5 и 10 или 15 но не 30
int n = int.Parse(Console.ReadLine());
Check(n);
void Check(int n)
{
    if (n % 30 != 0)
    {
        if (n % 5 == 0 && n % 10 == 0) System.Console.WriteLine("Число кратно");
        if (n % 15 == 0) System.Console.WriteLine("Число кратно");
    }
    else System.Console.WriteLine("Число не кратно");
}