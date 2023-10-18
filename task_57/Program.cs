int[,] FillMatrix(int m, int n)
{
    int[,] matrix = new int[m, n];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(1, 10);
        }

    }
    return matrix;
}
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write($"{matrix[i, j]} ");
        }
        System.Console.WriteLine();
    }
}
System.Console.WriteLine("Введите число m:");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите число n:");
int n = Convert.ToInt32(Console.ReadLine());

int[,] matrix = FillMatrix(m, n);
PrintMatrix(matrix);

int[] checkValue(int [,] array)
{
int [] arrValueCount = new int[9];
  for(int step = 1; step <= 9; step++)
{
    int count = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if(array[i,j] == step)
            {
                count++;
            }
             
        }
    }

    arrValueCount[step - 1] = count;
}
 return arrValueCount;
}
int[] array = checkValue(matrix);
for(int i = 0; i < array.Length; i++)
{
    if(array[i] > 0)
    {
        System.Console.WriteLine($"{i + 1} встречается {array[i]} раз\t");
    }
}

