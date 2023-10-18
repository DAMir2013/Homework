﻿using System;

public class Answer
{
    private static double Length(int[] pointA, int[] pointB)
    {
      static double DistanceBetweenPoints(int [] pointA, int [] pointB)
      {
        double result = 0;
        double sumPow = 0;
        for(int i = 0; i < pointA.Length; i++)
        {
          sumPow += Math.Pow(pointB[i] - pointA[i], 2);
        }
        result = Math.Round(Math.Sqrt(sumPow), 2);
        return result;
      }

        double res = DistanceBetweenPoints(pointA, pointB);
        return res;
    }

  // Не удаляйте и не меняйте метод Main! 
    public static void Main(string[] args) {
        int x1, x2, x3, y1, y2, y3;

        if (args.Length >= 6) {
            x1 = int.Parse(args[0]);
            x2 = int.Parse(args[1]);
            x3 = int.Parse(args[2]);
            y1 = int.Parse(args[3]);
            y2 = int.Parse(args[4]);
            y3 = int.Parse(args[5]);
        } else {
           // Здесь вы можете поменять значения для отправки кода на Выполнение
            x1 = 3;
            x2 = 6;
            x3 = 8;
            y1 = 2;
            y2 = 1;
            y3 = -7;
        }

        // Не удаляйте строки ниже
        double result = Length(new int[]{x1, x2, x3}, new int[]{y1, y2, y3});
        Console.WriteLine($"{result:F2}");
    }
}