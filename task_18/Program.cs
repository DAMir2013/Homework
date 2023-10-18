Console.Write("Введите координату x: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату y: ");
int y = Convert.ToInt32(Console.ReadLine());

if(x > 0 && y > 0) 
{
    System.Console.WriteLine("Точка находится в 1 четверти");
}
if(x < 0 && y > 0) 
{
    System.Console.WriteLine("Точка находится в 2 четверти");
}
if(x < 0 && y < 0) 
{
    System.Console.WriteLine("Точка находится в 3 четверти");
}
if(x > 0 && y < 0) 
{
    System.Console.WriteLine("Точка находится в 4 четверти");
}
