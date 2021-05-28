using System;
using System.Text;

class EntryPoint
{
    static void Main()
    {
        Console.InputEncoding = Encoding.UTF8;
        Console.OutputEncoding = Encoding.UTF8;

        ConsoleKeyInfo key = Console.ReadKey();
        Console.WriteLine();
        char keyAsChar = key.KeyChar;
        Console.WriteLine("The key that was pressed is: " + keyAsChar);
        Console.WriteLine("Modifiers: " + key.Modifiers);

    }
}