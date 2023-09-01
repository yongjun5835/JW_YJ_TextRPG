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
        Console.SetCursorPosition(x, y);
        Console.Write(text);
        Console.ResetColor();
    }

    public void DrawUI(int type, int x, int y, string text, string color)
    {
        if (type == 1)
        {
            DrawText(x, y + 0, " ______________.-'-.______________", color);
            DrawText(x, y + 1, "(_                               _)", color);
            DrawText(x, y + 2, "", color);
            DrawText(x + 13, y + 3, text, color);
            DrawText(x, y + 4, " _                               _", color);
            DrawText(x, y + 5, "(______________     ______________)", color);
            DrawText(x, y + 6, "               '-.-'", color);
        }
    }
}