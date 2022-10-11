/* Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

Console.Clear();
Console.Write("Количество строк:\t");
int rows = int.Parse(Console.ReadLine()!);

Console.Write("Количество столбцов:\t");
int columns = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(rows, columns, 0, 9); //Диапазон чисел не указан, взял от 0 до 9
PrintArray(array);

Console.WriteLine("Среднее арифметическое столбцов:");

double Average = ArithmeticAverageOfColumn(array);


double ArithmeticAverageOfColumn(int[,] array)
{
    double sum = 0;
    double res = 0;
    for(int j = 0; j < columns; j++)
    {
        for(int i = 0; i < rows; i++)
        {
            sum += array[i,j];
        }    
        res = Math.Round((sum / rows), 2);
        Console.Write($"{res}; ");
        sum = 0;
    }
    return res;
}


int[,] GetArray(int m, int n, int minValue, int maxValue) //двумерный массив по методу
{
    int[,] result = new int[m, n];
    for(int i = 0; i < m; i++) // строки
    {
        for(int j = 0; j < n; j++) // столбцы
        {
            result[i,j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}


void PrintArray(int[,] array) //вывод двумерного массива
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