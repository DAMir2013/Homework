// Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"
void ShowGap(int M, int N)
{
    if(N == M - 1)
    {
        return;
    }
    ShowGap(M, N - 1);
    System.Console.Write($"{N}  ");
}

System.Console.WriteLine("Введите число, от которого нужно начать вывод M: ");
int M = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите число, до которого нужно выводить числа N: ");
int N = Convert.ToInt32(Console.ReadLine());

ShowGap(M, N);