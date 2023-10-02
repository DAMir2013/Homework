Console.Write("Задайте длину, сгенерированого массива: ");
int lengt = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(lengt);

int [] createArr(int num) {
    int [] resultArr = new int [num];
    for(int i = 0; i < num; i++) 
    {
        resultArr[i] = new Random().Next(0,101);
    }
    return resultArr;

}
int [] arr = createArr(lengt);

void showArr(int [] array) {
    for(int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]}, ");
    }
} 
showArr(arr); 