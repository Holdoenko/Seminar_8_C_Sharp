/*Задача 56: Задайте прямоугольный двумерный массив.
Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей
суммой элементов.*/

Console.Clear();

Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[rows, columns];

FillArray(array);
PrintArray(array);

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 9);
        }
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

int ResSumRows(int[,] array, int i)
{
    int sumRows = array[i, 0];
    for (int j = 1; j < array.GetLength(1); j++)
    {
        sumRows += array[i, j];
    }
    return sumRows;
}

int minSumRows = 0;
int sumRows = ResSumRows(array, 0);
for (int i = 1; i < array.GetLength(0); i++)
{
    int tempSumRows = ResSumRows(array, i);
    if (sumRows > tempSumRows)
    {
        sumRows = tempSumRows;
        minSumRows = i;
    }
}

Console.Write($"{minSumRows + 1}");
Console.WriteLine($" - строкa с наименьшей суммой элементов ({sumRows})");
