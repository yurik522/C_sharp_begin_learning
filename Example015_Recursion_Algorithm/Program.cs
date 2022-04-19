// Создание и вывод 2-мерного строкового массива
// string[,] table = new string [3, 6];
// table[1, 3] = "super";
// for (int rows = 0; rows < 3; rows++)
//  {
//     for (int columns = 0; columns < 6; columns++)
//     {
//         Console.WriteLine($"{table[rows, columns]} - ");
//     }
//  }

// СОЗДАНИЕ И ВЫВОД 2-МЕРНОГО ЧИСЛОВОГО МАССИВА (МАТРИЦЫ)

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
 {
    for (int j = 0; j < matr.GetLength(1); j++)
    {
        Console.Write($"{matr[i, j]}, ");
    }
 Console.WriteLine();
 }
}
void FillArray(int[,] matr)
{
  for (int i = 0; i < matr.GetLength(0); i++)
 {
    for (int j = 0; j < matr.GetLength(1); j++)
    {
        matr[i, j] = new Random().Next(1, 20);
    }
  }  
}
int[,] matrix = new int [29, 29];

FillArray(matrix);
PrintArray(matrix);
Console.WriteLine();
//PrintArray(matrix);

