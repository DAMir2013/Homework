Console.WriteLine("Введите первое число");
int firstNum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int secondNum = Convert.ToInt32(Console.ReadLine());
if(firstNum % secondNum == 0) {
    System.Console.WriteLine("Первое число кратно второму");
}
else 
{
    System.Console.WriteLine($"Некратно, остаток от деления {firstNum % secondNum}");
}
