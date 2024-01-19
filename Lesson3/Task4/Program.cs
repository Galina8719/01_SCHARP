// void Foo(int a)
// {
//     Console.Write(a);
// }

// int value = 5;
// Foo(value);

void Bar(int a)
{
    a = 0;
}

int value = 5;
Bar(value);
Console.Write(value);
