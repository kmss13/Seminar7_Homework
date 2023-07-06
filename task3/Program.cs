// Задача 3. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] GenerateArray2D(int rows, int columns)
{
    int[,] numbers = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            numbers[i, j] = rnd.Next(0, 10);
        }
    }
    return numbers;
}

void PrintArray2D(int[,] numbers)
{
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            System.Console.Write($"{numbers[i, j]}\t");
        }
        System.Console.WriteLine();
    }
}

double AverageArray(int[,] arr, int UserColomns)
{
    double sum = 0;
    double avarage = 0;
    int size = arr.GetLength(1);

    
        for (int i = 0; i < arr.GetLength(0); i++)
        {

            for (int j = 0; j < arr.GetLength(1); j++)
            {
                sum += arr[j,i];

            }
        Console.WriteLine(sum);
            avarage += sum / arr.GetLength(1);
        }
       
    return avarage;
}


Console.WriteLine("Введите кол-во строк");
int UserRows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кол-во столбцов");
int UserColomns = Convert.ToInt32(Console.ReadLine());
int[,] array = GenerateArray2D(UserRows, UserColomns);
Console.WriteLine();
    PrintArray2D(array);
double output = AverageArray(array, UserColomns);
    Console.WriteLine($"Среднее арифметическое чисел равно => {output}");