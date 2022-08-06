// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки 
// с наименьшей суммой элементов: 1 строка

void findmin()
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
    int sum = 0;
    int sum1 = 0;
    int max = 0;
    int k = 0;
    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {          
            sum = array[i, j] + sum1;
            sum1 = sum; 
            if (sum > max || sum == max)
            {
                max = sum;
                k = i;
            }
        }
    Console.WriteLine($"сумма {i} строки - {sum}");   
    sum1 = 0;
    }
    Console.WriteLine($"строка {k} с максимальной суммой эллементов {max}");     
}
findmin();

