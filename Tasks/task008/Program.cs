// 6. Дано число обозначающее день недели. Вывести его название и указать является ли он выходным.

void DayOff(string[] days, int n)
{
    if (n < 8)
    {
        if (n < 6) System.Console.WriteLine($"{days[n - 1]}. Работаем :(");
        else System.Console.WriteLine($"{days[n - 1]}. Ура, выходной!!");
    }
    else System.Console.WriteLine("Введено неверное значения дня недели.");
}
string[] day = new string[] { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскрсенье" };
System.Console.Write("Введите значения дня недели (число): ");
int n = int.Parse(Console.ReadLine());
DayOff(day, n);