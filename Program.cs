Console.Clear();
string strBlock = "  ";
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
    if (currentCol <= 3 || currentCol >= 9)
    {
        Console.BackgroundColor = ConsoleColor.Cyan;
        Console.Write(strBlock);
    }
    else if (currentCol >= 4 && currentCol <= 8)
    {
        Console.BackgroundColor = ConsoleColor.Red;
        Console.Write(strBlock);
    }
}
Console.BackgroundColor = ConsoleColor.Black;

//Line 2
currentLine += 1;
Console.SetCursorPosition(0, currentLine);
for (int currentCol = 0; currentCol <= 13; currentCol += 1)
{
    if (currentCol <= 2 || currentCol >= 12)
    {
        Console.BackgroundColor = ConsoleColor.Cyan;
        Console.Write(strBlock);
    }
    else if (currentCol >= 3 && currentCol <= 11)
    {
        Console.BackgroundColor = ConsoleColor.Red;
        Console.Write(strBlock);
    }
}
Console.BackgroundColor = ConsoleColor.Black;

//Line 3
currentLine += 1;
Console.SetCursorPosition(0, currentLine);
for (int currentCol = 0; currentCol <= 13; currentCol += 1)
{
    if (currentCol <= 2 || currentCol >= 10)
    {
        Console.BackgroundColor = ConsoleColor.Cyan;
        Console.Write(strBlock);
    }
    else if (currentCol >= 3 && currentCol <= 5 || currentCol == 8)
    {
        Console.BackgroundColor = ConsoleColor.Black;
        Console.Write(strBlock);
    }
    else if (currentCol >= 6 && currentCol <= 7 || currentCol == 9)
    {
        Console.BackgroundColor = ConsoleColor.White;
        Console.Write(strBlock);
    }
}
Console.BackgroundColor = ConsoleColor.Black;

//Line 4
currentLine += 1;
Console.SetCursorPosition(0, currentLine);
for (int currentCol = 0; currentCol <= 13; currentCol += 1)
{
    if (currentCol <= 1 || currentCol >= 12)
    {
        Console.BackgroundColor = ConsoleColor.Cyan;
        Console.Write(strBlock);
    }
    else if (currentCol == 2 || currentCol == 4 || currentCol == 8)
    {
        Console.BackgroundColor = ConsoleColor.Black;
        Console.Write(strBlock);
    }
    else //(currentCol >= 6 && currentCol <= 7 || currentCol == 9)
    {
        Console.BackgroundColor = ConsoleColor.White;
        Console.Write(strBlock);
    }
}
Console.BackgroundColor = ConsoleColor.Black;

//Line 5
currentLine += 1;
Console.SetCursorPosition(0, currentLine);
for (int currentCol = 0; currentCol <= 13; currentCol += 1)
{
    if (currentCol <= 1 || currentCol == 13)
    {
        Console.BackgroundColor = ConsoleColor.Cyan;
        Console.Write(strBlock);
    }
    else if (currentCol == 2 || currentCol >= 4 && currentCol <= 5 || currentCol == 9)
    {
        Console.BackgroundColor = ConsoleColor.Black;
        Console.Write(strBlock);
    }
    else
    {
        Console.BackgroundColor = ConsoleColor.White;
        Console.Write(strBlock);
    }
}
Console.BackgroundColor = ConsoleColor.Black;

//Line 6
currentLine += 1;
Console.SetCursorPosition(0, currentLine);
for (int currentCol = 0; currentCol <= 13; currentCol += 1)
{
    if (currentCol <= 1 || currentCol >= 12)
    {
        Console.BackgroundColor = ConsoleColor.Cyan;
        Console.Write(strBlock);
    }
    else if (currentCol >= 2 && currentCol <= 3 || currentCol >= 8 && currentCol <= 11)
    {
        Console.BackgroundColor = ConsoleColor.Black;
        Console.Write(strBlock);
    }
    else
    {
        Console.BackgroundColor = ConsoleColor.White;
        Console.Write(strBlock);
    }
}

//Line 7
currentLine += 1;
Console.SetCursorPosition(0, currentLine);
for (int currentCol = 0; currentCol <= 13; currentCol += 1)
{
    if (currentCol <= 3 || currentCol >= 11)
    {
        Console.BackgroundColor = ConsoleColor.Cyan;
        Console.Write(strBlock);
    }
    else
    {
        Console.BackgroundColor = ConsoleColor.White;
        Console.Write(strBlock);
    }
}
Console.BackgroundColor = ConsoleColor.Black;

//Line 8
currentLine += 1;
Console.SetCursorPosition(0, currentLine);
for (int currentCol = 0; currentCol <= 13; currentCol += 1)
{
    if (currentCol <= 2 || currentCol >= 9)
    {
        Console.BackgroundColor = ConsoleColor.Cyan;
        Console.Write(strBlock);
    }
    else if (currentCol == 5)
    {
        Console.BackgroundColor = ConsoleColor.Red;
        Console.Write(strBlock);
    }
    else
    {
        Console.BackgroundColor = ConsoleColor.DarkBlue;
        Console.Write(strBlock);
    }
}
Console.BackgroundColor = ConsoleColor.Black;

//Line 9
currentLine += 1;
Console.SetCursorPosition(0, currentLine);
for (int currentCol = 0; currentCol <= 13; currentCol += 1)
{
    if (currentCol <= 1 || currentCol >= 12)
    {
        Console.BackgroundColor = ConsoleColor.Cyan;
        Console.Write(strBlock);
    }
    else if (currentCol == 5 || currentCol == 8)
    {
        Console.BackgroundColor = ConsoleColor.Red;
        Console.Write(strBlock);
    }
    else
    {
        Console.BackgroundColor = ConsoleColor.DarkBlue;
        Console.Write(strBlock);
    }
}
Console.BackgroundColor = ConsoleColor.Black;

