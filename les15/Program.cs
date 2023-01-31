// Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите число от 1 до 7:  ");
int n = Convert.ToInt32(Console.ReadLine());

if (n >= 1 && n <= 7)
{
if (n == 6 || n == 7) Console.WriteLine($"{n} -> да");
else Console.WriteLine($"{n} -> нет");
}
else Console.WriteLine("Нужно ввести число от 1 до 7!");