// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
Console.Write("Введите значение параметра b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите значение параметра k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите значение параметра b2: ");
double b2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите значение параметра k2: ");
double k2 = Convert.ToInt32(Console.ReadLine());

double coordX = 0;
double coordY = 0;
void searchXandY(double b1, double k1, double b2, double k2)
{
    coordX = (b2 - b1) / (k1 - k2);
    coordY = k1 * ((b2 - b1) / (k1 - k2)) + b1;
}
searchXandY(b1, k1, b2, k2);
System.Console.WriteLine($"({coordX}; {coordY})");




