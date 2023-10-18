int number = new Random().Next(10,100);
int firstNum = number / 10;
int secondNum = number % 10;

if(firstNum > secondNum) 
{
    System.Console.WriteLine($"Случайное число {number}");
    System.Console.WriteLine($"Первое число {firstNum} больше второго {secondNum}");
}
else 
{
    if(secondNum > firstNum) 
    {
        System.Console.WriteLine($"Случайное число {number}");
        System.Console.WriteLine($"Второе число {secondNum} больше первого {firstNum}");  
    }
    if(secondNum == firstNum) 
    {
        System.Console.WriteLine($"Случайное число {number}");
        System.Console.WriteLine($"Числа {secondNum} и {firstNum} равны" );  
    }
}