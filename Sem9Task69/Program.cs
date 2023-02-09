int ReadData(string line)
{
    Console.Write(line);
    return int.Parse(Console.ReadLine() ?? "0");
}

void PrintResult(string prefix)
{
    Console.WriteLine(prefix);
}

long RecPowFlow(int a, int b)
{
    if(b<=1)return a;
    return a*RecPowFlow(a,b-1);
}

long MyPow(int a, int b)
{
    if(b==2)return a*a;
    return MyPow(a,b/2)*MyPow(a,b/2);
}

int numberA = ReadData("Enter number A:");
int numberB = ReadData("Enter number B:");

long res1 =0;
long res2 =0;

DateTime d1 = DateTime.Now;
res1 = RecPowFlow(numberA,numberB);
PrintResult("Решение RecPowFlow" + (DateTime.Now - d1));

DateTime d2 = DateTime.Now;
res2 = MyPow(numberA,numberB);
PrintResult("Решение MyPow" + (DateTime.Now - d2));