// В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты

void FillArr(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(10);
        }
    }

}

void PrintArr(int[,] matrix)
{

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
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

Console.WriteLine("Сформированный исходный массив имеет вид:");
Console.WriteLine();

FillArr(arr);
PrintArr(arr);

for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        if (i % 2 == 0 && j % 2 == 0) arr[i, j] = arr[i, j] * arr[i, j];
    }
}

Console.WriteLine("Заменили элементы, у которых оба индекса чётные на их квадраты:");
Console.WriteLine();

PrintArr(arr);