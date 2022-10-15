// Задайте две матрицы. 
//Напишите программу, которая будет находить произведение двух матриц.

Console.Clear();

int[,] matrix1 = new int[2, 2];
int[,] matrix2 = new int[2, 2];

FillMatrix(matrix1);
PrintMatrix(matrix1);
Console.WriteLine();
FillMatrix(matrix2);
PrintMatrix(matrix2);
Console.WriteLine();
if (matrix1.GetLength(0) != matrix2.GetLength(1))
{
    Console.WriteLine("Нельзя умножить матрицы");
    return;
}
PrintMatrix(matrixMultiplication(matrix1,matrix2));

 
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


int [,] matrixMultiplication (int[,] matrix1, int[,] matrix2)

{   
    int[,] matrixC = new int[matrix1.GetLength(0), matrix2.GetLength(1)]; 
        for (int i = 0; i < matrix1.GetLength(0); i++)
        {

            for (int j = 0; j < matrix2.GetLength(1); j++)
        {   
            
            for (int k = 0; k < matrix1.GetLength(1); k++)
        {  
            matrixC[i, j] += matrix1[i, k] * matrix2[k, j];
        }
        }
        }
return matrixC;        
}

