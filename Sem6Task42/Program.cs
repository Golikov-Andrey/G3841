int inputNumber = ReadData("Enter number: ");

PrintData("Result: " + DegToBin(inputNumber));
PrintData("Result: " + DecToBinNativ(inputNumber));
PrintData("Result: " + Convert.ToString(inputNumber, 8));
PrintData("Result: " + Convert.ToString(inputNumber, 16));

int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

void PrintData(string res)
{
    Console.WriteLine(res);
}

string DegToBin(int num)
{
    string outBin = String.Empty;
    while (num > 0)
    {
        outBin = (num % 2) + outBin;
        num = num / 2;
    }
    return outBin;
}

string DecToBinNativ(int num)
{
    return Convert.ToString(num, 2);
}
