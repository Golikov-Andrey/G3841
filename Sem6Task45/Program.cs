


// int length = ReadData("Задайте длину массива: ");
// int[] array = CreateRandomArray(length);
// Print1DArray(array);
// PrintResult("Копия массива");
// Print1DArray(MakeArrayCopy(array));

// PrintResult("Копия массива Clone");
// Print1DArray((int[])array.Clone());


// // Получение данных от пользователя и преобразование в число
// int ReadData(string text)
// {
//   Console.Write(text);
//   int number = int.Parse(Console.ReadLine()??"0");
//   return number;
// }

// // Вывод результата в консоль
// void PrintResult(string data)
// {
//     Console.WriteLine(data);
// }

// // Создание и заполнение массива числами
// int[] CreateRandomArray(int leng)
// {
//     int[] array = new int[leng];
//     Random rnd = new Random();

//     for (int i = 0; i < leng; i++)
//     {
//         array[i] = rnd.Next(-1000, 1000);
//     }
//     return array;
// }

// // Вывод массива в консоль
// void Print1DArray(int[] arr)
// {
//     Console.WriteLine($"Массив: [{string.Join(", ", arr)}]");
// }

// int[] MakeArrayCopy(int[] arr)
// {
//   int[] rev = new int[arr.Length];
//   for(int i = 0; i < arr.Length; i++)
//   {
//     rev[i] = arr[i];
//   }
//   return rev;
// }

// №41 Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл 
// пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3
// * Пользователь вводит число нажатий, затем программа следит за нажатиями и 
// выдает сколько чисел больше 0 было введено.

// №36 Задайте одномерный массив, заполненный случайными числами. Найдите сумму
// элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [3, 7, -2, 1] -> 8
// [-4, -6, 89, 6] -> 0


// Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}
// печать результата
void PrintData (string prefix, string data) //разбили на две части вывод в консоль
{
     Console.WriteLine(prefix + data); //сначала выводим prefix + а потом данные data\
}
// Поиск точки пересечения двух прямых
double[] PointFind (int k1, int b1, int k2, int b2)
{
    double[] outArr = new double[2];
    double x = (double)(b2 - b1) / (double)(k1 - k2);
    double y = k1 * x + b1;
    outArr[0] = x;
    outArr[1] = y;
    return outArr;
}
//Ввод значения k1, b1, k2, b2
int k1 =ReadData("Введите значение k1:");
int b1 =ReadData("Введите значение b1:");
int k2 =ReadData("Введите значение k2:");
int b2 =ReadData("Введите значение b2:");

//Вычисляем точку пересечения
double[]Point = PointFind (k1, b1, k2, b2);
//Выводим на экран координату точки пересечения
PrintData ("Точка пересечения двух прямых: ", $"({Point[0]};{Point[1]})");

// но почему то не получается то что надо..