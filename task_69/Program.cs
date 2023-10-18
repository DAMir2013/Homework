// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

int GetInt(string str = " ")
{
    Console.WriteLine(str);
    return Convert.ToInt32(Console.ReadLine());
}

int ExponentiationNum(int A, int B)
{
    if(B == 0)
    {
        return 1;
        
    }
    return A * ExponentiationNum(A, B - 1);
}

int A = GetInt("Введите число, которое нужно возводить в степень A = ");
int B = GetInt("Введите степень, в которую нужно возводить число B = ");

System.Console.WriteLine(ExponentiationNum(A, B));