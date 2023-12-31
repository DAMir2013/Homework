﻿using System;

public class Answer
{
    public static void PrintMatrix(int[,] matrix)
    {
        for (int rows = 0; rows < matrix.GetLength(0); rows++)
        {
            for (int columns = 0; columns < matrix.GetLength(1); columns++)
            {
                Console.Write($"{matrix[rows, columns]}\t");
            }
            Console.WriteLine();
        }

    }


    public static void SortRowsDescending(int[,] matrix)
    {
        for (int rows = 0; rows < matrix.GetLength(0); rows++)
        {
            int max;
            for (int columns = 0; columns < matrix.GetLength(1); columns++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[rows, columns] > matrix[rows, j])
                    {
                        max = matrix[rows, columns];
                        matrix[rows, columns] = matrix[rows, j];
                        matrix[rows, j] = max;
                    }
                }
            }

        }

    }
        // Не удаляйте и не меняйте метод Main! 
        public static void Main(string[] args)
        {
            int[,] matrix;
            if (args.Length == 0)
            {
                // Если аргументы не переданы, используем матрицу по умолчанию
                matrix = new int[,] {
                {5, 2, 9},
                {8, 1, 4},
                {6, 7, 3}
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
                    if (elements.Length != matrix.GetLength(1))
                    {
                        Console.WriteLine($"Ошибка: Неправильное количество элементов в строке {i + 1}.");
                        return;
                    }
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

            SortRowsDescending(matrix);

            Console.WriteLine("\nМатрица с упорядоченными по убыванию строками:");
            PrintMatrix(matrix);
        }
}
 
