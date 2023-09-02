using JW_YJ_TextRPG;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Tutorial
{
    public Tutorial()
    {

    }

    public void DrawDisplay()
    {
        Program.animation.BiggerBox(32, 5);
        Program.animation.DrawTextSlowly(48, 8, "튜토리얼을 진행하시겠습니까?", "gray");
        Program.ui.DrawText(48, 12, "[1] 진행한다", "gray");
        Program.ui.DrawText(48, 13, "[2] 스킵한다", "gray");
        Program.ui.DrawBox(48, 17, 27, 5, "gray");
        bool isSelect1 = false;
        string inputLive = "";
        while (isSelect1 == false)
        {
            Console.CursorVisible = true;
            Console.SetCursorPosition(50, 19);
            inputLive = Console.ReadLine();
            if (inputLive == "1")
            {
                Console.Clear();
                Program.animation.SmallerBox(32, 5);
                Thread.Sleep(1000);
                Program.battle.StartPhase(UnitType.Player);
                isSelect1 = true;
                Console.CursorVisible = false;
            }
            else if (inputLive == "2")
            {
                Console.Clear();
                Program.animation.SmallerBox(32, 5);
                Thread.Sleep(1000);
                isSelect1 = true;
                Console.CursorVisible = false;
            }
            else
            {
                Console.Clear();
                Program.ui.DrawBox(32, 5, 60, 20, "Gray");
                Program.animation.DrawTextSlowly(48, 8, "올바른 번호를 입력해주세요.", "gray");
                Program.ui.DrawText(48, 12, "[1] 진행한다", "gray");
                Program.ui.DrawText(48, 13, "[2] 스킵한다", "gray");
                Program.ui.DrawBox(48, 18, 27, 5, "gray");
            }
        }
    }
}