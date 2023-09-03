using JW_YJ_TextRPG;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

internal class Ending
{
    public void Ending1()
    {
        Program.animation.FadeInOut(42, 10, 12, "C R E D I T");
        Program.animation.UnfoldScroll(10, 0);
        Program.ui.ClearScroll(10, 0);
        Program.animation.DrawTextSlowly(50, 11, "기획 / 노재우, 조용준.", "gray");
        Thread.Sleep(5000);
        Program.ui.ClearScroll(10, 0);
        Program.animation.DrawTextSlowly(50, 11, "아트 / 노재우, 조용준.", "gray");
        Thread.Sleep(5000);
        Program.ui.ClearScroll(10, 0);
        Program.animation.DrawTextSlowly(50, 11, "코딩 / 노재우, 조용준.", "gray");
        Thread.Sleep(5000);
        Program.ui.ClearScroll(10, 0);
        Program.animation.DrawTextSlowly(50, 11, "즐겨주셔서 감사합니다.", "gray");
        Thread.Sleep(5000);
        Program.animation.FoldScroll(10, 0);
        Thread.Sleep(1000);
        Environment.Exit(0);
    }

    public void Ending2()
    {
        Program.animation.FadeInOut(42, 10, 12, "GAME OVER");
        Program.animation.UnfoldScroll(10, 0);
        Program.ui.ClearScroll(10, 0);
        Program.animation.DrawTextSlowly(50, 11, "즐겨주셔서 감사합니다.", "gray");
        Thread.Sleep(5000);
        Program.ui.ClearScroll(10, 0);
        Program.animation.DrawTextSlowly(46, 8, "게임을 처음부터 다시 시작할까요?", "gray");
        Program.ui.DrawText(48, 12, "[1] 게임을 다시 시작합니다..", "gray");
        Program.ui.DrawText(48, 13, "[2] 프로그램을 종료시킵니다.", "gray");
        Program.ui.DrawBox(48, 18, 27, 5, "gray");
        bool isSelect2 = false;
        string inputLive = "";
        while (isSelect2 == false)
        {
            Console.SetCursorPosition(50, 20);
            inputLive = Console.ReadLine();
            if (inputLive == "1")
            {
                Program.animation.FoldScroll(10, 0);
                Thread.Sleep(1000);
                isSelect2 = true;
                Console.CursorVisible = false;
                Program.player = new Unit(UnitType.Player);
                Program.createPlayer.DrawDisplay();
            }
            else if (inputLive == "2")
            {
                isSelect2 = true;
                Console.CursorVisible = false;
            }
            else
            {
                Program.ui.ClearScroll(10, 0);
                Program.animation.DrawTextSlowly(46, 8, "게임을 처음부터 다시 시작할까요?", "gray");
                Program.ui.DrawText(48, 12, "[1] 게임을 다시 시작합니다..", "gray");
                Program.ui.DrawText(48, 13, "[2] 프로그램을 종료시킵니다.", "gray");
            }
        }
        Program.animation.FoldScroll(10, 0);
        Thread.Sleep(1000);
        Environment.Exit(0);
    }
}