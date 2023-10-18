//*Дан текстю в тексте 
// 1.нужно все пробелы заменить "-"ж
// 2.нужно все маленькие "к" заменить на "К";
// 3."C" на "с";
string text = "я думаю, - сказал князь, улыбаясь, - что, " 
+ " ежели бы вас послали вместо нашего милого Винценгероде," 
+ " вы бы взяли приступом согласие прусского короля " 
+ "Вы так красноречивы, Вы дадите мне чаю? ";

string Replace(string text, char oldValue, char newValue) 
{   
    string result = String.Empty;
    int length = text.Length;
    for(int i = 0; i < length; i++)
    {
      if(text[i] == oldValue)
      {
        result = result + newValue;
      }  
      else 
      {
        result = result + text[i];
      }    
    }
    System.Console.WriteLine(text.Length);
    return result;
}
string newText = Replace(text, ' ', '-');
System.Console.WriteLine(newText);
System.Console.WriteLine(" ");
newText = Replace(newText, 'к', 'К');
System.Console.WriteLine(newText);
System.Console.WriteLine(" ");
newText = Replace(newText, 'С', 'с');
System.Console.WriteLine(newText);
System.Console.WriteLine(" ");
