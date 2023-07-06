// Задача 2. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает 
//значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7->такого числа в массиве нет
// 0, 0 -> 1



Console.WriteLine("Введите номер строки");
int UserRows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер столбца");
int UserColomns = Convert.ToInt32(Console.ReadLine());


int[,] GenerateArray(int rows, int coloms)
{
    int[,] numbers = new int[rows, coloms];
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

void PrintArray(int[,] numbers)
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

bool ValidateArray(int UserRows, int UserColomns , int[,] array)
{

    if (UserRows > array.GetLength(0) || UserColomns > array.GetLength(1))
    {
        Console.WriteLine("Такого элемента нет");
        return false;
    }
    else
    {
        Console.WriteLine($"Значение элемента {UserRows} строки и {UserColomns} столбца равно {array[UserRows - 1, UserColomns - 1]}");
        return true; 
    }

}

int[,] array = GenerateArray(3, 3);
PrintArray(array);
ValidateArray(UserRows,UserColomns,array);





