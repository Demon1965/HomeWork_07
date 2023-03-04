/* Задача 50. Напишите программу, которая на вход принимает 
позиции элемента в двумерном массиве, и возвращает 
значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет */

int[,] CreateMatrix(int row, int column)
{
    int[,] matrix = new int[row, column];
    Random rnd = new Random();
    for(int i = 0; i < row; i++)
    {
        for(int j = 0; j < column; j++)
        {
            matrix[i,j] = rnd.Next(0, 10);
        }
    }   
    return matrix;
}

void PrintMatrix(int[,] matrix, int row, int column)
{
    for(int i = 0; i < row; i++)
    {
        for(int j = 0; j < column; j++)
        {
            Console.Write(matrix[i,j] + "    ");
        }
        Console.WriteLine();
    }
}  

void FindValue(int[,] matrix, int row, int column, int i1, int j1)
{
    if (i1>row || j1>column)
        {
            Console.Write($"There is no such position in this matrix!"); 
        }
    for (int i=0; i < row; i++)
    {
        for(int j=0; j < column; j++)
        {
            if (i==i1-1 && j==j1-1)
                {
                    Console.Write($"The value of number you position choosed is: " + matrix[i,j]);
                }
        }
    }  
}



System.Console.Write("Please, enter the number of rows: ");
int row = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Please, enter the number of columns: ");
int column = Convert.ToInt32(Console.ReadLine());
int[,] matrix = CreateMatrix(row, column);
PrintMatrix(matrix, row, column);
System.Console.Write("Please, enter the row of the number you've chosen: ");
int i1 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Please, enter the column of the number you've chosen: ");
int j1 = Convert.ToInt32(Console.ReadLine());
FindValue(matrix, row, column, i1, j1);