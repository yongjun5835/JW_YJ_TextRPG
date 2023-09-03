using JW_YJ_TextRPG;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Story3 : StoryManager
{
    public Story3()
    {

    }

    public override void DrawDisplay()
    {
        Program.animation.FadeInOut(42, 10, 11, "3. 더 강한 적");
        Program.animation.UnfoldScroll(10, 0);
        Program.animation.DrawTextSlowly(42, 11, "고등어를 해치운 저는 의기양양해졌습니다.", "gray");
        Thread.Sleep(3000);
        Program.ui.ClearScroll(10, 0);
        Program.animation.DrawTextSlowly(49, 11, "자만을 하게 된 것이죠.", "gray");
        Thread.Sleep(3000);
        Program.ui.ClearScroll(10, 0);
        Program.animation.DrawTextSlowly(37, 11, "그런 제 앞에 바다의 깡패 상어가 나타났습니다.", "gray");
        Thread.Sleep(3000);
        Program.ui.ClearScroll(10, 0);
        Program.ui.DrawTexture(UnitType.Shark, 40, 5, "White");
        Program.animation.DrawTextSlowly(42, 15, "\"네 녀석이 내 친구 고등어를 먹은 참치냐?\"", "gray");
        Thread.Sleep(3000);
        Program.ui.ClearScroll(10, 0);
        Program.ui.DrawTexture(UnitType.Player, 40, 5, "Blue");
        Program.animation.DrawTextSlowly(45, 15, "\"그렇다. 내가 바로 그 참치다.\"", "gray");
        Thread.Sleep(3000);
        Program.ui.ClearScroll(10, 0);
        Program.ui.DrawTexture(UnitType.Shark, 40, 5, "White");
        Program.animation.DrawTextSlowly(43, 15, "\"참치주제에 간이 배 밖으로 나왔구나!\"", "gray");
        Thread.Sleep(3000);
        Program.ui.ClearScroll(10, 0);
        Program.ui.DrawTexture(UnitType.Shark, 40, 5, "Red");
        Program.animation.DrawTextSlowly(43, 15, "\"좋다. 내가 네 놈의 숨통을 끊어주마!\"", "Red");
        Thread.Sleep(3000);
        Program.animation.FoldScroll(10, 0);
        Thread.Sleep(1000);
        Program.battle.StartPhase(UnitType.Shark);
    }
}
