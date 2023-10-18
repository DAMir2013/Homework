int [] arr = new int [9];
for(int i = 0; i < 9; i++)
{
    arr[i] = i + 1;
    System.Console.Write($"{arr[i]} ");
}

void reverseArray(int [] array)
{    int temp = 0;
    for(int i = 0; i < array.Length/2; i++)
    {
        temp = array[i];
        array[i] = array[array.Length - 1 - i];
        array[array.Length - 1 - i] = temp;
    }

}
reverseArray(arr);
System.Console.WriteLine("");
Console.WriteLine(string.Join(", ", arr));
