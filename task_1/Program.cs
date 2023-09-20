Console.WriteLine("Введите первое число");
int square = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ввелите второе число");
int number = Convert.ToInt32(Console.ReadLine());

if(square == number * number) 
{
    Console.WriteLine("true");
}
else 
{
   Console.WriteLine("false"); 
}