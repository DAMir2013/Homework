// string[,]table = new string[2,5];
// table[1,2] = "слово";

// for(int row = 0; row < 2; row++) {
//     for (int columns =0; columns < 5; columns++)
//     {
//         Console.WriteLine($"{table[row, columns]}123");
//     }
// }

// void getPrintArray(int[,] matrix)
// {

// for(int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         Console.Write($"{matrix[i,j]} ");
//     }
//     System.Console.WriteLine();
// }
// }
// getPrintArray(matr);
int[,] matr = new int[3,4];
void fillArray(int [,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10);
            System.Console.Write($"{matr[i, j]} ");
        }
        System.Console.WriteLine(" ");
    }
}

fillArray(matr);