// Задача №28
// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
using System.Numerics;

//Метод читает данные от пользователя
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}
//Выводим результат пользователю
void PrintData(string msg1, BigInteger msg2)
{
    Console.WriteLine(msg1);
    Console.WriteLine(msg2);
}

BigInteger CalcFact(int num)
{
    BigInteger res=1;
    for(int i=1;i<=num;i++)
    {
        res=res*i;
    }
    return res;
}

int number = ReadData("Введите число:");

BigInteger fact = CalcFact(number);

PrintData("Факториал равен: ",fact);