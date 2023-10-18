System.Console.Write("Введите первое число: ");
int sideA = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите второе число: ");
int sideB = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите третье число: ");
int sideC = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine($"{sideA}, {sideB}, {sideC}");

bool checkTriangle(int side1, int side2, int side3)
{
    if((side1 + side2) > side3 && (side2+side3) > side1 && (side1 + side3) > side2)
    {
        return true;
    }
    else
    {
        return false;
    }
}

bool answer = checkTriangle(sideA, sideB, sideC);
System.Console.WriteLine(answer);