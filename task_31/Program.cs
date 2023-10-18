// Задача 31: Задайте массив из N элементов, заполненный
// случайными числами из промежутка [-9, 9]. Найдите сумму
// отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма
// положительных чисел равна 29, сумма отрицательных равна
// -20.


int [] CreateArray(int lengthArr) {
    Random rnd = new Random();
    int [] array = new int [lengthArr];
    for(int i = 0; i < lengthArr; i++) 
    {
        array[i] = rnd.Next(-9, 10);
        System.Console.Write($"{array[i]}, ");
    }
    return array;
}


System.Console.Write("Введите числом длину массива: ");
int lengthArr = Convert.ToInt32(Console.ReadLine());
int [] arrayResult = CreateArray(lengthArr);

int sumNegativNum = 0;
int sumPositivNum = 0;

void sumArrayElem(int [] res) 
{
    for(int i = 0; i < res.Length;i++)
    {
        if(res[i] > 0)
        {
            sumPositivNum += res[i];
        }
        else
        {
            sumNegativNum += res[i];
        }
           
    }

    System.Console.WriteLine($"Сумма положительных чисел равна {sumPositivNum}, а сумма отрицательных чисел равна {sumNegativNum}");
}

sumArrayElem(arrayResult);


