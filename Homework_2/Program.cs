// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3
Console.WriteLine("Введите 1 число");
int firstNum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2 число");
int secondNum = Convert.ToInt32(Console.ReadLine());

if(firstNum > secondNum) {
    Console.Write($"Первое число: {firstNum} ,больше второго {secondNum}");
}
else {
    if(firstNum < secondNum) {
        Console.Write($"Второе число: {secondNum} ,больше первого {firstNum} ");
    }
    else 
    {
        Console.Write($"Числа: {secondNum} и {firstNum} равны");

    }
}

