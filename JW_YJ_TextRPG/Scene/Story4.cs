using JW_YJ_TextRPG;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Story4 : StoryManager
{
    public Story4()
    {

    }

    public override void DrawDisplay()
    {
        Program.animation.FadeInOut(42, 10, 8, "4. 바다거북과의 만남");
        Program.animation.UnfoldScroll(10, 0);
        Program.animation.DrawTextSlowly(39, 11, "상어에게 패배한 저는 회의감에 빠졌습니다...", "gray");
        Thread.Sleep(5000);
        Program.ui.ClearScroll(10, 0);
        Program.animation.DrawTextSlowly(41, 11, "내가 정말 낚시꾼에게 복수 할 수 있을까?", "gray");
        Thread.Sleep(5000);
        Program.ui.ClearScroll(10, 0);
        Program.animation.DrawTextSlowly(34, 11, "자이언트 참치의 자식인 내가 겨우 상어에게 패배하다니...", "gray");
        Thread.Sleep(5000);
        Program.ui.ClearScroll(10, 0);
        Program.ui.DrawTexture(UnitType.Turtle, 40, 5, "White");
        Program.animation.DrawTextSlowly(42, 15, "\"네 녀석이 상어와 싸웠다던 참치냐?\"", "gray");
        Thread.Sleep(5000);
        Program.ui.ClearScroll(10, 0);
        Program.ui.DrawTexture(UnitType.Player, 40, 5, "Blue");
        Program.animation.DrawTextSlowly(45, 15, "\"그렇소만... 당신은 누구시죠?\"", "gray");
        Thread.Sleep(5000);
        Program.ui.ClearScroll(10, 0);
        Program.ui.DrawTexture(UnitType.Turtle, 40, 5, "White");
        Program.animation.DrawTextSlowly(40, 15, "\"요 녀석아 너는 상어에게 100년은 이르다!\"", "gray");
        Thread.Sleep(5000);
        Program.ui.ClearScroll(10, 0);
        Program.ui.DrawTexture(UnitType.Player, 40, 5, "Blue");
        Program.animation.DrawTextSlowly(46, 15, "\"지금 저를 조롱하시는 건가요?\"", "gray");
        Thread.Sleep(5000);
        Program.ui.ClearScroll(10, 0);
        Program.ui.DrawTexture(UnitType.Turtle, 40, 5, "White");
        Program.animation.DrawTextSlowly(46, 15, "\"녀석 성질 한 번 고약하구나!\"", "gray");
        Thread.Sleep(5000);
        Program.ui.ClearScroll(10, 0);
        Program.ui.DrawTexture(UnitType.Turtle, 40, 5, "White");
        Program.animation.DrawTextSlowly(40, 15, "\"이몸께서 네 놈을 더 강하게 만들어주마!\"", "gray");
        Thread.Sleep(5000);
        Program.ui.ClearScroll(10, 0);
        Program.ui.DrawTexture(UnitType.Turtle, 40, 5, "White");
        Program.animation.DrawTextSlowly(33, 15, "\"준비가 되면 나를 찾아오거라. 나는 트레이닝센터에 있으마!\"", "gray");
        Thread.Sleep(5000);
        Program.animation.FoldScroll(10, 0);
        Thread.Sleep(1000);
        Program.hideout.DrawDisplay();
    }
}
