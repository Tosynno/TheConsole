using System;

class EntryPoint
{
    static void Main()
    {
        float proteinDayOne = 80.888555f;
        float proteinDayTwo = 85.56234f;
        float proteinDayThree = 64.77723f;
        float proteinDayFour = 88.4444f;
        float proteinDayFive = 95.555f;
        float proteinDaySix = 76.77457f;
        float proteinDaySeven = 76.65555f;

        float cost =  proteinDayOne + proteinDayTwo + proteinDayThree + proteinDayFour + proteinDayFive + proteinDaySix + proteinDaySeven;
        string proteinIntake = "Protein Intake Week: 1";
        string separator = new string('=', proteinIntake.Length);

        Console.Write("|");
        Console.Write(proteinIntake);
        Console.Write("|\n");
        Console.Write("|");
        Console.Write(separator);
        Console.Write("|\n");
        Console.Write("|");
        Console.Write($"{proteinDayOne,22}");
        Console.Write("|\n");
        Console.Write("|");
        Console.Write($"{proteinDayTwo,22}");
        Console.Write("|\n");
        Console.Write("|");
        Console.Write($"{proteinDayThree,22}");
        Console.Write("|\n");
        Console.Write("|");
        Console.Write($"{proteinDayFour, 22}");
        Console.Write("|\n");
        Console.Write("|");
        Console.Write($"{proteinDayFive, 22}");
        Console.Write("|\n");
        Console.Write("|");
        Console.Write($"{proteinDaySix, 22}");
        Console.Write("|\n");
        Console.Write("|");
        Console.Write($"{proteinDaySeven, 22}");
        Console.Write("|\n");
        Console.Write("|");
        Console.Write(separator);
        Console.Write("|\n");
        Console.Write("|");
        Console.Write($"Total: {cost, 15}");
        Console.Write("|\n");
        Console.ReadKey();
    }
}