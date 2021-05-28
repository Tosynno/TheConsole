using System;

class EntryPoint
{
    static void Main()
    {
        Console.Write("Input the drive letter: ");
        string drive = Console.ReadLine();
        Console.Write("Input the folder path: ");
        string path = Console.ReadLine();
        Console.Write("Input the file name: ");
        string fileName = Console.ReadLine();

        Console.WriteLine($"{drive}:\\{path}\\{fileName}.exe");
        Console.ReadKey();
    }
}