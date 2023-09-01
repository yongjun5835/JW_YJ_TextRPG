﻿using JW_YJ_TextRPG;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Animation
{
    public Animation()
    {

    }

    public void SmallerBox(int x, int y)
    {
        Console.Clear();
        Program.ui.DrawBox(x, y, 60, 20, "Gray");
        Thread.Sleep(20);
        Console.Clear();
        Program.ui.DrawBox(x + 3, y + 1, 54, 18, "Gray");
        Thread.Sleep(20);
        Console.Clear();
        Program.ui.DrawBox(x + 6, y + 2, 48, 16, "Gray");
        Thread.Sleep(20);
        Console.Clear();
        Program.ui.DrawBox(x + 9, y + 3, 42, 14, "Gray");
        Thread.Sleep(20);
        Console.Clear();
        Program.ui.DrawBox(x + 12, y + 4, 36, 12, "Gray");
        Thread.Sleep(20);
        Console.Clear();
        Program.ui.DrawBox(x + 15, y + 5, 30, 10, "Gray");
        Thread.Sleep(20);
        Console.Clear();
        Program.ui.DrawBox(x + 18, y + 6, 24, 8, "Gray");
        Thread.Sleep(20);
        Console.Clear();
        Program.ui.DrawBox(x + 21, y + 7, 18, 6, "Gray");
        Thread.Sleep(20);
        Console.Clear();
        Program.ui.DrawBox(x + 24, y + 8, 12, 4, "Gray");
        Thread.Sleep(20);
    }

    public void BiggerBox(int x, int y)
    {
        Console.Clear();
        Program.ui.DrawBox(x + 24, y + 8, 12, 4, "Gray");
        Thread.Sleep(20);
        Console.Clear();
        Program.ui.DrawBox(x + 21, y + 7, 18, 6, "Gray");
        Thread.Sleep(20);
        Console.Clear();
        Program.ui.DrawBox(x + 18, y + 6, 24, 8, "Gray");
        Thread.Sleep(20);
        Console.Clear();
        Program.ui.DrawBox(x + 15, y + 5, 30, 10, "Gray");
        Thread.Sleep(20);
        Console.Clear();
        Program.ui.DrawBox(x + 12, y + 4, 36, 12, "Gray");
        Thread.Sleep(20);
        Console.Clear();
        Program.ui.DrawBox(x + 9, y + 3, 42, 14, "Gray");
        Thread.Sleep(20);
        Console.Clear();
        Program.ui.DrawBox(x + 6, y + 2, 48, 16, "Gray");
        Thread.Sleep(20);
        Console.Clear();
        Program.ui.DrawBox(x + 3, y + 1, 54, 18, "Gray");
        Thread.Sleep(20);
        Console.Clear();
        Program.ui.DrawBox(x, y, 60, 20, "Gray");
        Thread.Sleep(20);
    }

    public void UnfoldScroll(int x, int y)
    {
        Console.Clear();
        Program.ui.DrawScroll(x + 40, y, 0, "");
        Thread.Sleep(20);
        Console.Clear();
        Program.ui.DrawScroll(x + 35, y, 10, "");
        Thread.Sleep(20);
        Console.Clear();
        Program.ui.DrawScroll(x + 30, y, 20, "");
        Thread.Sleep(20);
        Console.Clear();
        Program.ui.DrawScroll(x + 25, y, 30, "");
        Thread.Sleep(20);
        Console.Clear();
        Program.ui.DrawScroll(x + 20, y, 40, "");
        Thread.Sleep(20);
        Console.Clear();
        Program.ui.DrawScroll(x + 15, y, 50, "");
        Thread.Sleep(20);
        Console.Clear();
        Program.ui.DrawScroll(x + 10, y, 60, "");
        Thread.Sleep(20);
        Console.Clear();
        Program.ui.DrawScroll(x + 5, y, 70, "");
        Thread.Sleep(20);
        Console.Clear();
        Program.ui.DrawScroll(x, y, 80, "");
        Thread.Sleep(20);
    }

    public void FoldScroll(int x, int y)
    {
        Console.Clear();
        Program.ui.DrawScroll(x, y, 80, "");
        Thread.Sleep(20);
        Console.Clear();
        Program.ui.DrawScroll(x + 5, y, 70, "");
        Thread.Sleep(20);
        Console.Clear();
        Program.ui.DrawScroll(x + 10, y, 60, "");
        Thread.Sleep(20);
        Console.Clear();
        Program.ui.DrawScroll(x + 15, y, 50, "");
        Thread.Sleep(20);
        Console.Clear();
        Program.ui.DrawScroll(x + 20, y, 40, "");
        Thread.Sleep(20);
        Console.Clear();
        Program.ui.DrawScroll(x + 25, y, 30, "");
        Thread.Sleep(20);
        Console.Clear();
        Program.ui.DrawScroll(x + 30, y, 20, "");
        Thread.Sleep(20);
        Console.Clear();
        Program.ui.DrawScroll(x + 35, y, 10, "");
        Thread.Sleep(20);
        Console.Clear();
        Program.ui.DrawScroll(x + 40, y, 0, "");
        Thread.Sleep(20);
    }
}
