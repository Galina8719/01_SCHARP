// int n = 10;                      //Создание массива
// int[] arr = new int[n];
// int i = 0;

// while (i < n)                    //заполнение массива
// {
//     arr[i] = i + 1;
// }
// i = 0;

// while (i < n)                    //вывод массива
// {
//     Console.WriteLine($"{arr[i]} ");
// }
// i = 0;
// sum = 0;

// while (i < n)                    //сумма элементов
// {
//     sum = sum + arr[i];
// }
// i = 0;
// product = 1;

// while (i < n)                    //произведение
// {
//     product = product * arr[i];
// }

// Console.WriteLine(sum);
// Console.WriteLine(product);

int n = 10;
int[] arr = new int[n];
int i = 0;

void FillArray()                    //заполняющий массив
{
    while (i < n)
    {
        arr[i] = i + 1;
        i++;
    }
}

void PrintArray()                   //вывод массива на экран
{
    while (i < n)
    {
        Console.WriteLine($"{arr[i]} ");
        i++;
    }
}
int sum = GetSumOfElements()        //сумма
{
    while (i < n)
    {
        sum = sum + arr[i];
        i++;
    }
}

int product = GetProductOfElements();
{
    int product = 1;
    while (i < n)
    {
        product = product * arr[i];
    }
}
Console.WriteLine(sum);
Console.WriteLine(product);
