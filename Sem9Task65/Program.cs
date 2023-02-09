
// ---------------------------------------------------------------------
//                                 Задача 65
// Задайте значения M и N. Напишите программу, которая найдёт все натуральные элементы в промежутке от M до N.
// ---------------------------------------------------------------------

// Чтение данных из консоли
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// Печать результата
void PrintResult(string prefix)
{
    Console.WriteLine(prefix);
}

string RecLineMN(int m, int n)
{
    if (m >= n)
    {
        return n.ToString();
    }
    else
    {
        return m + " " + RecLineMN(m + 1, n);
    }
}


// 1 - вызов
// string RecLineMN(10, 5)
// {
//     if (10 >= 5)
//     {
//         return 5.ToString();
//     }
//     else
//     {
//         return 5 + " " + 6 + " " + 7 + " " + 8 + " " + 9 + " " + 10;
//     }
// }
// 2 - вызов
// string RecLineMN(6, 10)
// {
//     if (6 >= 10)
//     {
//         return n.ToString();
//     }
//     else
//     {
//         return 6 + " " + 7 + " " + 8 + " " + 9 + " " + 10;
//     }
// }
// 3 - вызов
// string RecLineMN(7, 10)
// {
//     if (7 >= 10)
//     {
//         return n.ToString();
//     }
//     else
//     {
//         return 7 + " " + 8 + " " + 9 + " " + 10;
//     }
// }
// 4 - вызов
// string RecLineMN(8, 10)
// {
//     if (8 >= 10)
//     {
//         return n.ToString();
//     }
//     else
//     {
//         return 8 + " " + 9 + " " + 10;
//     }
// }
// 5 - вызов
// string RecLineMN(9, 10)
// {
//     if (9 >= 10)
//     {
//         return n.ToString();
//     }
//     else
//     {
//         return 9 + " " + 10;
//     }
// }
// 6 - вызов
// string RecLineMN(10, 10)
// {
//     if (10 >= 10)
//     {
//         return 10.ToString();
//     }
//     else
//     {
//         return m + " " + RecLineMN(m + 1, n);
//     }
// }




int numM = ReadData("Введите число M: ");
int numN = ReadData("Введите число N: ");

string res = numM<numN? RecLineMN(numM,numN):RecLineMN(numN,numM);
PrintResult(res);