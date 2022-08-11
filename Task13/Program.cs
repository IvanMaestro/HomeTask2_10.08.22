// Задача 13: Напишите программу, которая выводит 
// третью цифру заданного числа или сообщает, что 
// третьей цифры нет. Решить без использования строк.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

Console.Write("Введите любое число: ");
int number = Convert.ToInt32(Console.ReadLine());

int result = 0;

if (number < 100) Console.Write("Нет третьего числа");
if (number > 100)
{
    for (int i = number; i > 0; i = i / 10)
    {
        if (i > 999)
            continue;
        else if (i < 1000 && i > 99) result = i % 10;
    }
    Console.WriteLine($"Третья цифра числа {number}: {result % 10}");
}
