// Задача 15: Напишите программу, которая 
// принимает на вход цифру, обозначающую день 
// недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите целое число от 1 до 7: ");
int number = Convert.ToInt32(Console.ReadLine());

string day = " ";

switch (number)
{
    case 1:
        day = "Не выходной";
        break;
    case 2:
        day = "Не выходной";
        break;
    case 3:
        day = "Не выходной";
        break;
    case 4:
        day = "Не выходной";
        break;
    case 5:
        day = "Не выходной";
        break;
    case 6: case 7:
        day = "Выходной";
        break;    
    default:
        day = $"Нет дня недели с номером {number}";
        break;

}
Console.Write(day);
