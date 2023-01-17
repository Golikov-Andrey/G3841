Console.WriteLine("input yor nums: ");
// Вводим данные с консоли
int num1 = int.Parse(Console.ReadLine() ?? "0");// Ввод первого числа
int num2 = int.Parse(Console.ReadLine() ?? "0");// Ввод второго числа
//сравнение возведённого в квадрат числа с другим числом
TestSQRT(num1,num2);
TestSQRT(num2,num1);

void TestSQRT(int i, int j)
{
    if ((int)Math.Pow(i, 2) == j)
    {
        Console.WriteLine("да, число " + j + " является квадратом числа " + i);
    }
    else
    {
        Console.WriteLine("число " + j + " не является квадратом числа " + i);
    }
}
