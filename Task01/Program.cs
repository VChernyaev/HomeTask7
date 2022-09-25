// двумерный массив размером m*n, заполненный случайными вещественными числами
int rows = new Random().Next(3,6);
int lines = new Random().Next(3,6);
double [,] array = new double[rows,lines];
CreateArray(array);
PrintArray(array);

void CreateArray (double [,] array)
{
    for(int i=0; i<array.GetLength(0); i++)
    {
        for(int j = 0; j<array.GetLength(1); j++)
        {
            array[i,j]= new Random().NextDouble();

        }
    }
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}; ");
        }
        Console.WriteLine();
    }
}
