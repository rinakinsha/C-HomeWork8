int[,] Null2dArray(int a, int b) //Матрица заданной размерности, но заполненная одними 0
{
    int[,] new2dArray = new int[a, b];

    for (int i = 0; i < a; i++)
        for (int j = 0; j < b; j++)
            new2dArray[i, j] = 0;

    return new2dArray;
}

int[,] Spirall2dArray(int[,] array)
{
    int firstNum = 1; //с этого значения начинаем заполнять массив
    int finish = array.GetLength(0) * array.GetLength(1);
    int rememberRow = 0; // запоминание положения по строке
    int rememberCol = 0; // запоминание положения по столбцу

    while (firstNum <= finish)
    {
        while (rememberCol < array.GetLength(1) && array[rememberRow, rememberCol] == 0)
            array[rememberRow, rememberCol++] = firstNum++; // rememberCol+1 потому что, по идее, мы уже определили значение array[0,0] в 14 строке
        rememberRow++; // для исключения значений по 1 строке, которые мы уже изменили
        rememberCol--; // чтобы не выходить за пределы массива и ставить на нужную позицию

        while (rememberRow < array.GetLength(0) && array[rememberRow, rememberCol] == 0)
            array[rememberRow++, rememberCol] = firstNum++;
        rememberCol--;
        rememberRow--;

        while (rememberCol >= 0 && array[rememberRow, rememberCol] == 0) // >=0  т.к. идем от конца массива к началу, которе = 0 (без >= зациклит!)
            array[rememberRow, rememberCol--] = firstNum++;
        rememberRow--;
        rememberCol++;

        while (rememberRow >= 0 && array[rememberRow, rememberCol] == 0)
            array[rememberRow--, rememberCol] = firstNum++;
        rememberRow++;
        rememberCol++;
    }
    return array;
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

int m = new Random().Next(3, 11);
int n = new Random().Next(3, 11);

int[,] array2d = Spirall2dArray(Null2dArray(m, n));

Show2dArray(array2d);