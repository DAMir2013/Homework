// Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"
void RoadToN(int number)
{
    if(number == 0) 
    {
        return;
    }
    RoadToN(number - 1);
    System.Console.Write($"{number}  ");
}

Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());

RoadToN(N);

























// int counter = 1;
// while(counter <= nValue)
// {   if(counter < nValue)
// {
//     System.Console.Write($"{counter}, ");
//     counter++;
// }
// else 
// {
//     System.Console.Write($"{counter} ");
//     counter++;
// }
    
// }