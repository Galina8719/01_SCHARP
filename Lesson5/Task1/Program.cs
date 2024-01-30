void OpenMatryoshka(int size)
{
    Console.WriteLine($"Opening matryoshka of size {size}...");
    //Базовый случай: самая маленькая матрешка
    if (size == 1)
    {
        Console.WriteLine("Reached the smallest matryoshka!");
        return;
    }
    OpenMatryoshka(size-1);
}

OpenMatryoshka(5);
