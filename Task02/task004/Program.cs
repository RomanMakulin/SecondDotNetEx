//  3. По заданному номеру дня недели вывести его название

string[] array = { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье" };
System.Console.Write("Введите номер дня недели (1-7): ");
int n = int.Parse(Console.ReadLine());
void DayOff (string[] array, int n)
{
    if (n <= array.Length && n > 0)
    {
    if (n < 6) System.Console.WriteLine($"{array[n-1]}. Работаем!");
    else System.Console.WriteLine($"{array[n-1]}. Выходной))");
    }
    else System.Console.WriteLine("Некорректный день недели. Повторите ввод");
}
DayOff (array, n);