using System;

public class Answer
{
    public static void MultiplyIfPossible(int[,] matrixA, int[,] matrixB)
    {
        if (matrixA.GetLength(1) == matrixB.GetLength(0))
        {
            MatrixMultiplication(matrixA, matrixB);
        }
        else
        {
            Console.WriteLine("It is impossible to multiply.");
        }
    }

    public static int[,] MatrixMultiplication(int[,] matrixA, int[,] matrixB)
    {
        int[,] ResultMatrix = new int[matrixA.GetLength(0), matrixA.GetLength(1)];
        for (int i = 0; i < ResultMatrix.GetLength(0); ++i)
        {
            for (int j = 0; j < ResultMatrix.GetLength(1); ++j)
            {
                for (int k = 0; k < matrixA.GetLength(1); ++k)
                {
                    ResultMatrix[i, j] += matrixA[i, k] * matrixB[k, j];
                }
            }
        }
        PrintMatrix(ResultMatrix);
        return ResultMatrix;
    }
    
public static void PrintMatrix(int[,] matrix)
{
    for (int rows = 0; rows < matrix.GetLength(0); rows++)
    {
        for (int colymns = 0; colymns < matrix.GetLength(1); colymns++)
        {
            Console.Write($"{matrix[rows, colymns]}\t");
        }
        Console.WriteLine();
    }
}
// Не удаляйте и не меняйте метод Main! 
public static void Main(string[] args)
{
    int[,] matrix;

    if (args.Length == 0)
    {
        // Если аргументы не переданы, используем матрицу по умолчанию
        matrix = new int[,]
        {
                {1, 2},
                {3, 4}
        };
    }
    else
    {
        // Иначе, парсим аргументы в двумерный массив
        string[] rows = args[0].Split(';');
        matrix = new int[rows.Length, rows[0].Split(',').Length];
        for (int i = 0; i < rows.Length; i++)
        {
            string[] elements = rows[i].Split(',');
            for (int j = 0; j < elements.Length; j++)
            {
                if (int.TryParse(elements[j], out int number))
                {
                    matrix[i, j] = number;
                }
                else
                {
                    Console.WriteLine($"Ошибка при парсинге аргумента {elements[j]}.");
                    return;
                }
            }
        }
    }

    Console.WriteLine("Исходная матрица:");
    PrintMatrix(matrix);

    int[,] matrixB = {
            {5, 6},
            {7, 8}
        };

    Console.WriteLine("\nMatrix B:");
    PrintMatrix(matrixB);

    Console.WriteLine("\nMultiplication result:");

    MultiplyIfPossible(matrix, matrixB);
}
}

