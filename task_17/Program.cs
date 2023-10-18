System.Console.WriteLine("Введите первое число");
int firstNum = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите второе число");
int secondNum = Convert.ToInt32(Console.ReadLine());
// if(firstNum > secondNum) 
// {
//     if(firstNum == secondNum * secondNum) 
//     {
//         System.Console.WriteLine("Первое число является квадратом второго");
//     }
//     else 
//     {
//         System.Console.WriteLine("Первое число не является квадратом второго");
//     }
// }
// else 
// {
//     if(secondNum== firstNum * firstNum) 
//     {
//         System.Console.WriteLine("Второе число является квадратом первого");
//     }
//     else 
//     {
//         System.Console.WriteLine("Второе число не является квадратом первого");
//     }
// }
// if(firstNum == secondNum) {
//     Console.WriteLine("Нет, не является");
// }
if(firstNum * firstNum == secondNum || secondNum * secondNum == firstNum) {
    System.Console.WriteLine("Да, является");
}
else 
{
    System.Console.WriteLine("Нет, не является");
}