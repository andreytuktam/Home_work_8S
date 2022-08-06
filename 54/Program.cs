// Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 1 2 4 7
// 2 3 5 9
// 2 4 4 8

void sortmaxmin()
{
    Console.WriteLine("введите колличество строк: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("введите колличество столбцов: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    int[,] array = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(0, 10);
            Console.Write(array[i, j] + "\t");
        } 
        Console.WriteLine();  
    }
    Console.WriteLine();

    for(int k = 0; k < rows; k++)
    {
        for(int s = 0; s < columns; s++)
        {
            for(int i = 0; i < rows; i++)
            {
                for(int j = 0; j < columns; j++)
                {
                    if(array[k, s] > array[i, j] && k == i)
                    {
                        int buf = array[k, s];
                        array[k, s] = array[i, j];
                        array[i, j] = buf;  
                    } 
                }
            }
        }
    }
    for (int k = 0; k < rows; k++)
    {
        for(int s = 0; s < columns; s++)
        {
            Console.Write(array[k, s] + "\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
sortmaxmin(); 




