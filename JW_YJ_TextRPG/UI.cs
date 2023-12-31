﻿using JW_YJ_TextRPG;
using System;
using System.Collections.Generic;
using System.Drawing;
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
            Console.ForegroundColor = ConsoleColor.DarkGray;
        else if (color == "gray")
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
            Console.ForegroundColor = ConsoleColor.DarkGray;
        else if (color == "gray")
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

    public void ClearScroll(int x, int y)
    {
        for (int i = 0; i < 22; i++)
        {
            DrawText(x + 11, y + 4 + i, "                                                                                ", "");
        }
    }

    public void DrawTexture(UnitType type, int x, int y, string color)
    {
        if (type == UnitType.Player)
        {
            Program.ui.DrawText(x + 0, y + 0, "⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣠⣴⢶⣶⠂⠀⠀⢀⣀⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀", color);
            Program.ui.DrawText(x + 0, y + 1, "⠀⠀⠀⠀⠀⠀⠀⠀⢀⣠⣾⣯⣤⣾⣃⣀⣠⡾⢻⡿⠁⠀⠀⠀⠀⠀⠀⢀⣀⣀", color);
            Program.ui.DrawText(x + 0, y + 2, "⠀⠀⠀⠀⣠⣴⠶⠟⠛⠉⠉⠉⠉⠉⠉⠙⠛⠿⢿⣥⣤⠀⡀⠀⠀⢀⣴⣿⣿⡏", color);
            Program.ui.DrawText(x + 0, y + 3, "⠀⢀⣴⠟⢫⣶⡄⠻⣦⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⠛⠻⢷⣾⣂⣾⣿⣿⡟⠀", color);
            Program.ui.DrawText(x + 0, y + 4, "⣰⣿⣧⣀⠈⠛⠁⠀⢻⡇⢰⣶⣶⣶⣶⣶⣶⠆⠀⠀⠀⠀⠀⠈⢻⣿⣿⣿⠁⠀", color);
            Program.ui.DrawText(x + 0, y + 5, "⠙⢦⣍⠉⠛⠀⢀⣠⡟⠀⠸⢿⣿⣿⠿⠋⠁⠀⠀⠀⠀⣀⣤⠶⠛⣿⣿⣿⣇⠀", color);
            Program.ui.DrawText(x + 0, y + 6, "⠀⠀⠉⠻⢶⣤⣀⡉⠀⠀⠀⠀⠀⠀⠀⠀⢀⣀⣤⠶⠛⠉⠀⠀⠀⠘⢿⣿⣿⡆", color);
            Program.ui.DrawText(x + 0, y + 7, "⠀⠀⠀⠀⠀⠀⠉⠙⠻⣿⡻⠶⣶⠚⠛⠛⠻⣯⣽⣦⠀⠀⠀⠀⠀⠀⠀⠙⠛⠛", color);
            Program.ui.DrawText(x + 0, y + 8, "⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⠛⠷⢿⡦⠀⠀⠀⠀⠉⠉⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀", color);
        }
        else if (type == UnitType.Scomber)
        {
            Program.ui.DrawText(x + 0, y + 0, "⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣠⣦⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀", color);
            Program.ui.DrawText(x + 0, y + 1, "⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣠⡾⠋⣻⣇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣀⡄⠀", color);
            Program.ui.DrawText(x + 0, y + 2, "⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣠⣾⣋⣠⣾⣏⣿⣄⡀⠀⠀⠀⠀⣀⣄⠀⠀⠀⠀⠀⣀⣴⣾⣿⠁⠀", color);
            Program.ui.DrawText(x + 0, y + 3, "⠀⠀⠀⠀⠀⣀⣤⣤⣶⡶⠶⣿⠟⠛⠛⠻⣿⡛⢻⣿⠛⢿⣟⠿⠿⠶⣿⣯⣽⣷⡄⠀⣠⣾⢛⣥⡿⠁⠀⠀", color);
            Program.ui.DrawText(x + 0, y + 4, "⠀⢠⣶⡿⠛⠻⣿⠄⠀⠀⠀⢿⣧⣠⣤⣤⣻⣥⣤⣭⣶⣾⣷⣶⣶⣶⣶⣶⣯⣿⣿⣿⣿⣷⢿⡿⠁⠀⠀⠀", color);
            Program.ui.DrawText(x + 0, y + 5, "⠀⠈⣻⣿⡿⠇⠀⠀⠀⠀⠀⢸⣿⣭⣉⣿⠉⠉⠉⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢉⣩⣽⣿⡻⣿⣷⡀⠀⠀⠀", color);
            Program.ui.DrawText(x + 0, y + 6, "⠀⠀⠈⠙⠻⢷⣦⣄⣀⣀⣠⡿⠃⠈⠉⠉⠀⠀⠀⠀⠀⠀⠀⣀⣀⣤⣤⣶⠿⣻⡿⠇⠈⠻⣦⣝⣷⡀⠀⠀", color);
            Program.ui.DrawText(x + 0, y + 7, "⠀⠀⠀⠀⠀⠀⠈⠉⠙⠛⠛⠿⠿⠷⣶⣶⣾⠿⠿⠿⠟⠛⠛⠋⠉⠉⠉⠻⠟⠋⠀⠀⠀⠀⠈⠙⠻⣷⠀⠀", color);
            Program.ui.DrawText(x + 0, y + 8, "⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⠛⠛⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀", color);
        }
        else if (type == UnitType.Shark)
        {
            Program.ui.DrawText(x + 0, y + 0, "⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣀⣴⢾⠇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀", color);
            Program.ui.DrawText(x + 0, y + 1, "⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⡾⠋⠀⢸⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣀⣄⠀", color);
            Program.ui.DrawText(x + 0, y + 2, "⠀⠀⢀⣀⣀⣀⣤⣤⣤⡴⠶⠶⠛⠀⠀⠀⢸⣄⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣤⠞⣹⠇⠀", color);
            Program.ui.DrawText(x + 0, y + 3, "⠀⢸⡏⠉⠉⠉⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠉⠛⠳⢦⣤⣀⣀⠀⠀⢀⡾⠁⢠⡟⠀⠀", color);
            Program.ui.DrawText(x + 0, y + 4, "⠀⠀⢻⡄⠀⠀⡀⠀⠀⠀⣷⠀⣿⠀⣿⠀⠀⠀⠀⠀⠀⠀⠉⠉⠙⠛⠛⠁⠀⣼⠁⠀⠀", color);
            Program.ui.DrawText(x + 0, y + 5, "⠀⠀⠈⢷⣄⣀⣁⣀⠀⠀⠈⠁⠈⠁⠈⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣀⡀⠀⢻⡄⠀⠀", color);
            Program.ui.DrawText(x + 0, y + 6, "⠀⠀⠀⠀⠈⣩⣿⣏⣀⣀⣀⣀⣀⣀⣀⣀⡀⠀⠀⣀⣀⣀⣤⡤⠶⠛⠉⠻⣦⣈⣷⡄⠀", color);
            Program.ui.DrawText(x + 0, y + 7, "⠀⠀⠀⠀⠀⠈⠉⠉⠉⠉⠉⠉⠉⠉⠉⠉⢳⣄⠀⢹⡏⠉⠀⠀⠀⠀⠀⠀⠀⠉⠙⠋⠀", color);
            Program.ui.DrawText(x + 0, y + 8, "⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀  ⠀⠙⠳⢦⣿⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀", color);
        }
        else if (type == UnitType.Turtle)
        {
            Program.ui.DrawText(x + 0, y + 0, "⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⡀⠰⠒⠒⡖⠒⠦⣄⡀⠀⠀⠀⠀⠀", color);
            Program.ui.DrawText(x + 0, y + 1, "⠀⠀⠀⠀⠀⠀⠀⠀⠀⢠⣞⠁⠀⠀⢀⡇⠀⠀⠀⢹⣄⠀⠀⠀⠀", color);
            Program.ui.DrawText(x + 0, y + 2, "⡴⠚⠉⠛⢦⡀⠀⠀⢠⠏⠈⠳⢤⡴⠋⠉⠲⣤⠞⠁⠘⢆⠀⠀⠀", color);
            Program.ui.DrawText(x + 0, y + 3, "⠹⡄⠈⠀⠀⢳⡤⡖⠋⠀⠀⠀⢸⠀⠀⠀⠀⢿⠀⠀⠀⠈⢳⣤⡀", color);
            Program.ui.DrawText(x + 0, y + 4, "⠀⠙⣆⠀⠀⢸⡀⠙⢦⣀⠀⠀⣾⠀⠀⠀⠀⢸⠀⠀⠀⠰⠋⠀⡽", color);
            Program.ui.DrawText(x + 0, y + 5, "⠀⠀⠈⠳⠀⣀⠑⣤⡀⠈⠛⠒⠧⠤⠤⠤⠤⠼⠖⠚⠁⢀⣠⠞⠁", color);
            Program.ui.DrawText(x + 0, y + 6, "⠀⠀⠀⠀⠀⠈⠉⡽⠉⠓⢲⡤⣤⣀⣀⣀⣀⣤⠤⡴⠒⠛⣇⠀⠀", color);
            Program.ui.DrawText(x + 0, y + 7, "⠀⠀⠀⠀⠀⢀⡼⠁⠀⣠⠎⠀⠀⠀⠀⠀⠀⠀⠀⠹⡄⠀⠸⡄⠀", color);
            Program.ui.DrawText(x + 0, y + 8, "⠀⠀⠀⠀⠸⠭⠤⠤⠴⠃⠀⠀⠀⠀⠀⠀⠀⠀⠀⠘⠧⠤⠤⠽⠀", color);
        }
        else if (type == UnitType.Angler)
        {
            Program.ui.DrawText(x + 0, y + 0, "⠀⠀⠀⠀⣴⣶⣤⠀⠀⠀⠀⠀⠀⠀⠀⢀⡴⠀⠀⠀⠀⠀⠀⠀⠀", color);
            Program.ui.DrawText(x + 0, y + 1, "⠀⠀⠀⠘⢿⣿⡿⠃⠀⠀⠀⠀⠀⡠⠞⠉⠃⠀⠀⠀⠀⠀⠀⠀⠀", color);
            Program.ui.DrawText(x + 0, y + 2, "⠀⠀⢠⣶⣦⡉⠀⠀⠀⣀⣀⡴⠛⠀⠀⠀⢀⠀⠀⠀⠀⠀⠀⠀⠀", color);
            Program.ui.DrawText(x + 0, y + 3, "⠀⢠⣿⣿⣿⢿⣶⣶⡿⠟⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀", color);
            Program.ui.DrawText(x + 0, y + 4, "⠀⣾⣿⣿⠏⠀⠈⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⢠⠀⠀⠀⠀⠀⠀⠀", color);
            Program.ui.DrawText(x + 0, y + 5, "⢰⣿⣿⣿⣶⣶⣶⡄⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠆⠀⠀⠀⠀⠀⠀", color);
            Program.ui.DrawText(x + 0, y + 6, "⠈⠛⠛⠛⠛⠻⣿⣷⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠄⠀⠀⠀⠀⠀", color);
            Program.ui.DrawText(x + 0, y + 7, "⣿⣿⣿⣿⣿⠀⢹⣿⣷⠀⠀⠀⢀⡀⢀⣤⣤⣄⡀⣨⣤⣤⡀⢀⣀", color);
            Program.ui.DrawText(x + 0, y + 8, "⠿⠿⠿⠿⠿⠀⠈⠻⠟⠁⠀⠀⠙⠻⠿⠋⠉⠻⠿⠟⠋⠙⠿⠿⠋", color);
        }
    }

    public void DrawHpBar(int x, int y, Unit unit)
    {
        int hpMultiple = unit.MaxHp / 30;
        Console.SetCursorPosition(x, y);
        Console.Write("|");
        Console.BackgroundColor = ConsoleColor.Red;
        for (int i = 1; hpMultiple * i <= unit.Hp; i++)
        {
            Console.Write(" ");
        }
        Console.ResetColor();
        Console.SetCursorPosition(x + 31, y);
        Console.Write("|");
    }


    public void DrawLeftScreen_ItemList(List<Item> List, bool playerItemSell)
    {
        DelScrollLeftPart();
        float value = 1.0f;
        Program.ui.DrawText(23, 5, $"이름", "White");
        Program.ui.DrawText(23 + 13, 5, $"┃ 정보", "White");
        Program.ui.DrawText(23 + 13 + 23, 5, $"┃ 가격", "White");
        Program.ui.DrawText(22, 6, $"━━━━━━━━━━─━━━╋──────────────────────╋─────", "");
        if (playerItemSell == true)
        {
            value = 0.8f;
        }
        for (int i = 0; i < 9; i++)
        {
            Program.ui.DrawText(23, 7 + i * 2, $"                                         ", "White");
            if (i >= List.Count)
            {
                continue;
            }
            Program.ui.DrawText(23, 7 + i * 2, $"{i + 1}.{List[i].Name}", "White");
            Program.ui.DrawText(38, 7 + i * 2, $"{List[i].Comment}", "White");
            Program.ui.DrawText(61, 7 + i * 2, $"{(int)(List[i].Gold * value)}", "White");
        }

        for (int i = 7; i < 25; i++)
        {
            Program.ui.DrawText(23 + 13 + 23, i, "┃", "white");
            Program.ui.DrawText(23 + 13, i, "┃", "white");
        }
    }

    public void DrawLeftScreen_SkillList(List<Skill> List)
    {
        DelScrollLeftPart();
        Program.ui.DrawText(23, 5, $"기술명", "White");
        Program.ui.DrawText(42, 5, $"┃ PP", "White");
        Program.ui.DrawText(50, 5, $"┃ 파워", "White");
        Program.ui.DrawText(56, 5, $"┃ 타입", "White");
        Program.ui.DrawText(22, 6, $"━━━━━━━━━━━━━━━━━━━━╋━━━━━━━╋━━━━━╋━━━━━━━", "");

        for (int i = 0; i < 9; i++)
        {
            if (i >= List.Count)
            {
                Program.ui.DrawText(23, 7 + i * 2, $"                                         ", "White");
                continue;
            }
            Program.ui.DrawText(23, 7 + i * 2, $"                                         ", "White");
            Program.ui.DrawText(23, 7 + i * 2, $" {i + 1}.{List[i].Name}", "White");
            Program.ui.DrawText(43, 7 + i * 2, $" {List[i].PP}/{List[i].MaxPP}", "White");
            Program.ui.DrawText(51, 7 + i * 2, $" {List[i].Power.ToString("n1")}", "White");
            Program.ui.DrawText(57, 7 + i * 2, $" {List[i].AttackType.ToString()}", "White");
        }

        for (int i = 7; i < 25; i++)
        {
            Program.ui.DrawText(42, i, "┃", "white");
            Program.ui.DrawText(50, i, "┃", "white");
            Program.ui.DrawText(56, i, "┃", "white");
        }
    }
    public void DelScrollSelectBlock(string addtxt)
    {
        Program.ui.DrawText(68, 23, "                                ", "White");
        Program.ui.DrawText(68, 23, addtxt, "White");
    }

    public void DelScrollOptionList()
    {
        for (int i = 4; i < 21; i++)
        {
            Program.ui.DrawText(66, i, "                                   ", "White");
        }

        Program.ui.DrawText(67, 4, "━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━", "Gray");
        Program.ui.DrawText(67, 8, "━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━", "Gray");
        Program.ui.DrawText(67, 12, "━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━", "Gray");
        Program.ui.DrawText(67, 16, "━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━", "Gray");
        Program.ui.DrawText(67, 20, "━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━", "Gray");
    }

    public void DelScrollLeftPart()
    {
        for (int i = 5; i < 25; i++)
        {
            Program.ui.DrawText(22, i, "                                           ", "Gray");
        }
    }


    public void Popup(List<Skill> skills)
    {
        int PosX = 50;
        Program.ui.DrawText(PosX, 10, "┌──────────────────────────┐", "Gray");
        Program.ui.DrawText(PosX, 11, "│        기술 목록         │", "Gray");
        Program.ui.DrawText(PosX, 12, "│                          │", "Gray");
        Program.ui.DrawText(PosX, 13, "│                          │", "Gray");
        Program.ui.DrawText(PosX, 14, "│                          │", "Gray");
        Program.ui.DrawText(PosX, 15, "│                          │", "Gray");
        Program.ui.DrawText(PosX, 16, "│                          │", "Gray");
        Program.ui.DrawText(PosX, 17, "│ 취소 0                   │", "Gray");
        Program.ui.DrawText(PosX, 18, "│                          │", "Gray");
        Program.ui.DrawText(PosX, 19, "└──────────────────────────┘", "Gray");

        for (int i = 0; i < 4; i++)
        {
            Program.ui.DrawText(PosX+5, 13+i, $"{i+1}. {skills[i].Name}", "");
        }

        Program.ui.DrawText(PosX+2, 18, "선택 : ", "");

    }


}