int GetInt(string str = " ")
{
    Console.Write($"{str}: ");
    return Convert.ToInt32(Console.ReadLine());
}
int SumDigital(int number)
{
    if(number == 0)
    {
        return  0;
    }
    return number%10 + SumDigital(number/10);
}


int number = GetInt("Введите число");
System.Console.WriteLine(SumDigital(number));