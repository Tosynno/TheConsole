using System;

class EntryPoint
{
    static void Main()
    {
        Console.Write("How old are you? ");
        char age = (char)Console.Read();
        Console.WriteLine($"My age is {age}");
        Console.ReadKey();

    }
}