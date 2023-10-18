Console.WriteLine("Введите первое число");
int num = Convert.ToInt32(Console.ReadLine());
int [] arrFib = new int [num];

void showFib(int num)
{
    if(num < 2)
    {
        System.Console.WriteLine("Число слишком короткое");
    }
    else
    {
        arrFib[0] = 0;
        arrFib[1] = 1;
        for(int i = 2; i < num; i++)
        {
            arrFib[i] = arrFib[i - 1] + arrFib[i - 2];
        }
    }

}

showFib(num);
System.Console.WriteLine(string.Join(",", arrFib));