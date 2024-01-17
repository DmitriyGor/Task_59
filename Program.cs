/*
Задача 59: 
Задайте двумерный массив из целых чисел. 
Напишите программу, которая удалит строку и столбец, 
на пересечении которых расположен наименьший элемент массива.
*/
// Метод для создания массива
// Двумерный массив = matrix
// m - количество строчек, n - количество столбцов

Console.Write("Введите количество строчек : ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов : ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное число диапазона чисел из которого будут заполнены элементы массива  : ");
int minElements = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное число диапазона чисел из которого будут заполнены элементы массива  : ");
int maxElements = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[rows, columns]; // minElements, maxElements;
// rows = 3 columns = 4 => таблица из 3-х строк и 4 -х столбцов, элемент: число от min до max включительно
int min = int.MaxValue;
int rowIndexOfMinValue = 0;
int columnIndexOfMinValue = 0;

for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        array[i, j] = new Random().Next(minElements, maxElements+1);
        // Числа от minElement до maxElements включительно
        Console.Write(array[i, j] + "\t");
        if (min > array[i, j])
        {
            min = array[i, j]; // 2147483647 > 10? min = 10
            rowIndexOfMinValue = i;
            columnIndexOfMinValue = j;
        }
    }
    Console.WriteLine();
}
Console.WriteLine($"min: {min}, координаты: ({rowIndexOfMinValue}, {columnIndexOfMinValue})");
Console.WriteLine();
for (int i = 0; i < rows; i++)
{
    if (rowIndexOfMinValue!=i) // исключили строчку с min элементом
    {
        for (int j = 0; j < columns; j++)
        {
           if (columnIndexOfMinValue!=j) // исключили столбец с min элементом
           {
            Console.Write(array[i, j] + "\t");
           } 
        }
    }
    Console.WriteLine();
}
