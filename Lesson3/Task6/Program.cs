int n = 10;                     //Создание массива
int [] arr = new int [n];       //Создание массива
int i = 0;                      //Создание массива
while (i<n)
{
    arr [i] = i + 1;
}
i = 0;
while (i<n)
{
    Console.WriteLine($"{arr[i]} ");
}
i = 0;
sum = 0;
while (i<n)
{
    sum = sum +arr[i];
}
i = 0;
product = 1;
while (i<n)
{
    product = product *arr[i];
}
Console.WriteLine(sum);
Console.WriteLine(product);