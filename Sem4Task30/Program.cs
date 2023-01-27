// //Задача №30
// //Напишите программу, которая выводит массив из 8 элементов, 
// //заполненный нулями и единицами в случайном порядке.

// //Метод читает данные от пользователя
// int ReadData(string msg)
// {
//     Console.WriteLine(msg);
//     return int.Parse(Console.ReadLine() ?? "0");
// }

// int[] Gen1DArr(int num, int begin, int end)
// {
//     Random rnd = new Random();
//     int[] arr = new int[num];
//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = rnd.Next(begin, end);
//     }
//     return arr;
// }

// void Print1DArr(int[] arr)
// {
//     Console.Write("[");
//     for (int i = 0; i < arr.Length-1; i++)
//     {
//         Console.Write(arr[i]+", ");
//     }
//     Console.WriteLine(arr[arr.Length-1]+"]");
// }

// int arrLen = ReadData("Введите длину массива.");

// int[] arr = Gen1DArr(arrLen, 0, 2);

// Print1DArr(arr);

int InputNum(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}
int xlen = InputNum("Ваше число X: ");
int ylen = InputNum("Ваше число Y: ");
Random rnd = new Random();
int[,] createArray(int xlen, int ylen)
{
    int[,] arr = new int[xlen, ylen];
    for (int i = 0; i < xlen; i++)
    {
        for (int j = 0; j < ylen; j++)
        {
            arr[i, j] = rnd.Next(-999, 999);
        }
    }
    return arr;
}
void showArray(int[,] arr)
{
    for (int i = 0; i < xlen; i++)
    {
        for (int j = 0; j < ylen; j++)
        {
            
        Console.Write(arr[i,j]+"\t");
        }
        Console.WriteLine("");
    }
}
showArray(createArray(xlen, ylen));

