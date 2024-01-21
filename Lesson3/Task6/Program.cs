// int n = 10;                      //Создание массива
// int[] arr = new int[n];
// int i = 0;
// int sum = 0;
// //int product = 1;
// while (i < n)                    //заполнение массива
// {
//     arr[i] = i + 1;
//     Console.Write($"{arr[i]} ");
//     i++;
// }
// Console.WriteLine();
//int i = 0;
// while (i < n)                    //вывод массива
// {
//     Console.WriteLine($"{arr[i]} ");
//     i++;
// }
//int i = 0;
//int sum = 0;
// while (i < n)                    //сумма элементов
// {
//     sum = sum + arr[i];
//     i++;
// }
//int i = 0;
//int product = 1;
// while (i < n)                    //произведение
// {
//     product = product * arr[i];
//     i++;
// }
//Console.WriteLine($"Сумма = {sum}");
// Console.WriteLine($"Произведение = {product}");

int n = 10;
int[] arr = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
int i = 0;

// int FillArray(int[] arr)                    //заполняющий массив
// {                                        
//     while (i < n)
//     {
//         arr[i] = i + 1;
//         Console.Write($"{arr[i]} ");
//         i = i + 1;
//     }
//     return arr[i];
// }

// void PrintArray(int[] arr)                   //вывод массива на экран
// {
//     while (i < n)
//     {
//         Console.Write($"{arr[i]} ");
//         i = i + 1;
//     }
// }

int sum = GetSumOfElements(int[] arr)     //сумма
 {
    int sum = 0;
    while (i < n)
    {
        sum = sum + arr[i];
        i++;
    }
    return sum;
}

// int product = GetProductOfElements()
// {
//     int product = 1;
//     while (i < n)
//     {
//         product = product * arr[i];
//     }
// }
//FillArray(arr);
// PrintArray(arr);
GetSumOfElements(arr);
// GetProductOfElements(arr);
Console.WriteLine(sum);
//Console.WriteLine(product);
