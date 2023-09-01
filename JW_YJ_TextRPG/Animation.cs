using JW_YJ_TextRPG;
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

    public void UnfoldScroll(int x, int y)
    {
        Console.Clear();
        Program.ui.DrawScroll(x + 40, y, 0, "");
        Thread.Sleep(30);
        Console.Clear();
        Program.ui.DrawScroll(x + 35, y, 10, "");
        Thread.Sleep(30);
        Console.Clear();
        Program.ui.DrawScroll(x + 30, y, 20, "");
        Thread.Sleep(30);
        Console.Clear();
        Program.ui.DrawScroll(x + 25, y, 30, "");
        Thread.Sleep(30);
        Console.Clear();
        Program.ui.DrawScroll(x + 20, y, 40, "");
        Thread.Sleep(30);
        Console.Clear();
        Program.ui.DrawScroll(x + 15, y, 50, "");
        Thread.Sleep(30);
        Console.Clear();
        Program.ui.DrawScroll(x + 10, y, 60, "");
        Thread.Sleep(30);
        Console.Clear();
        Program.ui.DrawScroll(x + 5, y, 70, "");
        Thread.Sleep(30);
        Console.Clear();
        Program.ui.DrawScroll(x, y, 80, "");
        Thread.Sleep(30);
    }

    public void FoldScroll(int x, int y)
    {
        Console.Clear();
        Program.ui.DrawScroll(x, y, 80, "");
        Thread.Sleep(30);
        Console.Clear();
        Program.ui.DrawScroll(x + 5, y, 70, "");
        Thread.Sleep(30);
        Console.Clear();
        Program.ui.DrawScroll(x + 10, y, 60, "");
        Thread.Sleep(30);
        Console.Clear();
        Program.ui.DrawScroll(x + 15, y, 50, "");
        Thread.Sleep(30);
        Console.Clear();
        Program.ui.DrawScroll(x + 20, y, 40, "");
        Thread.Sleep(30);
        Console.Clear();
        Program.ui.DrawScroll(x + 25, y, 30, "");
        Thread.Sleep(30);
        Console.Clear();
        Program.ui.DrawScroll(x + 30, y, 20, "");
        Thread.Sleep(30);
        Console.Clear();
        Program.ui.DrawScroll(x + 35, y, 10, "");
        Thread.Sleep(30);
        Console.Clear();
        Program.ui.DrawScroll(x + 40, y, 0, "");
        Thread.Sleep(30);
    }
}
