
        // Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
        // 645 -> 5
        // 78 -> третьей цифры нет
        // 32679 -> 6
        Console.WriteLine("Введите число");
        int num = Convert.ToInt32(Console.ReadLine());
        if(num > -100 && num < 100)
        {
            System.Console.WriteLine("Третьей цифры нет");
        }
        if(num <= -100) {
            string str = Convert.ToString(num);
            System.Console.WriteLine(str[3]);
        }
        if(num >= 100) {
            string str = Convert.ToString(num);
            System.Console.WriteLine(str[2]);
        }