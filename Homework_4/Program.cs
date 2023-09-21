// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22
Console.WriteLine("Введите 1 число");
int firstNum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2 число");
int secondNum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 3 число");
int thirdNum = Convert.ToInt32(Console.ReadLine());
int max = firstNum;
if(max < secondNum) {
    max = secondNum;
}
if(max < thirdNum) {
    max = thirdNum;
} 

Console.Write(max);

