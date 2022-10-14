// Задайте двумерный массив. 
// Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

Console.Clear();

 
int[,] matrix = new int[5, 5];
FillMatrix(matrix);
PrintMatrix(matrix);
Console.WriteLine();
ArrangeElements (matrix); 
PrintMatrix(matrix);

 
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        
            {
                Console.Write(matrix[i, j] + " ");
            }
        Console.WriteLine();
    }
}
 
void FillMatrix(int[,] matrix)
{
    Random generator = new Random();
 
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        
            {
                matrix[i, j] = generator.Next(0,10);
            }
    }
}

void ArrangeElements (int[,] matrix)

{   for (int k = 0; k < matrix.GetLength(0); k++)
    {   
        for (int i = 0; i < matrix.GetLength(1); i++)
        {

            for (int j = i + 1; j < matrix.GetLength(1); j ++)
        {
            if (matrix[k, i] < matrix[k, j])
        {
            int n = matrix[k, i];
            matrix[k, i] = matrix[k, j];
            matrix[k, j] = n;
        }
        }
        }
    }    
}
