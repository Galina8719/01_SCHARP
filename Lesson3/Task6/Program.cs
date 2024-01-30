//Задание: создать функции.

int n = 10;                      //Создание массива
int[] arr = new int[n];
int i = 0;
int sum = 0;
//int product = 1;
while (i < n)                    //заполнение массива
{
    arr[i] = i + 1;
    Console.Write($"{arr[i]} ");
    i++;
}
Console.WriteLine();
int i = 0;
while (i < n)                    //вывод массива
{
    Console.WriteLine($"{arr[i]} ");
    i++;
}
int i = 0;
int sum = 0;
while (i < n)                    //сумма элементов
{
    sum = sum + arr[i];
    i++;
}
int i = 0;
int product = 1;
while (i < n)                    //произведение
{
    product = product * arr[i];
    i++;
}
Console.WriteLine($"Сумма = {sum}");
Console.WriteLine($"Произведение = {product}");
