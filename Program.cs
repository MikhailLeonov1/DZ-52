Random random = new Random();
int[,] arr = new int[random.Next(1, 10), random.Next(1, 10)];
for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        arr[i, j] = random.Next(1, 10);
        Console.Write(arr[i, j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine(arr.GetLength(0));
for (int j = 0; j < arr.GetLength(1); j++)
{
    double x = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        x += arr[i, j];
    }
    Console.Write($"{ x / arr.GetLength(0)} ");
}
Console.ReadLine();