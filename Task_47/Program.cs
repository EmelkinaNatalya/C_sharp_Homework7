// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.


double [,] matrix = new double [3,4];
// PrintArray (matrix);
FillArray (matrix, 1 , 9);
// Console.WriteLine();
PrintArray (matrix);



void PrintArray(double[,] matr)
{
    for (int i=0; i< matr.GetLength(0); i++)
    {
        for (int j =0; j< matr.GetLength(1); j++)
        {
            Console.Write($"{Math.Round(matr[i,j], 2)} ");
        }
        Console.WriteLine();
    }
}


void FillArray(double[,] matr, int start, int end)
{
    for (int i=0; i< matr.GetLength(0); i++)
    {
        for (int j =0; j< matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().NextDouble()*new Random().Next(1, 10);
            
       
        }
    }
}

