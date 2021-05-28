using System;

class EntryPoint
{
    static void Main()
    {
        Console.Title = "My App";
        Console.CursorVisible = true;
        Console.CursorSize = 50;

        //Console.SetCursorPosition(20, 10);
        //Console.CursorLeft = 20;
        Console.CursorTop = 10;
        Console.ReadLine();
        Console.ReadKey();
    }
}