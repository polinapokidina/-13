const int N = 5;
var matrix = new int[N, N];
var random = new Random();

for (int a = 0; a < N; a++)
{
    for (int b = 0; b < N; b++)
    {
        matrix[a, b] = random.Next(-10, 10);
        Console.Write(matrix[a, b]);
        Console.Write("\t");
    }
    Console.WriteLine();
}

Console.WriteLine();

for (int a = 1; a < N; a++)
{
    for (int b = 0; b < a; b++)
    {
        if (matrix[a, b] < 0)
            matrix[a, b] = 0;
    }
}


for (int a = 0; a < N; a++)
{
    for (int b = 0; b < N; b++)
    {
        Console.Write(matrix[a, b]);
        Console.Write("\t");
    }
    Console.WriteLine();
}


Console.ReadLine();
