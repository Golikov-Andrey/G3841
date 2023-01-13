// Задача №0
// Напишите программу, которая на вход принимает
// число и выдаёт его квадрат (число умноженное на
// само себя). 

//Считываем данные с консоли
string? inputNum = Console.ReadLine();

//Проверяем, чтобы данные были не пустыми
if(inputNum!=null)
{
    // //Парсим введенное число
    // int number = int.Parse(inputNum);
    // //Находим квадрат числа
    // //int result = number*number;
    // int result = (int)Math.Pow(number,2);

    // // Выводим данные в консоль 
    // Console.WriteLine(result);

    Console.WriteLine(Math.Pow(int.Parse(inputNum),2));
}
