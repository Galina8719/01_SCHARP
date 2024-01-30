// string s1 = "hello";

// char[] ch_array = { 'w', 'o', 'r', 'l', 'd' };
// string s2 = new String(ch_array);

// string s3 = new String('a', 6); // результат "aaaaaa"

//Задача 3. Считать с консоли строку, 
// состоящую из цифр и латинских букв.
// Сформировать новую строку, состоящую 
// из букв исходной строки.

string GetLetters(string s)
{
    string letters = "";
    foreach (char e in s)
    {
        if (char.IsAsciiLetter(e) == true)
        {
            letters = letters + e;
        }
    }
    return letters;
}

Console.WriteLine("Введите строку:");
string str = Console.ReadLine();
string result = GetLetters(str);
Console.WriteLine(result);
