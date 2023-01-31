// Напишите программу, которая выводит третью цифру заданного 
// числа или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine ("Введите число:  ");
int n = Convert.ToInt32(Console.ReadLine());
string nStr = Convert.ToString(n);
n = nStr.Length;
if (n > 2) 
{
    Console.WriteLine($"третья цифра числа {nStr} -> {nStr[2]}");
}
else 
{
    Console.WriteLine("третьей цифры нет!");
}