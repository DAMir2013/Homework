﻿int[,] FillMatrix(int m, int n)
{
    int[,] matrix = new int[m, n];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(0, 10);
        }
    }
    return matrix;
}
void ChangeMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i+= 2)
    {
        for (int j = 0; j < matrix.GetLength(1); j+=2)
        {
            matrix[i, j] = matrix[i, j] * matrix[i, j];
        }
    }
    System.Console.WriteLine();
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
ChangeMatrix(matrix);
PrintMatrix(matrix);
