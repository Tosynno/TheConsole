using System;

class EntryPoint
{
    static void Main()
    {
        //Console.ForegroundColor = ConsoleColor.Red;
        //Console.BackgroundColor = ConsoleColor.Yellow;
        //Console.WriteLine("A turtle made it to the water.");
        //Console.WriteLine("I've collected many things over the years.");
        //Console.ResetColor();
        //Console.Write("The ");
        //Console.BackgroundColor = ConsoleColor.Red;
        //Console.ForegroundColor = ConsoleColor.Green;
        //Console.Write("cycle of life");
        //Console.ResetColor();
        //Console.Write(" can be cruel.\n");

        float proteinDayOne = 80.888555f;
        float proteinDayTwo = 85.56234f;
        float proteinDayThree = 64.77723f;
        float proteinDayFour = 88.4444f;
        float proteinDayFive = 95.555f;
        float proteinDaySix = 76.77457f;
        float proteinDaySeven = 76.65555f;

        float cost = proteinDayOne + proteinDayTwo + proteinDayThree + proteinDayFour + proteinDayFive + proteinDaySix + proteinDaySeven;
        string proteinIntake = "Protein Intake Week: 1";
        string separator = new string('=', proteinIntake.Length);

        ConsoleColor separatorsColor = ConsoleColor.Red;
        ConsoleColor dataBackground = ConsoleColor.DarkGreen;
        ConsoleColor totalBackground = ConsoleColor.DarkBlue;
        ConsoleColor headlineBackground = ConsoleColor.DarkYellow;

        Console.WindowWidth = 25;
        Console.BufferWidth = 25;
        Console.WindowHeight = 15;
        Console.BufferHeight = 15;

        Console.ForegroundColor = ConsoleColor.White;
        Console.BackgroundColor = separatorsColor;
        Console.Write("|");
        Console.Write(separator);
        Console.Write("|\n");
        Console.Write("|");
        Console.BackgroundColor = headlineBackground;
        Console.Write(proteinIntake);
        Console.BackgroundColor = separatorsColor;
        Console.Write("|\n");
        Console.Write("|");
        Console.Write(separator);
        Console.Write("|\n");
        Console.Write("|");
        Console.BackgroundColor = dataBackground;
        Console.Write($"{proteinDayOne,22:N2}");
        Console.BackgroundColor = separatorsColor;
        Console.Write("|\n");
        Console.Write("|");
        Console.BackgroundColor = dataBackground;
        Console.Write($"{proteinDayTwo,22:N2}");
        Console.BackgroundColor = separatorsColor;
        Console.Write("|\n");
        Console.Write("|");
        Console.BackgroundColor = dataBackground;
        Console.Write($"{proteinDayThree,22:N2}");
        Console.BackgroundColor = separatorsColor;
        Console.Write("|\n");
        Console.Write("|");
        Console.BackgroundColor = dataBackground;
        Console.Write($"{proteinDayFour,22:N2}");
        Console.BackgroundColor = separatorsColor;
        Console.Write("|\n");
        Console.Write("|");
        Console.BackgroundColor = dataBackground;
        Console.Write($"{proteinDayFive,22:N2}");
        Console.BackgroundColor = separatorsColor;
        Console.Write("|\n");
        Console.Write("|");
        Console.BackgroundColor = dataBackground;
        Console.Write($"{proteinDaySix,22:N2}");
        Console.BackgroundColor = separatorsColor;
        Console.Write("|\n");
        Console.Write("|");
        Console.BackgroundColor = dataBackground;
        Console.Write($"{proteinDaySeven,22:N2}");
        Console.BackgroundColor = separatorsColor;
        Console.Write("|\n");
        Console.Write("|");
        Console.Write(separator);
        Console.Write("|\n");
        Console.Write("|");
        Console.BackgroundColor = totalBackground;
        Console.Write($"Total: {cost,15:N2}");
        Console.BackgroundColor = separatorsColor;
        Console.Write("|\n");
        Console.BackgroundColor = separatorsColor;
        Console.Write("|");
        Console.Write(separator);
        Console.Write("|\n");
        Console.ResetColor();
        Console.ReadKey();
    }
}