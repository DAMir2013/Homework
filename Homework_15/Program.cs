// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет
Console.WriteLine("Введите день недели,чтобы узнать является ли он выходным");
int num = Convert.ToInt32(Console.ReadLine());
if(num == 6 || num == 7) 
{
    System.Console.WriteLine("Да");
}
else 
{
     System.Console.WriteLine("Нет");
}