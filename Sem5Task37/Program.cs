// // Задача №37
// // Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент,
// //  второй и предпоследний и т.д. Результат запишите в новом массиве.



// int[] Gen1DArray(int len, int minValue, int maxValue)
// {
//     int[] arr = new int[len];
//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return arr;
// }

// void Print1DArr(int[] arr)
// {
//     Console.Write("[");
//     for (int i = 0; i < arr.Length - 1; i++)
//     {
//         Console.Write(arr[i] + ", ");
//     }
//     Console.WriteLine(arr[arr.Length - 1] + "]");
// }

// int[] ConvertArr(int[] arr)
// {
//     int[] resArr = new int[(arr.Length/2)+1];
//     for (int i = 0; i < resArr.Length; i++)
//     {
//         resArr[i]=arr[i]*arr[arr.Length-1-i];
//     }
//     return resArr;
// }

// int[] testArr = Gen1DArray(123,0,1000);
// Print1DArr(testArr);
// int[] convArr = ConvertArr(testArr);
// Print1DArr(convArr);
// Print1DArr(testArr);

void show1DArray(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + "\t");
    }
    Console.WriteLine(" ");
}
double[] convert1DArray(double[] nums)
{
    double[] arr1={};
    for (int i = 0; i < nums.Length/2; i++)
    {
        arr1=arr1.Append(nums[i] * nums[nums.Length - 1 - i]).ToArray();
    }
    if (Convert.ToDouble(nums.Length)/2!=Convert.ToDouble(nums.Length/2))
    {
         arr1=arr1.Append(Math.Pow(nums[nums.Length/2],2)).ToArray();
    }
    return arr1;
}
double[] multiInputs(string msg)
{
    Console.Write(msg);
    string n = Console.ReadLine() ?? "0";
    string[] arr = n.Split(" ");
    double[] vec = { };
    for (int i = 0; i < arr.Length; i++)
    {
        if ((arr[i] != ""))
            vec = vec.Append(double.Parse(arr[i])).ToArray();
    }
    return vec;
}
show1DArray(convert1DArray(multiInputs("введите значения для массива в строку: ")));

