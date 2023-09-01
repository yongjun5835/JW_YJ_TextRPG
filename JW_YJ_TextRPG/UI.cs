using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

internal class UI
{
    public UI()
    {

    }

    public void DrawText(int x, int y, string text, string color)
    {
        if (color == "Green")
            Console.ForegroundColor = ConsoleColor.Green;
        else if (color == "Red")
            Console.ForegroundColor = ConsoleColor.Red;
        else if (color == "Blue")
            Console.ForegroundColor = ConsoleColor.Blue;
        else if (color == "Black")
            Console.ForegroundColor = ConsoleColor.Black;
        else if (color == "Gray")
            Console.ForegroundColor = ConsoleColor.Gray;
        else if (color == "Yellow")
            Console.ForegroundColor = ConsoleColor.Yellow;
        else if (color == "White")
            Console.ForegroundColor = ConsoleColor.White;
        Console.SetCursorPosition(x, y);
        Console.Write(text);
        Console.ResetColor();
    }

    public void DrawUI(int x, int y, int textPosition, string text, string color)
    {
        DrawText(x, y + 0, " ______________.-'-.______________", color);
        DrawText(x, y + 1, "(_                               _)", color);
        DrawText(x, y + 2, "", color);
        DrawText(x + textPosition, y + 3, text, color);
        DrawText(x, y + 4, " _                               _", color);
        DrawText(x, y + 5, "(______________     ______________)", color);
        DrawText(x, y + 6, "               '-.-'", color);
    }


    // width, height 최솟값 3
    public void DrawBox(int x, int y, int width, int height, string color)
    {
        if (color == "Green")
            Console.ForegroundColor = ConsoleColor.Green;
        else if (color == "Red")
            Console.ForegroundColor = ConsoleColor.Red;
        else if (color == "Blue")
            Console.ForegroundColor = ConsoleColor.Blue;
        else if (color == "Black")
            Console.ForegroundColor = ConsoleColor.Black;
        else if (color == "Gray")
            Console.ForegroundColor = ConsoleColor.Gray;
        else if (color == "Yellow")
            Console.ForegroundColor = ConsoleColor.Yellow;
        else if (color == "White")
            Console.ForegroundColor = ConsoleColor.White;
        Console.SetCursorPosition(x, y);
        Console.Write("┏");
        for (int i = 1; i <= width - 2; i++)
        {
            Console.Write("━");
        }
        Console.SetCursorPosition(x + width - 1, y);
        Console.Write("┓");
        for (int i = 1; i <= height - 2; i++)
        {
            Console.SetCursorPosition(x, y + i);
            Console.Write("┃");
            Console.SetCursorPosition(x + width - 1, y + i);
            Console.Write("┃");
        }
        Console.SetCursorPosition(x, y + height - 1);
        Console.Write("┗");
        for (int i = 1; i <= width - 2; i++)
        {
            Console.Write("━");
        }
        Console.SetCursorPosition(x + width - 1, y + height - 1);
        Console.Write("┛");
        Console.ResetColor();
    }

    public void DrawScroll(int x, int y, int width, string color)
    {
        DrawText(x + 0, y + 0, "    ___", color);
        DrawText(x + 0, y + 1, "   {   }", color);
        DrawText(x + 0, y + 2, " ___)_(___", color);
        DrawText(x + 0, y + 3, "|         |", color);
        DrawText(x + 0, y + 4, "|        -|", color);
        DrawText(x + 0, y + 5, "|      -  |", color);
        DrawText(x + 0, y + 6, "|         |", color);
        DrawText(x + 0, y + 7, "|        -|", color);
        DrawText(x + 0, y + 8, "|         |", color);
        DrawText(x + 0, y + 9, "|      -  |", color);
        DrawText(x + 0, y + 10, "|         |", color);
        DrawText(x + 0, y + 11, "|         |", color);
        DrawText(x + 0, y + 12, "|      -  |", color);
        DrawText(x + 0, y + 13, "|         |", color);
        DrawText(x + 0, y + 14, "|        -|", color);
        DrawText(x + 0, y + 15, "|         |", color);
        DrawText(x + 0, y + 16, "|       - |", color);
        DrawText(x + 0, y + 17, "|         |", color);
        DrawText(x + 0, y + 18, "|        -|", color);
        DrawText(x + 0, y + 19, "|         |", color);
        DrawText(x + 0, y + 20, "|      -  |", color);
        DrawText(x + 0, y + 21, "|         |", color);
        DrawText(x + 0, y + 22, "|        -|", color);
        DrawText(x + 0, y + 23, "|         |", color);
        DrawText(x + 0, y + 24, "|     -   |", color);
        DrawText(x + 0, y + 25, "|        -|", color);
        DrawText(x + 0, y + 26, "|_________|", color);
        DrawText(x + 0, y + 27, "    ) (", color);
        DrawText(x + 0, y + 28, "   {___}", color);

        DrawText(x + 11 + width, y + 0, "    ___", color);
        DrawText(x + 11 + width, y + 1, "   {   }", color);
        DrawText(x + 11 + width, y + 2, " ___)_(___", color);
        DrawText(x + 11 + width, y + 3, "|         |", color);
        DrawText(x + 11 + width, y + 4, "|-        |", color);
        DrawText(x + 11 + width, y + 5, "|  -      |", color);
        DrawText(x + 11 + width, y + 6, "|         |", color);
        DrawText(x + 11 + width, y + 7, "|-        |", color);
        DrawText(x + 11 + width, y + 8, "|         |", color);
        DrawText(x + 11 + width, y + 9, "|   -     |", color);
        DrawText(x + 11 + width, y + 10, "|         |", color);
        DrawText(x + 11 + width, y + 11, "|-        |", color);
        DrawText(x + 11 + width, y + 12, "|         |", color);
        DrawText(x + 11 + width, y + 13, "|         |", color);
        DrawText(x + 11 + width, y + 14, "|  -      |", color);
        DrawText(x + 11 + width, y + 15, "|         |", color);
        DrawText(x + 11 + width, y + 16, "|-        |", color);
        DrawText(x + 11 + width, y + 17, "|         |", color);
        DrawText(x + 11 + width, y + 18, "|    -    |", color);
        DrawText(x + 11 + width, y + 19, "|         |", color);
        DrawText(x + 11 + width, y + 20, "|-        |", color);
        DrawText(x + 11 + width, y + 21, "|         |", color);
        DrawText(x + 11 + width, y + 22, "|   -     |", color);
        DrawText(x + 11 + width, y + 23, "|         |", color);
        DrawText(x + 11 + width, y + 24, "|-        |", color);
        DrawText(x + 11 + width, y + 25, "|         |", color);
        DrawText(x + 11 + width, y + 26, "|_________|", color);
        DrawText(x + 11 + width, y + 27, "    ) (", color);
        DrawText(x + 11 + width, y + 28, "   {___}", color);

        for (int i = 1; i <= width; i++)
        {
            DrawText(x + 10 + i, y + 3, "-", color);
            DrawText(x + 10 + i, y + 26, "-", color);
        }
    }
}