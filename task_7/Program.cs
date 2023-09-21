Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
if(number > 99 && number < 1000) {
    int endNum = number % 10;
    Console.WriteLine(endNum);
}
else 
{
    Console.WriteLine("Введите трехзначное число");
}