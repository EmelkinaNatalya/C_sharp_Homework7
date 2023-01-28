// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.


int [,] matrix = new int [5,5];
FillArray (matrix, 1 , 99);
PrintArray (matrix);



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
            matr[i, j] = new Random().Next(1, 99);
            
       
        }
    }
}


Console.WriteLine ("Введите координату i для значения в массиве:");
int a = Convert.ToInt32 (Console.ReadLine());

Console.WriteLine ("Введите координату j для значения в массиве:");
int b = Convert.ToInt32 (Console.ReadLine());

 void FindNumber(int[,] matr, int I, int J)
 {
    if (I > matr.GetLength(0) || J > matr.GetLength(1))
        {
            Console.WriteLine ($"В заданном массиве нет элемента с введёнными координатами {I}, {J}.");
        }   
    for (int i=0; i< matr.GetLength(0); i++)
    {
        for (int j =0; j< matr.GetLength(1); j++)
        {
            if (I-1 == i && J-1 == j)
            {
                
                Console.WriteLine ($"Значение искомого элемента, с координатами {I}, {J} равно: {matr[i, j]}");
            }   
        }
    }
 }

FindNumber (matrix, a , b);
