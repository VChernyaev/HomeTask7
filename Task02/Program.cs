// программа которая на вход принимает позиции элемента в дувмерном массиве
// и возвращает значение этого элемента или же указание что такого элемента нет


int rows = new Random().Next(3, 6);
int colum = new Random().Next(3, 6);
int[,] array = new int[rows, colum];
CreateArray(array);
PrintArray(array);
Console.WriteLine("Введите номер строки ");
int num1 = Convert.ToInt32(Console.ReadLine())-1;
Console.WriteLine("Введите номер столбца ");
int num2 = Convert.ToInt32(Console.ReadLine())-1;

FindElement(array);


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

void FindElement(int[,] array)
{
    if(num1<array.GetLength(0) && num2<array.GetLength(1))
    {
        Console.Write($"{array[num1,num2]}");
    }
    else
    {
        Console.WriteLine("такого числа нет в массиве");
    }
    
         
            
            
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
