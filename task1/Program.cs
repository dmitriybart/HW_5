// Показать двумерный массив размером m×n заполненный вещественными числами
void FillMatrixRandom (double[,] matrix, double min, double max)
{
    var random = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = random.NextDouble()*((max+min)-min);
        }
    }
}
void PrintMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i,j]}\t");

        }
        Console.WriteLine(" ");
        Console.WriteLine(" ");
    }
    
}

Console.Clear();
int m,n;
m = int.Parse(Console.ReadLine() ?? "0");
n = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine(" ");
double[,] dubleArray = new double [m,n];
FillMatrixRandom(dubleArray, 5.293, 53.258);
PrintMatrix(dubleArray);