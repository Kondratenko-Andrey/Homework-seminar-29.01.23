// Показать двумерный массив размером m×n заполненный вещественными числами

void FillArr(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = (new Random().NextDouble()) * 10;
        }
    }

}

void PrintArr(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}   ");
        }

        Console.WriteLine();
    }

    Console.WriteLine();
}

Console.Write("Введите необходимое кол-во строк в формируемой матрице: ");
int m = int.Parse(Console.ReadLine()!);

Console.Write("Введите необходимое кол-во столбцов в формируемой матрице: ");
int n = int.Parse(Console.ReadLine()!);

double[,] arr = new double[m, n];

FillArr(arr);
PrintArr(arr);

