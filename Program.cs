// Задача 1: Задайте значения M и N. Напишите программу, которая выведет 
// все натуральные числа в промежутке от M до N.

Console.WriteLine("Vvedite chislo ravnoe M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Vvedite chislo ravnoe N: ");
int n = Convert.ToInt32(Console.ReadLine());

string PrintNum(int m, int n)
{
    if (n <= m)
    {
        return Convert.ToString(m);
    }
    return m + " " + PrintNum(m + 1, n);
}
Console.WriteLine(PrintNum(m, n));
