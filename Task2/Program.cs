// Задайте прямоугольный двумерный массив. 
//Напишите программу, которая будет находить строку с наименьшей суммой элементов.


Console.Clear();

 
int[,] matrix = new int[4, 2];
FillMatrix(matrix);
PrintMatrix(matrix);
Console.WriteLine();
Console.WriteLine(minString(matrix));



 
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

int minString (int[,] matrix)
{
    int sum = int.MaxValue;
    int index = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {   int temp = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            temp +=matrix[i, j];
        }
        if (temp < sum)
        {
            sum = temp;
            index = i + 1;
        }
    }
return(index);    
}



