Console.WriteLine("Введите день недели");
int dayOfWeek = Convert.ToInt32(Console.ReadLine());

if(dayOfWeek > 7 || dayOfWeek < 1) {
    Console.WriteLine("Такого дня недели нет");
}
else 
{
    if(dayOfWeek == 1) 
    {
        Console.WriteLine("Понедельник");
    }
        if(dayOfWeek == 2) 
    {
        Console.WriteLine("Вторник");
    }
        if(dayOfWeek == 3) 
    {
        Console.WriteLine("Среда");
    }
        if(dayOfWeek == 4) 
    {
        Console.WriteLine("Четверг");
    }
        if(dayOfWeek == 5) 
    {
        Console.WriteLine("Пятница");
    }
        if(dayOfWeek == 6) 
    {
        Console.WriteLine("Суббота");
    }
        if(dayOfWeek == 7) 
    {
        Console.WriteLine("Воскресенье");
    }
}
