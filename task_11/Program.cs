int num = new Random().Next(100, 1000);
Console.WriteLine($"Случайное число {num}");
int firstNum = num / 100;
int thirdNum = num % 10;
System.Console.WriteLine(firstNum*10 + thirdNum);

