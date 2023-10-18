// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int ValueAkkerman(int m, int n)
{
    if(m == 0) 
    {
        return n + 1;
    }
    if(m > 0 && n == 0) 
    {
        return ValueAkkerman(m -1, 1);
    }
    if(m > 0 && n > 0)
    {
        return ValueAkkerman(m - 1, ValueAkkerman(m, n -1));
    }
    return 0;
}
System.Console.WriteLine("Введите число, от которого нужно начать вывод m: ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите число, до которого нужно выводить числа n: ");
int n = Convert.ToInt32(Console.ReadLine());
int valueFunc = ValueAkkerman(m, n);
System.Console.Write(valueFunc);