// Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] arr = new int[4, 4];
for (int i = 0; i < arr.GetLength(0); i++) // генерация рандомного массива
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        arr[i, j] = new Random().Next(0, 10);
    }
}
for (int i = 0; i < arr.GetLength(0); i++) //вывод рандома
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        Console.Write(arr[i, j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine();

for (int i = 0; i < arr.GetLength(1); i++)
{
    double average = 0;

    for (int j = 0; j < arr.GetLength(0); j++)
    {
        average = average + arr [j,i];
    }
    double x = (float)average / arr.GetLength(0);
    x = Math.Round(x, 1);
    Console.WriteLine();
    Console.WriteLine($" Среднее арифметическое элементов {i+1} столбца = {x}");
}