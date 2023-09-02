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
        Program.animation.FadeInOut(42, 10, 10, "0. 이야기의 시작");
        Program.animation.UnfoldScroll(10, 0);
        Program.animation.DrawTextSlowly(49, 11, "당신의 이름은 무엇인가요?", "gray");
        Program.ui.DrawBox(48, 15, 27, 5, "gray");
        Console.SetCursorPosition(50, 17);
        Console.CursorVisible = true;
        string inputName = Console.ReadLine();
        Program.ui.ClearScroll(10, 0);
        Program.animation.DrawTextSlowly(48, 11, $"당신의 이름은 {inputName}이군요.", "gray");
        Thread.Sleep(3000);
        Program.ui.ClearScroll(10, 0);
        Program.animation.DrawTextSlowly(48, 8, "당신은 어디에 살고 계시죠?", "gray");
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
                Program.animation.DrawTextSlowly(47, 11, $"당신의 서식지는 '태평양'이군요.", "gray");
                isSelect2 = true;
                Console.CursorVisible = false;
            }
            else if (inputLive == "2")
            {
                Program.ui.ClearScroll(10, 0);
                Program.animation.DrawTextSlowly(47, 11, $"당신의 서식지는 '대서양'이군요.", "gray");
                isSelect2 = true;
                Console.CursorVisible = false;
            }
            else if (inputLive == "3")
            {
                Program.ui.ClearScroll(10, 0);
                Program.animation.DrawTextSlowly(47, 11, $"당신의 서식지는 '인도양'이군요.", "gray");
                isSelect2 = true;
                Console.CursorVisible = false;
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
        Program.animation.DrawTextSlowly(48, 8, "당신은 어떤 상태이신가요?", "gray");
        Program.ui.DrawText(48, 12, "[1] 치어 / 빠르지만 약하다.", "gray");
        Program.ui.DrawText(48, 13, "[2] 유어 / 밸런스가 괜찮다.", "gray");
        Program.ui.DrawText(48, 14, "[3] 성어 / 느리지만 강하다.", "gray");
        Program.ui.DrawBox(48, 18, 27, 5, "gray");
        bool isSelect1 = false;
        string inputAge = "";
        Console.CursorVisible = true;
        while (isSelect1 == false)
        {
            Console.SetCursorPosition(50, 20);
            inputAge = Console.ReadLine();
            if (inputAge == "1")
            {
                Program.ui.ClearScroll(10, 0);
                Program.animation.DrawTextSlowly(48, 11, $"당신은 참치의 '치어'시군요.", "gray");
                isSelect1 = true;
                Console.CursorVisible = false;
            }
            else if (inputAge == "2")
            {
                Program.ui.ClearScroll(10, 0);
                Program.animation.DrawTextSlowly(48, 11, $"당신은 참치의 '유어'시군요.", "gray");
                isSelect1 = true;
                Console.CursorVisible = false;
            }
            else if (inputAge == "3")
            {
                Program.ui.ClearScroll(10, 0);
                Program.animation.DrawTextSlowly(48, 11, $"당신은 참치의 '성어'시군요.", "gray");
                isSelect1 = true;
                Console.CursorVisible = false;
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