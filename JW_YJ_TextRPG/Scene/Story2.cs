using JW_YJ_TextRPG;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Story2 : StoryManager
{
    public Story2()
    {

    }

    public override void DrawDisplay()
    {
        Program.animation.FadeInOut(42, 10, 9, "2. 고등어와의 전투");
        Program.animation.UnfoldScroll(10, 0);
        Program.animation.DrawTextSlowly(45, 11, "저는 낚시꾼에게 복수를 하기 위해,", "gray");
        Thread.Sleep(5000);
        Program.ui.ClearScroll(10, 0);
        Program.animation.DrawTextSlowly(47, 11, "수련을 하기로 결심했습니다.", "gray");
        Thread.Sleep(5000);
        Program.ui.ClearScroll(10, 0);
        Program.animation.DrawTextSlowly(30, 11, "우선 동네 깡패 고등어를 혼내주기 위해 고등어의 서식지로 갔습니다.", "gray");
        Thread.Sleep(5000);
        Program.ui.ClearScroll(10, 0);
        Program.ui.DrawTexture(UnitType.Player, 40, 5, "Blue");
        Program.animation.DrawTextSlowly(42, 15, "\"다른 어류를 괴롭히는 널 혼내주러 왔다!\"", "gray");
        Thread.Sleep(5000);
        Program.ui.ClearScroll(10, 0);
        Program.ui.DrawTexture(UnitType.Scomber, 40, 5, "White");
        Program.animation.DrawTextSlowly(45, 15, "\"네놈이 감히 날 혼내주겠다고?\"", "gray");
        Thread.Sleep(5000);
        Program.ui.ClearScroll(10, 0);
        Program.ui.DrawTexture(UnitType.Scomber, 40, 5, "White");
        Program.animation.DrawTextSlowly(43, 15, "\"참치주제에 간이 배 밖으로 나왔구나!\"", "gray");
        Thread.Sleep(5000);
        Program.ui.ClearScroll(10, 0);
        Program.ui.DrawTexture(UnitType.Scomber, 40, 5, "White");
        Program.animation.DrawTextSlowly(43, 15, "\"좋다. 내가 네 놈의 숨통을 끊어주마!\"", "Red");
        Thread.Sleep(5000);
        Program.animation.FoldScroll(10, 0);
        Thread.Sleep(1000);
        Program.battle.StartPhase(UnitType.Scomber);
    }
}
