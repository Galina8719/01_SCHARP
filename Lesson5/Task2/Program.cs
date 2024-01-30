void OpenMatryoshka(int size)
{
    if (size == 1)
    {
        Console.WriteLine("Smallest!");
        return;
    }
    OpenMatryoshka(size - 1);
    Console.WriteLine($"Opening matryoshka of size {size}...");
}

OpenMatryoshka(5);

// Smallest!
// Opening matryoshka of size 2...
// Opening matryoshka of size 3...
// Opening matryoshka of size 4...
// Opening matryoshka of size 5...
