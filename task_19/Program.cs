Console.Write("Введите номер четверти: ");
int quoter = Convert.ToInt32(Console.ReadLine());

if(quoter == 1) 
{
    System.Console.WriteLine("x > 0 && y > 0 ");
}
if(quoter == 2) 
{
    System.Console.WriteLine("x < 0 && y > 0 ");
}
if(quoter == 3) 
{
    System.Console.WriteLine("x < 0 && y < 0 ");
}
if(quoter == 4) 
{
    System.Console.WriteLine("x > 0 && y < 0 ");
}