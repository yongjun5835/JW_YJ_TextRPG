using JW_YJ_TextRPG;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Story1
{
    public Story1()
    {

    }

    public void DrawDisplay()
    {
        Program.animation.FadeInOut(42, 10, 11, "1. 어미를 잃다");
        Program.animation.UnfoldScroll(10, 0);
        Program.animation.DrawTextSlowly(45, 11, "저는 자이언트 참치의 새끼입니다.", "gray");
        Thread.Sleep(5000);
        Program.ui.ClearScroll(10, 0);
        Program.animation.DrawTextSlowly(35, 11, "저는 여느때와 같이 엄마와 바다를 여행중이었습니다.", "gray");
        Thread.Sleep(5000);
        Program.ui.ClearScroll(10, 0);
        Program.animation.DrawTextSlowly(34, 11, "엄마는 늘 제게 낚시 바늘을 조심하라고 타이르셨습니다.", "gray");
        Thread.Sleep(5000);
        Program.ui.ClearScroll(10, 0);
        Program.animation.DrawTextSlowly(35, 11, "\"바늘에 아무리 맛있는게 걸려 있어도 절대 먹어선 안돼!\"", "Red");
        Thread.Sleep(5000);
        Program.ui.ClearScroll(10, 0);
        Program.animation.DrawTextSlowly(42, 11, "하지만 저는 호기심에 바늘을 물어버렸고,", "gray");
        Thread.Sleep(5000);
        Program.ui.ClearScroll(10, 0);
        Program.animation.DrawTextSlowly(36, 11, "곧 이어 바늘에 달린 낚시줄이 당겨지기 시작했습니다.", "gray");
        Thread.Sleep(5000);
        Program.ui.ClearScroll(10, 0);
        Program.animation.DrawTextSlowly(57, 11, $"\"안돼!!!\"", "Red");
        Thread.Sleep(5000);
        Program.ui.ClearScroll(10, 0);
        Program.animation.DrawTextSlowly(38, 11, "엄마는 저를 구하기 위해 바늘을 입으로 물으셨고,", "gray");
        Thread.Sleep(5000);
        Program.ui.ClearScroll(10, 0);
        Program.animation.DrawTextSlowly(40, 11, "바늘은 저에게서 빠져 엄마의 입에 걸렸습니다.", "gray");
        Thread.Sleep(5000);
        Program.ui.ClearScroll(10, 0);
        Program.animation.DrawTextSlowly(43, 11, "순간 낚시줄이 빠른 속도로 당겨졌고.", "gray");
        Thread.Sleep(5000);
        Program.ui.ClearScroll(10, 0);
        Program.animation.DrawTextSlowly(40, 11, "엄마는 순식간에 물 밖으로 끌려나가셨습니다.", "gray");
        Thread.Sleep(5000);
        Program.ui.ClearScroll(10, 0);
        Program.animation.DrawTextSlowly(57, 11, "\"엄마!!!\"", "Blue");
        Thread.Sleep(5000);
        Program.ui.ClearScroll(10, 0);
        Program.animation.DrawTextSlowly(41, 11, "낚시꾼은 탐욕스러운 표정으로 저희 엄마를.", "gray");
        Thread.Sleep(5000);
        Program.ui.ClearScroll(10, 0);
        Program.animation.DrawTextSlowly(57, 11, "( 콰 직 )", "Red");
        Thread.Sleep(5000);
        Program.ui.ClearScroll(10, 0);
        Program.animation.DrawTextSlowly(59, 11, ". . .", "Red");
        Thread.Sleep(5000);
        Program.ui.ClearScroll(10, 0);
        Program.animation.DrawTextSlowly(42, 11, "엄마... 미안해... 나 때문에 엄마가...", "gray");
        Thread.Sleep(5000);
        Program.ui.ClearScroll(10, 0);
        Program.animation.DrawTextSlowly(42, 11, "낚시꾼 너를 절대로 용서하지 않겠어...", "gray");
        Thread.Sleep(5000);
        Program.ui.ClearScroll(10, 0);
        Program.animation.DrawTextSlowly(57, 11, "낚 시 꾼 ! !", "Red");
        Thread.Sleep(5000);
        Program.animation.FoldScroll(10, 0);
        Thread.Sleep(1000);
    }
}
