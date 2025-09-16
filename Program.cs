Console.Clear();
string strBlock = "X";
int currentLine = 0;
Console.SetCursorPosition(0, currentLine);
Console.BackgroundColor = ConsoleColor.Black;

//Line 0 all cyan
Console.BackgroundColor = ConsoleColor.Cyan;
for (int currentCol = 0; currentCol <= 13; currentCol += 1)
{
    Console.Write(strBlock);
}
Console.BackgroundColor = ConsoleColor.Black;

//Line 1
currentLine += 1;
Console.SetCursorPosition(0, currentLine);
for (int currentCol = 0; currentCol <= 13; currentCol += 1)
{
    if (currentCol <= 3)
    {
        Console.BackgroundColor = ConsoleColor.Cyan;
        Console.Write(strBlock);
    }
    else if (currentCol >= 4 && currentCol <= 8)
    {
        Console.BackgroundColor = ConsoleColor.Red;
        Console.Write(strBlock);
    }
    else if (currentCol >= 9)
    {
        Console.BackgroundColor = ConsoleColor.Cyan;
        Console.Write(strBlock);
    }
}
Console.BackgroundColor = ConsoleColor.Black;

//Line 2
currentLine += 1;
Console.SetCursorPosition(0, currentLine);
for (int currentCol = 0; currentCol <= 13; currentCol += 1)
{
    if (currentCol <= 2)
    {
        Console.BackgroundColor = ConsoleColor.Cyan;
        Console.Write(strBlock);
    }
    else if (currentCol >= 3 && currentCol <= 11)
    {
        Console.BackgroundColor = ConsoleColor.Red;
        Console.Write(strBlock);
    }
    else if (currentCol >= 12)
    {
        Console.BackgroundColor = ConsoleColor.Cyan;
        Console.Write(strBlock);
    }
}
Console.BackgroundColor = ConsoleColor.Black;