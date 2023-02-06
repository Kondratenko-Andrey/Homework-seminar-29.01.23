// Задать двумерный массив следующим правилом: Aₘₙ = m+n

void SpecialFillArr(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = i + j;
        }
    }

}

void PrintArr(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"[{i}, {j}] = {matrix[i, j]}   ");
        }

        Console.WriteLine();
    }

    Console.WriteLine();
}

Console.Write("Введите необходимое кол-во строк в формируемой матрице: ");
int m = int.Parse(Console.ReadLine()!);

Console.Write("Введите необходимое кол-во столбцов в формируемой матрице: ");
int n = int.Parse(Console.ReadLine()!);

int[,] arr = new int[m, n];

SpecialFillArr(arr);
PrintArr(arr);