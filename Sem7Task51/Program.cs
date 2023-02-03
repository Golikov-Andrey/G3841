int InputNum(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

int[,] Gen2DArr(int xlen, int ylen)
{
    int[,] arr = new int[ylen, xlen];
    for (int i = 0; i < ylen; i++)
    {
        for (int j = 0; j < xlen; j++)
        {
            arr[i, j] = j+i;
        }
    }
    return arr;
}

void Print2DArr(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + "\t");
        }
        Console.WriteLine("");
    }
}

int DiagSum(int[,] arr)
{
    int res =0;
    int min=arr.GetLength(0)>arr.GetLength(1)?arr.GetLength(1):arr.GetLength(0);

   for (int i = 0; i < min; i=i+1)
    {
        res = res+ arr[i, i];
    } 
    return res;
}


int xlen = InputNum("Ваше число столбцов: ");
int ylen = InputNum("Ваше число строк: ");
int[,] matrix = Gen2DArr(xlen, ylen);
Print2DArr(matrix);
int sumOfDiagonal = DiagSum(matrix);
Console.WriteLine(sumOfDiagonal);