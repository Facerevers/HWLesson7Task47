// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

void PrintMas(double[,] mas)
{
    for (int i = 0; i < mas.GetLength(0); i++)
    {
        for (int j = 0; j < mas.GetLength(1); j++)
        {
            Console.Write($"{mas[i,j]}\t");
        }
        Console.WriteLine();
    }
}

double[,] GenerateMas(int rows, int columns)
{
    double[,] mas = new double[rows,columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            mas[i,j] = Math.Round(new Random().NextDouble()*10,1);
        }
    }
    return mas;
}

int GetInput(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int rows = GetInput("Введите количество строк: ");
int columns = GetInput("Введите количество столбцов: ");
double[,] mas = GenerateMas(rows, columns);
Console.WriteLine($"m = {rows}, n = {columns}");
PrintMas(mas);