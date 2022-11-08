// 21. Программа проверяет пятизначное число на палиндромом. (+)

int[] numbers = { 2, 2, 1, 2, 2 };
void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++) System.Console.Write($"{array[i]} ");
}
FillArray(numbers);
bool IsPalindrome(int[] array)
{
    for (int i = 0, a = array.Length - 1; i < a; i++, a--)
    {
        if (array[i] != array[a]) return false;
        else System.Console.WriteLine("This number is palindrome.");
        return true;
    }
    return true;
}
System.Console.WriteLine();
IsPalindrome(numbers);