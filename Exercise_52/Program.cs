/* Задача 52. Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */

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

void NewArray(int[,] matrix, int row, int column)
    {
        double[] array = new double[column];
        int j=0;
        while (j<column)
        {
            double sum=0;
            for(int i = 0; i < row; i++)
            {
                sum+=matrix[i,j];
            }
            array[j]=Math.Round(sum/row,1);
            Console.Write(array[j] + "  ");
            j++;
        }
    }

System.Console.Write("Please, enter the number of rows: ");
int row = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Please, enter the number of columns: ");
int column = Convert.ToInt32(Console.ReadLine());
int[,] matrix = CreateMatrix(row, column);
PrintMatrix(matrix, row, column);
Console.WriteLine("---------------------");
NewArray(matrix, row, column);

