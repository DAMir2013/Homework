// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
int sum = 0;
void  ShowGap(int M, int N)
{   
    if(N == M - 1)
    {
        return;
    }
    ShowGap(M, N - 1);
    sum += N;
}

System.Console.WriteLine("Введите число, от которого нужно начать вывод M: ");
int M = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите число, до которого нужно выводить числа N: ");
int N = Convert.ToInt32(Console.ReadLine());

ShowGap(M, N);
System.Console.WriteLine($"{sum}");