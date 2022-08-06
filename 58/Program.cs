// Задача 58: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.
// Например, заданы 2 массива:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// и
// 1 5 8 5
// 4 9 4 2
// 7 2 2 6
// 2 3 4 7
// Их произведение будет равно следующему массиву:
// 1 20 56 10
// 20 81 8 6
// 56 8 4 24
// 10 6 24 49

void multiplication()
{
    Console.WriteLine("введите колличество строк: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("введите колличество столбцов: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    int[,] arrayone = new int[rows, columns];
    int[,] arraytwo = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            arrayone[i, j] = new Random().Next(0, 10);
            Console.Write(arrayone[i, j] + "\t");
        } 
        Console.WriteLine(); 
    }
    Console.WriteLine();
    for (int k = 0; k < rows; k++)
    {
        for (int l = 0; l < columns; l++)
        {
            arraytwo[k, l] = new Random().Next(0, 10);
            Console.Write(arraytwo[k, l] + "\t");
        } 
        Console.WriteLine(); 
    }
    Console.WriteLine();
    int[,] arraysum = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            arraysum[i, j] = arraytwo[i, j] * arrayone[i, j];
            Console.Write(arraysum[i, j] + "\t"); 
        }
        Console.WriteLine(); 
    }
    Console.WriteLine();
}
multiplication();
