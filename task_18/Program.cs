// Задача 18: Напишите программу, которая по
// заданному номеру четверти, показывает диапазон
// возможных координат точек в этой четверти (x и y).


Console.WriteLine("Введите номер четверти: ");
int x = Convert.ToInt32(Console.ReadLine());

string Quarter(int xc)
{
    if (xc == 1) return "xc > 0 && yc > 0";
    if (xc == 2) return "xc < 0 && yc > 0";
    if (xc == 3) return "xc < 0 && yc < 0";
    if (xc == 4) return "xc > 0 && yc < 0";
    return "Введены некорректные координаты";
}

string result = Quarter(x);
Console.Write($"{result}");