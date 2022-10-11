/* Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
*/

Console.Clear();
Console.Write("Введите количество строк:\t");
int rows = int.Parse(Console.ReadLine()!);

Console.Write("Введите количество столбцов:\t");
int columns = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(rows, columns, -10, 10); // Диапазон чисел в задаче не указан, взял произвольные числа от -10 до 10
PrintArray(array);


int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for(int i = 0; i < m; i++) 
    {
        for(int j = 0; j < n; j++) 
        {
            result[i,j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}


void PrintArray(int[,] array) 
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}