//Line 10
currentLine += 1;
Console.SetCursorPosition(0, currentLine);
for (int currentCol = 0; currentCol <= 13; currentCol += 1)
{
    if (currentCol == 0 || currentCol == 13)
    {
        Console.BackgroundColor = ConsoleColor.Cyan;
        Console.Write(strBlock);
    }
    else if (currentCol == 5 || currentCol == 8)
    {
        Console.BackgroundColor = ConsoleColor.Red;
        Console.Write(strBlock);
    }
    else
    {
        Console.BackgroundColor = ConsoleColor.DarkBlue;
        Console.Write(strBlock);
    }
}
Console.BackgroundColor = ConsoleColor.Black;

//Line 11
currentLine += 1;
Console.SetCursorPosition(0, currentLine);
for (int currentCol = 0; currentCol <= 13; currentCol += 1)
{
    if (currentCol == 0 || currentCol == 13)
    {
        Console.BackgroundColor = ConsoleColor.Cyan;
        Console.Write(strBlock);
    }
    else if (currentCol >=1 && currentCol <=2 || currentCol >=11 && currentCol <=12)
    {
        Console.BackgroundColor = ConsoleColor.White;
        Console.Write(strBlock);
    }
    else if (currentCol >= 5 && currentCol <= 8)
    {
        Console.BackgroundColor = ConsoleColor.Red;
        Console.Write(strBlock);
    }
    else
    {
        Console.BackgroundColor = ConsoleColor.DarkBlue;
        Console.Write(strBlock);
    }
}
Console.BackgroundColor = ConsoleColor.Black;

//Line 12
currentLine += 1;
Console.SetCursorPosition(0, currentLine);
for (int currentCol = 0; currentCol <= 13; currentCol += 1)
{
    if (currentCol == 0 || currentCol == 13)
    {
        Console.BackgroundColor = ConsoleColor.Cyan;
        Console.Write(strBlock);
    }
    else if (currentCol >=1 && currentCol <=3 || currentCol >=10 && currentCol <=12)
    {
        Console.BackgroundColor = ConsoleColor.White;
        Console.Write(strBlock);
    }
    else if (currentCol == 5 || currentCol == 8)
    {
        Console.BackgroundColor = ConsoleColor.Yellow;
        Console.Write(strBlock);
    }
    else
    {
        Console.BackgroundColor = ConsoleColor.Red;
        Console.Write(strBlock);
    }
}
Console.BackgroundColor = ConsoleColor.Black;

//Line 13
currentLine += 1;
Console.SetCursorPosition(0, currentLine);
for (int currentCol = 0; currentCol <= 13; currentCol += 1)
{
    if (currentCol == 0 || currentCol == 13)
    {
        Console.BackgroundColor = ConsoleColor.Cyan;
        Console.Write(strBlock);
    }
    else if (currentCol >=1 && currentCol <=2 || currentCol >=11 && currentCol <=12)
    {
        Console.BackgroundColor = ConsoleColor.White;
        Console.Write(strBlock);
    }
    else
    {
        Console.BackgroundColor = ConsoleColor.Red;
        Console.Write(strBlock);
    }
}
Console.BackgroundColor = ConsoleColor.Black;

//Line 14
currentLine += 1;
Console.SetCursorPosition(0, currentLine);
for (int currentCol = 0; currentCol <= 13; currentCol += 1)
{
    if (currentCol >= 3 && currentCol <= 5 || currentCol >= 8 && currentCol <= 10)
    {
        Console.BackgroundColor = ConsoleColor.Red;
        Console.Write(strBlock);
    }
    else
    {
        Console.BackgroundColor = ConsoleColor.Cyan;
        Console.Write(strBlock);
    }
}
Console.BackgroundColor = ConsoleColor.Black;

//Line 15
currentLine += 1;
Console.SetCursorPosition(0, currentLine);
for (int currentCol = 0; currentCol <= 13; currentCol += 1)
{
    if (currentCol >= 2 && currentCol <= 4 || currentCol >= 8 && currentCol <= 10)
    {
        Console.BackgroundColor = ConsoleColor.DarkGray;
        Console.Write(strBlock);
    }
    else
    {
        Console.BackgroundColor = ConsoleColor.Cyan;
        Console.Write(strBlock);
    }
}
Console.BackgroundColor = ConsoleColor.Black;

//Line 16
currentLine += 1;
Console.SetCursorPosition(0, currentLine);
for (int currentCol = 0; currentCol <= 13; currentCol += 1)
{
    if (currentCol >= 1 && currentCol <= 4 || currentCol >= 8 && currentCol <= 11)
    {
        Console.BackgroundColor = ConsoleColor.DarkGray;
        Console.Write(strBlock);
    }
    else
    {
        Console.BackgroundColor = ConsoleColor.Cyan;
        Console.Write(strBlock);
    }
}
Console.BackgroundColor = ConsoleColor.Black;

//Line 17
currentLine += 1;
Console.SetCursorPosition(0, currentLine);
for (int currentCol = 0; currentCol <= 13; currentCol += 1)
{
    Console.BackgroundColor = ConsoleColor.Cyan;
    Console.Write(strBlock);

}
Console.BackgroundColor = ConsoleColor.Black;
Console.WriteLine();
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("    \"It's a me, Mario!!\"");
Console.ForegroundColor = ConsoleColor.White;