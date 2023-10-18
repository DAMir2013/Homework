using System;

public class Answer {
    public static void PrintArray (int [,] matrix)
    {
      for(int i = 0; i < matrix.GetLength(0); i ++)
      {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
          System.Console.Write($"{matrix[i, j]}\t");
        }
        System.Console.WriteLine("");
      }
    }
  
    public static int[,] CreateIncreasingMatrix(int n, int m, int k)
    {
      int count = 1;
      int [,] arrayNum = new int[n, m];
      for(int i = 0; i < arrayNum.GetLength(0); i ++)
      {
        for (int j = 0; j < arrayNum.GetLength(1); j++)
        {
          arrayNum[i, j] = count;
          count += k;
        }
      }
      return arrayNum;
    }
  
    static void PrintListAvr (double [] list)
    {
      System.Console.WriteLine("The averages in columns are:");
      for (int i = 0; i < list.Length; i++)
      {
        decimal Debitvalue = Decimal.Parse(list[i].ToString("0.00"));
        System.Console.Write($"{Debitvalue}\t");
      }


    }

    static double [] FindAverageInColumns (int [,] matrix)
    { 
      double [] arrAverage = new double [matrix.GetLength(1)];
      for (int columns = 0; columns < matrix.GetLength(1); columns++)
      { 
        double sumColumnsAverage = 0;
        for (int rows = 0; rows < matrix.GetLength(0); rows++)
        {
          sumColumnsAverage += matrix[rows, columns];
        }
        arrAverage[columns] = sumColumnsAverage/matrix.GetLength(0);
      }
        return arrAverage;
    }


    // Не удаляйте и не меняйте метод Main! 
    static public void Main(string[] args) {
        int n, m, k;

        if (args.Length >= 3) {
           n = int.Parse(args[0]);
           m = int.Parse(args[1]);
           k = int.Parse(args[2]);
        } else {
           // Здесь вы можете поменять значения для отправки кода на Выполнение
           n = 3;
           m = 4;
           k = 2;
        }

        // Не удаляйте строки ниже
        int[,] result = CreateIncreasingMatrix(n, m, k);
        PrintArray(result);
        PrintListAvr(FindAverageInColumns(result));
        
    }
}