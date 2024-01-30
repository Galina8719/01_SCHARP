void OpenMatryoshka(int size)
{
    Console.WriteLine($"Opening matryoshka of size {size}...");
    //Базовый случай: самая маленькая матрешка
    if (size == 1)
    {
        Console.WriteLine("Reached the smallest matryoshka!");
        return;
    }
    OpenMatryoshka(size - 1);
}

OpenMatryoshka(5);

// Opening matryoshka of size 5...
// Opening matryoshka of size 4... 
// Opening matryoshka of size 3... 
// Opening matryoshka of size 2... 
// Opening matryoshka of size 1... 
// Reached the smallest matryoshka!
