using JW_YJ_TextRPG;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Hideout
{
    public Hideout()
    {

    }

    public void DrawDisplay()
    {
        Program.animation.FadeInOut(42, 10, 15, "은신처");
        Program.animation.UnfoldScroll(10, 0);
        Program.ui.DrawBox(21, 4, 45, 22, "Gray");
        Program.ui.DrawTexture(UnitType.Player, 29, 5, "Blue");
        Program.ui.DrawText(22, 14, "-------------------------------------------", "Gray");
        Program.ui.DrawText(37, 16, $"이  름: {Program.player.Name}", "White");
        Program.ui.DrawText(37, 17, $"서식지: {Program.player.Habitat}", "White");
        Program.ui.DrawText(37, 18, $"성  장: {Program.player.Grow}", "White");
        Program.ui.DrawText(37, 19, $"레  벨: {Program.player.Level}", "Yellow");
        Program.ui.DrawText(37, 20, $"체  력: {Program.player.Hp}", "Red");
        Program.ui.DrawText(37, 21, $"공격력: {Program.player.Atk}", "Red");
        Program.ui.DrawText(37, 22, $"방어력: {Program.player.Def}", "Red");
        Program.ui.DrawText(37, 23, $"스피드: {Program.player.Spd}", "Red");

        Program.ui.DrawText(67, 4, "━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━", "Gray");
        Program.ui.DrawText(76, 6, "[1] 스토리 진행", "White");
        Program.ui.DrawText(67, 8, "━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━", "Gray");
        Program.ui.DrawText(76, 10, "[2] 바다 거래소", "White");
        Program.ui.DrawText(67, 12, "━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━", "Gray");
        Program.ui.DrawText(77, 14, "[3] 스킬관리", "White");
        Program.ui.DrawText(67, 16, "━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━", "Gray");
        Program.ui.DrawText(77, 18, "[4] 트레이닝", "White");
        Program.ui.DrawText(67, 20, "━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━", "Gray");

        Program.ui.DrawBox(66, 21, 35, 5, "Gray");

        bool isSelect1 = false;
        string input = "";
        Console.CursorVisible = true;
        while (isSelect1 == false)
        {
            Console.SetCursorPosition(68, 23);
            input = Console.ReadLine();
            if (input == "1")
            {
                Program.storyManager.Progress();
                isSelect1 = true;
                Console.CursorVisible = false;
            }
            else if (input == "2")
            {
                isSelect1 = true;
                Console.CursorVisible = false;
            }
            else if (input == "3")
            {
                isSelect1 = true;
                Console.CursorVisible = false;
            }
            else if (input == "4")
            {
                isSelect1 = true;
                Console.CursorVisible = false;
            }
            else
            {
                Console.SetCursorPosition(68, 23);
                Console.Write("                               ");
            }
        }
        Thread.Sleep(10000000);
    }
}