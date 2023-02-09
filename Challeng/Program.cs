/*
Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
Задача будет решена для квадратных матриц любой размерности 
*/

// собираем данные от пользователя:
int size = TakeIntData("Введите размерность квадратной матрицы: ");

//DrawMatrix(MakeSpiralMatrix(size), size * size); // генерируем матрицу и рисуем ее

//Console.WriteLine();

//DrawMatrix(FillSpiralMatrix(size), size * size);

DateTime d2 = DateTime.Now;
int[,] matrix2 = MakeSpiralMatrix(size);
PrintResult("Решение Михаил" + (DateTime.Now - d2));

DateTime d3 = DateTime.Now;
int[,] matrix3 = FillSpiralMatrix(size);
PrintResult("Решение Николай" + (DateTime.Now - d3));

int[,] NewMatrix = InitMatrix(size, size);
DateTime d1 = DateTime.Now;
int[,] matrix1 = FillSpiral(NewMatrix);
PrintResult("Решение Андрей" + (DateTime.Now - d1));

// Метод, принимает строку, выводит в консоль
static void PrintResult(string line)
{
    Console.WriteLine(line);
}

int TakeIntData(string msg) //метод считывающий целое из консоли, выводя в неё сообщение
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

void DrawMatrix(int[,] matrix, int max) // метод рисующий красивую матрицу в таблице
{
    int i = 1; // счетчик начинаем с 1, т.к. 0ю строку обрабатываем до цикла в связи с необходимостью
               // рисовать верхнюю линию таблицы, отличную от средних

    int numStr = matrix.GetLength(0); // получаем количество строк

    string str = MakeTableString(matrix, 0, max, '\u2551'); // формируем строку таблицы с границами ячеек
    Console.WriteLine(MakeTableLine(str, '\u2554', '\u2550', '\u2566', '\u2557', '\u2551')); // рисуем верхнюю линию таблицы
    Console.WriteLine(str); // печатаем сформированную строку

    while (i < numStr) // цикл по строкам матрицы
    {
        str = MakeTableString(matrix, i, max, '\u2551'); // формируем i-ю строку таблицы с границами ячеек
        Console.WriteLine(MakeTableLine(str, '\u2560', '\u2550', '\u256C', '\u2563', '\u2551')); // рисуем среднюю линию таблицы
        Console.WriteLine(str); // печатаем очередную строку матрицы с границами ячеек
        i++;
    }

    Console.WriteLine(MakeTableLine(str, '\u255A', '\u2550', '\u2569', '\u255D', '\u2551')); // рисуем нижнюю границу таблицы
}

string MakeTableString(int[,] matrix, int strNum, int max, char border) // метод собирающий строку таблицы с боковыми границами ячеек
{
    string str = ""; // инициалиизируем строку
    str = str + border; // рисуем левую границу
    int numsInMax = (int)Math.Log10(max) + 1; // считаем количество цифр в макимальном элементе для организации выравнивания ячеек
    int n = matrix.GetLength(1); // вычисляем количество столбцов
    int j = 0; // счетчик для цикла

    while (j < n) // цикл по колонкам строки матрицы
    {
        str = str + ((Convert.ToString(matrix[strNum, j])).PadRight(numsInMax)) + "\u2551";  // записываем в строку очередной элемент, 
                                                                                             //дописываем нужное количество пробелов и рисуем правую границу      
        j++;
    }
    return str; // возвращаем результат

}

string MakeTableLine(string sampleStr, char left, char midUsual, char midCros, char right, char whereCross) // метод формирующий линию таблицы
{
    /*
        sampleStr - пример на основании которого формируется линия
        char left - первый символ строки
        midUsual - горизонтальная линия
        midCros - горизонтальная линия с перекрестиями для границы ячеек
        right - правый символ строки
        whereCross - символ в строке-примере на основании которого принимается решение о необходимости перекрестия
    */

    string str = ""; // инициализируем строку
    str = str + left; // записываем в нее левый символ
    int sampleLen = sampleStr.Length - 1; // считаем длинну строки-примера вычитаем единицу, т.к. цикл нужен до предпоследнего элемента
    int i = 1; // уикл начинаем с 1 т.к. 0й элемент уже записан

    while (i < sampleLen)
    {
        if (sampleStr[i] == whereCross) str = str + midCros; // если в строке с примером попадается вертикальная линия, то рисуем линию с перекрестием
        else str = str + midUsual; // иначе рисуем горизонтальную линию
        i++;
    }
    str = str + right; //рисуем правый символ строки
    return str;
}

