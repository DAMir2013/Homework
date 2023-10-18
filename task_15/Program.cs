Console.WriteLine("Введите число для проверки");
int num = Convert.ToInt32(Console.ReadLine());
if(num % 7 == 0 && num % 23 == 0) 
{
    System.Console.WriteLine("Число кратно 7 и 23");
}
else
{
    System.Console.WriteLine("Число не кратно 7 и 23");
}
