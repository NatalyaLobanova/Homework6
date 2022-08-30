// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

int b1 = ReadInt("Введите число b1: ");
int k1 = ReadInt("Введите число k1: ");
int b2 = ReadInt("Введите число b2: ");
int k2 = ReadInt("Введите число k2: ");

double x;
double y; 

if (k1 == k2 && b1 == b2)
{
    Console.WriteLine("Прямые совпадают");
}

else if (k1 == k2)
{
    Console.WriteLine("Прямые параллельны");
}
else
{
    x = ((b2 - b1) * 1.0 / (k1 - k2) ) ;
    y = k1 * ((b2 - b1) * 1.0 / (k1 - k2) ) + b1;
    Console.WriteLine($"Пересечение в точке ({x}; {y})");
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}