/* Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

i = 4, j = 2 -> такого числа в массиве нет
i = 1, j = 2 -> 2
*/

Console.Clear();
Console.Write("Введите количество строк:\t");
int rows = int.Parse(Console.ReadLine()!);

Console.Write("Введите количество столбцов:\t");
int columns = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(rows, columns, -10, 10); // Диапазон чисел в задаче не указан, взял произвольные числа от -10 до 10
PrintArray(array);

Console.Write("\nВведите строку искомого элемента:\t");
int positionRow = int.Parse(Console.ReadLine()!);

Console.Write("Введите столбец искомого элемента:\t");
int positionColumn = int.Parse(Console.ReadLine()!);

if ((positionRow < rows) && (positionColumn < columns))
{
    Console.WriteLine($"\nЭлемент в указанной строке и столбце: {array[positionRow, positionColumn]}");
}
else
{
    Console.WriteLine("\nУказанного элемента в массиве нет");
}



int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for(int i = 0; i < m; i++) 
    {
        for(int j = 0; j < n; j++) 
        {
            result[i,j] = new Random().Next(minValue, maxValue + 1); //массив заполняем случайными числами
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