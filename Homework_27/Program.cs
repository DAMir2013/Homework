using System.Dynamic;
using System.Text.RegularExpressions;
using System;
// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12 
static int retSumOfNum(string strNum) 
{
    int resSum = 0;
    for(int i = 0; i < strNum.Length;i++)
    {   
        char ch = strNum[i];
        int intVal = (int)Char.GetNumericValue(ch);
        resSum += intVal;
    }
    return resSum;
}

Console.Write("Введите число: ");
int num = Math.Abs(Convert.ToInt32(Console.ReadLine()));
string str = Convert.ToString(num);
int result = retSumOfNum(str);
System.Console.WriteLine(result);