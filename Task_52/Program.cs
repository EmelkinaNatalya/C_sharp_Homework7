// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int [,] matrix = new int [4,3];
FillArray (matrix, 1 , 9);
PrintArray (matrix);
Console.WriteLine();
Average (matrix);


void PrintArray(int[,] matr)
{
    for (int i=0; i< matr.GetLength(0); i++)
    {
        for (int j =0; j< matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i,j]} ");
        }
        Console.WriteLine();
    }
}


void FillArray(int[,] matr, int start, int end)
{
    for (int i=0; i< matr.GetLength(0); i++)
    {
        for (int j =0; j< matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 9);
            
       
        }
    }
}



void Average(int[,] matr)
{
    for (int j=0; j< matr.GetLength(1); j++)
    {
        double sum = 0;
        for (int i =0; i< matr.GetLength(0); i++)
        {
            sum += matr [i, j];
            
            
        }
        double average = Math.Round(sum/matr.GetLength(0), 1);
        Console.WriteLine($"Среднее арифметическое {j+1} столбца равна: {average}");
    }
}
