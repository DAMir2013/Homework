static int exponentiationNum(int footing, int degree) 
{
    int exponentResult = footing;
    for(int i = 1; i < degree; i++) 
    {
        exponentResult *= footing;
    }
    return exponentResult;
}

Console.Write("Введите число, которое нужно возвести в степень: ");
int footing = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число, в какую степень нужно возвести число(число должно быть больше 0): ");
int degree = Convert.ToInt32(Console.ReadLine());

int result = exponentiationNum(footing, degree);
System.Console.WriteLine(result);
