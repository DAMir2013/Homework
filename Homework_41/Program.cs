Console.Write("Введите сколько чисел нужно проверить: ");
int quantityNum = Convert.ToInt32(Console.ReadLine());
int [] arrayNum = new int [quantityNum];
int counter = 0;
int request() 
{
   Console.Write("Введите число: ");
   int num = Convert.ToInt32(Console.ReadLine()); 
   return num;
}

for(int i = 0; i < arrayNum.Length; i++)
{
    int num = request();
    arrayNum[i] = num;
    if(num > 0)
    {      
        counter++;
    }
}
System.Console.WriteLine(string.Join(",", arrayNum));
System.Console.WriteLine(counter);
