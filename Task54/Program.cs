int[,] Random2dArray(int a, int b)
{
    while (a <= 0)
    {
        Console.Write("Невозможно построить двумерный массив с заданным количеством строк. Пожалуйста, повторите попытку: ");
        a = Convert.ToInt32(Console.ReadLine());
    }

    while (b <= 0)
    {
        Console.Write("Невозможно построить двумерный массив с заданным количеством столбцов. Пожалуйста, повторите попытку: ");
        b = Convert.ToInt32(Console.ReadLine());
    }

    int[,] new2dArray = new int[a, b];

    for (int i = 0; i < a; i++)
        for (int j = 0; j < b; j++)
            new2dArray[i, j] = new Random().Next(1, 11);

    return new2dArray;
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}  ");
        }
        Console.WriteLine();
    }
}

int[,] DescendingSort(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if(array[i,k] < array[i,k+1])
                {
                    int elem = array[i,k];
                    array[i,k] = array[i,k+1];
                    array[i,k+1] = elem;
                }
            }
        }
    }
    return array;
}


int m = new Random().Next(3, 11);
int n = new Random().Next(3, 11);

int[,] my2dArray = Random2dArray(m, n);

Console.WriteLine("Сгенерированный двумерный массив:");

Show2dArray(my2dArray);

int[,] sortsdArray = DescendingSort(my2dArray);

Console.WriteLine("Двумерный массив,отсортированный по убыванию: ");

Show2dArray(sortsdArray);
