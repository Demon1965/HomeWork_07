/* Задача 47. Задайте двумерный массив размером m×n,
заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9 */

double[,] CreateMatrix(int row, int column)
{
    double[,] matrix = new double[row, column];
    Random rnd = new Random();
    for(int i = 0; i < row; i++)
    {
        for(int j = 0; j < column; j++)
        {
            matrix[i,j] = Math.Round(rnd.NextDouble()*20-10, 1); // Вроде как должен быть интервал от -10 до 10!
        }
    }   
    return matrix;
}

void PrintMatrix(double[,] matrix, int row, int column)
    {
        for(int i = 0; i < row; i++)
        {
            for(int j = 0; j < column; j++)
        {
        System.Console.Write(matrix[i,j] + "   ");
    }
        Console.WriteLine();
    }
}

System.Console.Write("Please, enter the number of rows: ");
int row = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Please, enter the number of columns: ");
int column = Convert.ToInt32(Console.ReadLine());
double[,] matrix = CreateMatrix(row, column);
PrintMatrix(matrix, row, column);

// Есть вопрос. Матрица с вещественными числами!  Почему целые числа выводяится как 5 или 8, а не как 5,0 и 8,0?