// int n = 5;

// int i = 1;
// while (i <= n)
// {
//     Console.Write($"{i * i} ");
//     i = i + 1;
// }

// Функция возвести в квадрат
int Square (int value)
{
    int result = value * value;
    return result;
}
                                        //Функция == метод
//Функция произведение
int Multiply(int value1, int value2)
{
    int result = value1 * value2;
    return result;
}

void ShowSquar(int value)               //(пустота)
{
    int result = value * value;         //Тело функции
    Console.Write(result);
}

void ShowHelloMessage()                 //Без параметров, без возвращаемого значения
{
    Console.WriteLine("Hello World!");   //Побочный эффект
}

double GetPi()                          //Без параметров, с возвращаемым значением
{
    return 3.14159;
}

void ShowMessage(string message)        //С параметрами, без возвращаемого значения
{
    Console.WriteLine(message);
}

int AddValues(int a, int b)             //С параметрами, с возвращаемым значением
{
    int result = a + b;                 //Сумма
    return result;
}