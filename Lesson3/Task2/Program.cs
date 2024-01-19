//Домашнее задание
//Вычислить значение формулы (a*b)/(c+d), где a,b,c,d - некоторые целые числа.
//Результат выыести на экран.

double CalculateFormyla(int a, int b, int c, int d)
{
    double numenator = a * b;
    int denomenator = c * d;
    double result = numenator / denomenator;
    return result;
}
double result = CalculateFormyla(1, 2, 3, 4);
Console.WriteLine(result);
