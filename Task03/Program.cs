// задайте двумерный массив из целых чисел
// найдите среднее арифметическое элементов в каждом столбце

int rows = new Random().Next(3, 6);
int lines = new Random().Next(3, 6);
int[,] array = new int[rows, lines];
CreateArray(array);
PrintArray(array);
Console.Write($"{SumArithmetic(array)}");

void CreateArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);

        }
    }
}

int SumArithmetic(int[,] array)
{
    int sum = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum += array[i, j];
        }
    }
    return sum/array.GetLength(0);
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}
