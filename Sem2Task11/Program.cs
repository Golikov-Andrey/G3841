// System.Random newSintezator = new System.Random();
// int num = newSintezator.Next(100,1000);

// int digitfirst = num/100;
// int digitLast = num%10;
// Console.WriteLine(num);
// Console.WriteLine(digitfirst*10 + digitLast);

// System.Random numSintezator = new System.Random();
// int num = numSintezator.Next(100, 1000);
// int digit1 = num/100;
// int digit2 = num%10;
//  Console.WriteLine(num);
// Console.WriteLine(digit1*10+digit2);

System.Random random = new System.Random();

int randomNumber = random.Next(100,1000);

Console.WriteLine("число: " + randomNumber);

string value = randomNumber.ToString();

char[] numberArray = value.ToCharArray();

Console.WriteLine(numberArray[0] + "" + numberArray[2]);