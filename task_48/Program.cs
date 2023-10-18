int[,] FillMatrix(int row, int columns) 
{
    int [,] matr = new int[row, columns];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = i + j;
        }
    }
    return matr;
}
void showArr(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            System.Console.Write($"{matr[i, j]} ");
        }
        System.Console.WriteLine();
    }
}

System.Console.WriteLine("Введите число строк");
int row = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите число столбцов");
int columns = Convert.ToInt32(Console.ReadLine());
int [,] matrix = FillMatrix(row, columns); 
showArr(matrix);
