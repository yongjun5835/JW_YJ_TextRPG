using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Intro
{
    public Intro()
    {
        
    }

    public void DrawDisplay()
    {
        Console.Clear();
        Thread.Sleep(400);
        DrawTuna(35, 5, "Gray");
        Thread.Sleep(400);
        DrawTuna(35, 5, "gray");
        Thread.Sleep(400);
        DrawTuna(35, 5, "White");
        Thread.Sleep(400);
        DrawTuna(35, 5, "Red");
        Thread.Sleep(400);
        DrawTuna(35, 5, "White");
        Thread.Sleep(400);
        DrawTuna(35, 5, "Red");
        Thread.Sleep(400);
        DrawTuna(35, 5, "White");
        Thread.Sleep(400);
        DrawTuna(35, 5, "Red");
        Thread.Sleep(400);
        DrawTuna(35, 5, "White");
        Thread.Sleep(2000);
        DrawTuna(35, 5, "gray");
        Thread.Sleep(400);
        DrawTuna(35, 5, "Gray");
        Thread.Sleep(400);
        Console.Clear();
        Thread.Sleep(400);
        TunaText(35, 10, "Gray");
        Thread.Sleep(400);
        TunaText(35, 10, "gray");
        Thread.Sleep(400);
        TunaText(35, 10, "White");
        Thread.Sleep(2000);
        TunaText(35, 10, "gray");
        Thread.Sleep(400);
        TunaText(35, 10, "Gray");
        Thread.Sleep(400);
        Console.Clear();
        Thread.Sleep(2000);
    }

    public void DrawTuna(int x, int y, string color)
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
        Console.SetCursorPosition(x, y + 0);
        Console.Write("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@~ @@@@@@@@@@@@@@@@@");
        Console.SetCursorPosition(x, y + 1);
        Console.Write("@@@@@@@@@@@@@@@@@@@**=@@@@@@@@@*~.:@@@@@@@@@@@@=@@@@");
        Console.SetCursorPosition(x, y + 2);
        Console.Write("@@@@@@@@@@@@@@@@@@!,,-;:@@@@@#;.:!@@@@@@@@@@@;;,@@@@");
        Console.SetCursorPosition(x, y + 3);
        Console.Write("@@@@@@@@@@@@@@@@@~,,,,,,-#@@#--,!@@@@@@@@@@@;..$@@@@");
        Console.SetCursorPosition(x, y + 4);
        Console.Write("@@@@@@@@@@@@@@@!.....-,, !:,~@@@@@@@@@@@@!  :@@@@@@@");
        Console.SetCursorPosition(x, y + 5);
        Console.Write("@@@@@@@@@@#$.                     =$@@@@@@!  $@@@@@@");
        Console.SetCursorPosition(x, y + 6);
        Console.Write("@@@@@@@@@*~*                         $#@@=   $@@@@@@");
        Console.SetCursorPosition(x, y + 7);
        Console.Write("@@@@@@@; ~~-:                        ,~:;,  ~#@@@@@@");
        Console.SetCursorPosition(x, y + 8);
        Console.Write("@@@@@@~.  :.,                               *@@@@@@@");
        Console.SetCursorPosition(x, y + 9);
        Console.Write("@@@@@@,          ~,,,,,,,,,,,,,,,*########* *@@@@@@@");
        Console.SetCursorPosition(x, y + 10);
        Console.Write("@@@@@@~=######;~~~~~~~~~~;##########$#=~@.   $@@@@@@");
        Console.SetCursorPosition(x, y + 11);
        Console.Write("@@@@@@@; !#######################=$!;!==@@!   $@@@@@");
        Console.SetCursorPosition(x, y + 12);
        Console.Write("@@@@@@@@!~*######$$$$$#######$:=;#**@@@@@@:  ~@@@@@@");
        Console.SetCursorPosition(x, y + 13);
        Console.Write("@@@@@@@@@$;=@####$$$$$#####@;~ ~#@@@@@@@@@@:  @@@@@@");
        Console.SetCursorPosition(x, y + 14);
        Console.Write("@@@@@@@@@@@@@ *##########= !:,~@@@@@@@@@@@@@~  @@@@@");
        Console.SetCursorPosition(x, y + 15);
        Console.Write("@@@@@@@@@@@@@@#$=*$;~~~=$#@@#-,,*@@@@@@@@@@@@#-,@@@@");
        Console.SetCursorPosition(x, y + 16);
        Console.Write("@@@@@@@@@@@@@@@@@!:!@@@@@@@@@@:::!@@@@@@@@@@@@@!@@@@");
        Console.SetCursorPosition(x, y + 17);
        Console.Write("@@@@@@@@@@@@@@@@@@*$@@@@@@@@@@@#*-:@@@@@@@@@@@@@@@@@");
        Console.SetCursorPosition(x, y + 18);
        Console.Write("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@#,@@@@@@@@@@@@@@@@@");
        Console.ResetColor();
    }

    public void TunaText(int x, int y, string color)
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
        Console.SetCursorPosition(x, y + 0);
        Console.Write("  ::::::::::   :::    :::    ::::    :::        ::: ");
        Console.SetCursorPosition(x, y + 1);
        Console.Write("     :+:      :+:    :+:    :+:+:   :+:      :+: :+:");
        Console.SetCursorPosition(x, y + 2);
        Console.Write("    +:+      +:+    +:+    :+:+:+  +:+     +:+   +:+");
        Console.SetCursorPosition(x, y + 3);
        Console.Write("   +#+      +#+    +:+    +#+ +:+ +#+    +#++:++#++:");
        Console.SetCursorPosition(x, y + 4);
        Console.Write("  +#+      +#+    +#+    +#+  +#+#+#    +#+     +#+ ");
        Console.SetCursorPosition(x, y + 5);
        Console.Write(" #+#      #+#    #+#    #+#   #+#+#    #+#     #+#  ");
        Console.SetCursorPosition(x, y + 6);
        Console.Write("###       ########     ###    ####    ###     ###   ");
        Console.ResetColor();
    }
}