int [] randMass()
{
    int [] arr = new int[10];
    Random rnd = new Random();
    for(int i = 0; i < 10; i++)
    {
        arr[i] = rnd.Next(-100, 101);
    }
    return arr;
}

int [] arrStart = randMass();
System.Console.WriteLine(string.Join(",", arrStart));
int [] arrEnd = new int[10];
for(int i = 0; i < 10; i++)
{
    arrEnd[i] = -arrStart[i];
}
System.Console.WriteLine(string.Join(",", arrEnd));