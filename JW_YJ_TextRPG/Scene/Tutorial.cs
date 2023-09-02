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
        Program.ui.DrawBox(48, 18, 27, 5, "gray");
        bool isSelect1 = false;
        string inputLive = "";
        while (isSelect1 == false)
        {
            Console.SetCursorPosition(50, 20);
            inputLive = Console.ReadLine();
            if (inputLive == "1")
            {
                Program.ui.ClearScroll(10, 0);
                Program.animation.DrawTextSlowly(47, 11, $"당신의 서식지는 '태평양'이군요.", "gray");
                isSelect1 = true;
            }
            else if (inputLive == "2")
            {
                Console.Clear();
                isSelect1 = true;
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