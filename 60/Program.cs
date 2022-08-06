// Задача 60. Сформируйте трёхмерный массив из неповторяющихся 
// двузначных чисел. Напишите программу, которая будет построчно 
// выводить массив, добавляя индексы каждого элемента.
// массив размером 2 x 2 x 2
// 12(0,0,0) 22(0,0,1)
// 45(1,0,0) 53(1,0,1)

void cubik()
{
    Console.WriteLine("введите колличество cub: ");
    int cub = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("введите колличество строк: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("введите колличество столбцов: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    int[,,] arrayone = new int[cub, columns, rows];
    //Random rnd = new Random();
    int s = 10;
    for (int i = 0; i < cub; i++)
    {
        for (int j = 0; j < rows; j++)
        {
            for (int k = 0; k < columns; k++)
            {
                arrayone[i, j, k] = s; //new Random().Next(10, 100);
                Console.Write($"{arrayone[i, j, k]} ({i}, {j}, {k})" + "\t");
                s++;
            }
            Console.WriteLine(); 
        } 
        Console.WriteLine();
    }
    Console.WriteLine();
}
cubik();