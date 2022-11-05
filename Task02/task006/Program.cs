//  6. Выяснить является ли число чётным
System.Console.Write("Какое число проверяем на четность?: ");
int n = int.Parse(Console.ReadLine());
void Chetnoe(int n)
{
    if (n % 2 == 0) System.Console.WriteLine("Число четное");
    else System.Console.WriteLine("Число не четное");
}
Chetnoe(n);