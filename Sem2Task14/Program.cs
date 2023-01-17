
// Console.Write("Введите число:");
// int num1 = int.Parse(Console.ReadLine() ?? "0");
// int res1 = num1 % 7;
// int res2 = num1 % 23;
// if ((res1 == 0) && (res2 ==0 ))
// {
//     Console.Write("Число кратно 7 и 23");
// }
// else
// {
//     Console.Write("Число некратно 7 и 23");
// }
// int num = int.Parse(Console.ReadLine() ?? "0");
// if ((num%7==0)&&(num%23==0)){
//     Console.WriteLine("кратное");
// }else{
//     Console.WriteLine("не кратное 7и и 23ём");
// }
int num1 = int.Parse(Console.ReadLine()??"0");

int res1 = num1%7;
int res2 = num1%23;
if((res1==0)&&(res2==0))
{
Console.WriteLine("Кратное ");
}

else
{
Console.WriteLine("Не кратно " + res1 + " " + res2);
}