//Михаил
int[,] MakeSpiralMatrix(int size) // метод заполняющий матрицу по спирали начиная с элемента [0,0]
{
    int[,] matrix = new int[size, size]; // инициализируем матрицу
    int i = 0; // текущая строка элемента
    int j = -1; // текущий столбец элемента
    int lEdge = 0; // левая граница для заполнения матрицы
    int rEdge = size - 1; // правая граница для заполнения
    int tEdge = 1; // верхняя граница для заполнения
    int bEdge = size - 1; // нижняя граница для заполнения
    int val = 1; // значение записываемое в элеменнт матрицы
    int iStep = 1; // приращение для прохода по строкам
    int jStep = 1; // приращение для прохода по столбцам 

    while (val <= (size * size)) // выходим из цикла когда элемент для следующей записи больше, чем количество элементов в матрице (т.е. матрица заполнена)
    {
        do  // цикл пока j не достигнет правой границы при движении вправо или левой границы при движении влево
        {
            j = j + jStep; // прибавляем шаг к j
            matrix[i, j] = val; // записываем значение в элемент массива
            val++; // увеличиваем значение для следующей записи
        }
        while ((j != rEdge && jStep > 0) || (j != lEdge && jStep < 0)); // проверяем достижение границ заполнения

        if (jStep > 0) rEdge--; // если шли вправо, то сдвигаем правую границу влево
        else lEdge++; // иначе сдвигаем левую границу вправо

        jStep = jStep * (-1); // меняем знак приращения для столбцов для следующего прохода

        if (val > (size * size)) break; // если следующий элемент для запси больше количества элементов матрицы, то выходим из цикла

        do // цикл пока i не достигнет нижней границы при движении вниз или верхней границы при движении вверх
        {
            i = i + iStep; // прибавляем шаг к i
            matrix[i, j] = val; // записываем значение в элемент массива
            val++; // увеличиваем значение для следующей записи
        }
        while ((i != bEdge && iStep > 0) || (i != tEdge && iStep < 0)); // проверяем достижение границ заполнения

        if (iStep > 0) bEdge--; // если шли вниз, то сдвигаем нижнюю границу вверх
        else tEdge++; // иначе сдвигаем верхнюю границу вниз

        iStep = iStep * (-1); // меняем знак приращения для строк для следующего прохода
    }

    return matrix;

}


//Николай
int[,] FillSpiralMatrix(int size)
{

    int[,] sqareMatrix = new int[size, size];

    int temp = 1;
    int i = 0;
    int j = 0;

    while (temp <= sqareMatrix.GetLength(0) * sqareMatrix.GetLength(1))
    {
        sqareMatrix[i, j] = temp;
        temp++;
        if (i <= j + 1 && i + j < sqareMatrix.GetLength(1) - 1)
            j++;
        else if (i < j && i + j >= sqareMatrix.GetLength(0) - 1)
            i++;
        else if (i >= j && i + j > sqareMatrix.GetLength(1) - 1)
            j--;
        else
            i--;
    }
    return sqareMatrix;
}

//Андрей
int[,] InitMatrix(int rows, int columns)
{ return new int[rows, columns]; }

int[,] FillSpiral(int[,] matrix, int startNumber = 1, int count = 1)
{
    for (int j = -1 + count; j < matrix.GetLength(1) + 1 - count; j++)
    {
        matrix[-1 + count, j] = startNumber++;
    }
    for (int i = count; i < matrix.GetLength(0) + 1 - count; i++)
    {
        matrix[i, matrix.GetLength(1) - count] = startNumber++;
    }
    for (int j = matrix.GetLength(1) - 1 - count; j > -1 + count; j--)
    {
        matrix[matrix.GetLength(0) - count, j] = startNumber++;
    }
    for (int i = matrix.GetLength(0) - count; i > -1 + count; i--)
    {
        matrix[i, -1 + count] = startNumber++;
    }
    if (startNumber <= matrix.GetLength(0) * matrix.GetLength(1))
    {
        FillSpiral(matrix, startNumber, ++count);
    }
    return matrix;
}

