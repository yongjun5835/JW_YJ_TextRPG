using JW_YJ_TextRPG;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Story5 : StoryManager
{
    public Story5()
    {

    }

    public override void DrawDisplay()
    {
        Program.animation.FadeInOut(41, 10, 10, "5. 상어와의 재회");
        Program.animation.UnfoldScroll(10, 0);
        Program.animation.DrawTextSlowly(36, 11, "거북이와의 수련으로 저는 제가 강해졌음을 느꼈습니다.", "gray");
        Thread.Sleep(3000);
        Program.ui.ClearScroll(10, 0);
        Program.animation.DrawTextSlowly(47, 11, "저는 다시 용기가 생겼습니다.", "gray");
        Thread.Sleep(3000);
        Program.ui.ClearScroll(10, 0);
        Program.animation.DrawTextSlowly(35, 11, "저는 일전에 저를 쓰러뜨렸던 상어에게 다시 도전했습니다.", "gray");
        Thread.Sleep(3000);
        Program.ui.ClearScroll(10, 0);
        Program.ui.DrawTexture(UnitType.Shark, 40, 5, "White");
        Program.animation.DrawTextSlowly(44, 15, "\"네 녀석이 드디어 실성을 했구나!\"", "gray");
        Thread.Sleep(3000);
        Program.ui.ClearScroll(10, 0);
        Program.ui.DrawTexture(UnitType.Player, 40, 5, "Blue");
        Program.animation.DrawTextSlowly(43, 15, "\"이번에야 말로 네 놈을 혼내주겠다.\"", "gray");
        Thread.Sleep(3000);
        Program.ui.ClearScroll(10, 0);
        Program.ui.DrawTexture(UnitType.Shark, 40, 5, "White");
        Program.animation.DrawTextSlowly(45, 15, "\"약한 주제에 겁을 상실했구나!\"", "gray");
        Thread.Sleep(3000);
        Program.ui.ClearScroll(10, 0);
        Program.ui.DrawTexture(UnitType.Shark, 40, 5, "Red");
        Program.animation.DrawTextSlowly(42, 15, "\"좋다. 이번에야말로 숨통을 끊어주마!\"", "Red");
        Thread.Sleep(3000);
        Program.animation.FoldScroll(10, 0);
        Thread.Sleep(1000);
        Program.battle.StartPhase(UnitType.Shark);
    }
}
