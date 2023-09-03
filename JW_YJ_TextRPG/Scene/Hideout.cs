using JW_YJ_TextRPG;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Hideout
{
    protected int storyProgress { get; set; }

    public Hideout()
    {
        storyProgress = 1;
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
        Thread.Sleep(10000000);
    }
}