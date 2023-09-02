using JW_YJ_TextRPG;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class CreatePlayer
{
    public CreatePlayer()
    {

    }

    public void DrawDisplay()
    {
        Program.animation.UnfoldScroll(10, 0);
        Program.animation.DrawTextSlowly(48, 11, "당신의 이름을 입력해주세요.", "gray");
        Program.ui.DrawBox(48, 15, 27, 5, "gray");
        Console.SetCursorPosition(50, 17);
        string inputName = Console.ReadLine();
        Program.ui.ClearScroll(10, 0);
        Program.animation.DrawTextSlowly(48, 11, $"당신의 이름은 {inputName}입니다.", "gray");
        Thread.Sleep(3000);
        Program.ui.ClearScroll(10, 0);
        Program.animation.DrawTextSlowly(48, 8, "현재 서식지를 선택해주세요.", "gray");
        Program.ui.DrawText(48, 12, "[1] 태평양 / 이지한 난이도.", "gray");
        Program.ui.DrawText(48, 13, "[2] 대서양 / 노말한 난이도.", "gray");
        Program.ui.DrawText(48, 14, "[3] 인도양 / 하드한 난이도.", "gray");
        Program.ui.DrawBox(48, 18, 27, 5, "gray");
        bool isSelect2 = false;
        string inputLive = "";
        while (isSelect2 == false)
        {
            Console.SetCursorPosition(50, 20);
            inputLive = Console.ReadLine();
            if (inputLive == "1")
            {
                Program.ui.ClearScroll(10, 0);
                Program.animation.DrawTextSlowly(48, 11, $"현재 서식지는 '태평양'입니다.", "gray");
                isSelect2 = true;
            }
            else if (inputLive == "2")
            {
                Program.ui.ClearScroll(10, 0);
                Program.animation.DrawTextSlowly(48, 11, $"현재 서식지는 '대서양'입니다.", "gray");
                isSelect2 = true;
            }
            else if (inputLive == "3")
            {
                Program.ui.ClearScroll(10, 0);
                Program.animation.DrawTextSlowly(48, 11, $"현재 서식지는 '인도양'입니다.", "gray");
                isSelect2 = true;
            }
            else
            {
                Program.ui.ClearScroll(10, 0);
                Program.animation.DrawTextSlowly(48, 8, "올바른 번호를 입력해주세요.", "gray");
                Program.ui.DrawText(48, 12, "[1] 태평양 / 이지한 난이도.", "gray");
                Program.ui.DrawText(48, 13, "[2] 대서양 / 노말한 난이도.", "gray");
                Program.ui.DrawText(48, 14, "[3] 인도양 / 하드한 난이도.", "gray");
                Program.ui.DrawBox(48, 18, 27, 5, "gray");
            }
        }
        Thread.Sleep(3000);
        Program.ui.ClearScroll(10, 0);
        Program.animation.DrawTextSlowly(48, 8, "당신의 상태를 선택해주세요.", "gray");
        Program.ui.DrawText(48, 12, "[1] 치어 / 빠르지만 약하다.", "gray");
        Program.ui.DrawText(48, 13, "[2] 유어 / 밸런스가 괜찮다.", "gray");
        Program.ui.DrawText(48, 14, "[3] 성어 / 느리지만 강하다.", "gray");
        Program.ui.DrawBox(48, 18, 27, 5, "gray");
        bool isSelect1 = false;
        string inputAge = "";
        while (isSelect1 == false)
        {
            Console.SetCursorPosition(50, 20);
            inputAge = Console.ReadLine();
            if (inputAge == "1")
            {
                Program.ui.ClearScroll(10, 0);
                Program.animation.DrawTextSlowly(48, 11, $"당신의 상태는 '치어'입니다.", "gray");
                isSelect1 = true;
            }
            else if (inputAge == "2")
            {
                Program.ui.ClearScroll(10, 0);
                Program.animation.DrawTextSlowly(48, 11, $"당신의 상태는 '유어'입니다.", "gray");
                isSelect1 = true;
            }
            else if (inputAge == "3")
            {
                Program.ui.ClearScroll(10, 0);
                Program.animation.DrawTextSlowly(48, 11, $"당신의 상태는 '성어'입니다.", "gray");
                isSelect1 = true;
            }
            else
            {
                Program.ui.ClearScroll(10, 0);
                Program.animation.DrawTextSlowly(48, 8, "올바른 번호를 입력해주세요.", "gray");
                Program.ui.DrawText(48, 12, "[1] 치어 / 빠르지만 약하다.", "gray");
                Program.ui.DrawText(48, 13, "[2] 유어 / 밸런스가 괜찮다.", "gray");
                Program.ui.DrawText(48, 14, "[3] 성어 / 느리지만 강하다.", "gray");
                Program.ui.DrawBox(48, 18, 27, 5, "gray");
            }
        }
        Thread.Sleep(3000);
        Program.animation.FoldScroll(10, 0);
        Thread.Sleep(1000);
    }
}