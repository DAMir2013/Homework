Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
int negativNum = - number;

while(negativNum <= number) 
{
    Console.WriteLine($"{negativNum}");
    negativNum++;
}
