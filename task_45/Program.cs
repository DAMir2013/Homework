Console.WriteLine("Введите длину массива");
int lengthArr = Convert.ToInt32(Console.ReadLine());

int [] massive = new int[lengthArr];

void fillMass(int [] mass) 
{
    for(int i = 0; i < mass.Length; i++)
    {
        mass[i] = new Random().Next(1, 11);
        
    }
    System.Console.Write(string.Join(", ", massive));
}
fillMass(massive);
int [] massiveNew = new int[lengthArr];
for(int j = 0; j < massiveNew.Length; j++)
{
    massiveNew[j] = massive[j];
}
System.Console.WriteLine(" ");
System.Console.Write(string.Join(", ", massiveNew));
