// Задайте двумерный массив размером m×n, заполненный
// случайными вещественными числами от -10,0 до 10,0.
// m = 3, n = 4.
// 0,5 7,0 -2,0 -0,2
// 1,0 -3,3 8,0 -9,9
// 8,0 7,8 -7,1 9,0

double[,] arr = new double[3, 4];
for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        arr[i, j] = new Random().Next(-10, 10) + new Random().NextDouble();
        arr[i,j] = Math.Round(arr[i,j], 1);
    }
}
for (int i = 0; i < arr.GetLength(0); i++) //вывод
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        Console.Write(arr[i, j] + " ");
    }
    Console.WriteLine();
}
