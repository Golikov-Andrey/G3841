//Считываем данные с консоли 
string? imputNumLine = Console.ReadLine();
// Проверяем, чтобы данные не были пустыми
if (imputNumLine != null)
{
    // Парсим введенное число
    int imputNumberA = int.Parse(imputNumLine);

    int lastDigit = imputNumberA % 10;

    Console.WriteLine(lastDigit);

}