using JW_YJ_TextRPG;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class BossBattle
{
    public Unit enemy;

    public void StartPhase()
    {
        enemy = new Unit(UnitType.Angler);
        Console.Clear();
        DrawDisplay();
        Thread.Sleep(400);
        DrawAngler("Gray");
        Thread.Sleep(400);
        DrawAngler("gray");
        Thread.Sleep(400);
        DrawAngler("White");
        Thread.Sleep(400);
        Program.animation.DrawTextSlowly(64, 2, "어머니의 원수 낚시꾼이 모습을 드러냈다!", "");
        Thread.Sleep(40000);
    }

    public void DrawDisplay()
    {
        Program.ui.DrawBox(62, 0, 58, 5, "Gray");
        Program.ui.DrawBox(62, 5, 58, 7, "Gray");
        Program.ui.DrawHpBar(74, 7, enemy);
        Program.ui.DrawText(64, 7, "상대의 HP", "");
        Program.ui.DrawText(110, 7, $"{enemy.Hp}/{enemy.MaxHp}", "");
        Program.ui.DrawHpBar(74, 9, Program.player);
        Program.ui.DrawText(64, 9, "당신의 HP", "");
        Program.ui.DrawText(110, 9, $"{Program.player.Hp}/{Program.player.MaxHp}", "");
        Program.ui.DrawBox(62, 12, 58, 13, "Gray");
        Program.ui.DrawText(64, 15, "[N]", "");
        Program.ui.DrawText(68, 15, "| 스킬이름", "");
        Program.ui.DrawText(105, 15, "| PP / MaxPP", "");
        Program.ui.DrawText(64, 17, "[1]", "");
        Program.ui.DrawText(68, 17, $"| {Program.player.SkillList[0].Name}", "");
        Program.ui.DrawText(105, 17, $"| {Program.player.SkillList[0].PP} / {Program.player.SkillList[0].MaxPP}", "");
        Program.ui.DrawText(64, 18, "[2]", "");
        Program.ui.DrawText(68, 18, $"| {Program.player.SkillList[1].Name}", "");
        Program.ui.DrawText(105, 18, $"| {Program.player.SkillList[1].PP} / {Program.player.SkillList[1].MaxPP}", "");
        Program.ui.DrawText(64, 19, "[3]", "");
        Program.ui.DrawText(68, 19, $"| {Program.player.SkillList[2].Name}", "");
        Program.ui.DrawText(105, 19, $"| {Program.player.SkillList[2].PP} / {Program.player.SkillList[2].MaxPP}", "");
        Program.ui.DrawText(64, 20, "[4]", "");
        Program.ui.DrawText(68, 20, $"| {Program.player.SkillList[3].Name}", "");
        Program.ui.DrawText(105, 20, $"| {Program.player.SkillList[3].PP} / {Program.player.SkillList[3].MaxPP}", "");
        Program.ui.DrawBox(62, 25, 58, 5, "Gray");
    }

    public void DrawAngler(string color)
    {
        Program.ui.DrawBox(0, 0, 62, 30, "Gray");
        Program.bossStory.DrawPicture(1, 1, "⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿\r\n⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡿⣫⡗⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠿⠿⠿⠿⠿⠿⢿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿\r\n⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⢹⣿⣿⣿⠿⠛⠛⠉⠁⠀⠀⠀⠀⠀⠀⠀⠀⠉⠀⠀⠈⠋⠽⢻⠿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿\r\n⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣟⣵⣿⣇⣿⠟⠉⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠉⠲⢝⡿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿\r\n⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠿⠋⣾⣿⣿⠈⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠙⢮⡻⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿\r\n⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣋⡄⠐⠀⢸⣿⣿⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⢿⣿⣿⣿⣿⣿⣿⣿⣿\r\n⣿⣿⣿⣿⣿⣿⣿⣿⣿⡿⣭⣝⠿⢅⠀⠐⣼⣿⡇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢻⣿⣿⣿⣿⣿⣿⣿\r\n⣿⣿⣿⣿⣿⣿⣿⣿⣿⣷⣿⣿⣷⣿⣿⢆⣿⣿⠃⠀⠀⠀⠘⠐⠛⠀⠸⠿⠿⢿⠀⠸⠛⠓⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢿⣿⣿⣿⣿⣿⣿\r\n⣿⣿⣿⣿⣿⣿⣿⡿⣯⣿⣿⣿⣿⣿⡃⣸⣿⡏⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⣿⣿⣿⣿⣿⣿\r\n⣿⣿⣿⣿⣿⣿⣿⣿⣽⣛⢿⣿⢿⣿⣧⣿⡟⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢹⣿⣿⣿⣿⣿\r\n⣿⣿⣿⣿⣿⣿⣿⣿⢹⣿⣷⣉⣀⠉⣼⠏⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠘⣿⣿⣿⣿⣿\r\n⣿⣿⣿⣿⣿⣿⣟⣷⣿⣿⣿⣿⡟⠴⠋⠀⠀⠀⠀⠀⣼⡇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣿⣿⣿⣿⣿\r\n⣿⣿⣿⣿⣿⣿⣿⣾⢹⣿⣿⣿⣧⠀⠀⠀⠀⠀⠀⣸⣿⣧⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣿⣿⣿⣿⣿\r\n⣿⣿⣿⣿⣿⣿⣿⣿⣯⣫⣷⢠⠀⠀⠀⠀⠀⠀⢀⣿⣿⣿⡄⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣿⣿⣿⣿⣿\r\n⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣟⣿⠀⠀⠀⠀⠀⠀⣸⣿⣿⣛⣻⠀⠀⠀⠀⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣿⣿⣿⣿⣿\r\n⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡟⣿⣄⠀⠀⠀⢀⠀⣿⣿⣿⣿⣿⣷⡄⢀⠀⢱⣄⠀⠀⠀⣀⣀⣀⣀⠀⣷⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣿⣿⣿⣿⣿\r\n⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⢳⣿⡟⠀⠀⠀⢸⡜⠛⠉⠉⠉⠙⠛⢿⣿⣷⣦⣿⣷⣿⣿⣿⠟⠛⠋⠉⠉⠉⠛⠹⢷⡆⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢹⣿⣿⣿⣿\r\n⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣸⡿⠁⠀⠀⠀⠈⣀⣶⣿⠤⠀⠀⡀⠰⣿⣿⣿⣿⣿⣿⣿⣷⣾⡏⡤⠀⢀⠀⠀⠀⡆⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢻⣿⣿⣿\r\n⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡿⠁⢀⣂⠀⠀⠀⣽⣿⣿⡾⣾⣇⣣⢤⣿⣿⣿⣿⣿⣿⣿⣿⣿⣧⣶⣿⣌⣽⣿⣣⡏⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠸⣿⣿⣿\r\n⣿⣿⣿⣿⣿⣿⣿⣿⣿⡟⠁⢠⣿⣿⠀⠀⠀⢱⢻⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣟⣛⣻⣯⣽⡇⠀⠀⠀⣠⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣿⣿⣿\r\n⣿⣿⣿⣿⣿⣿⣿⣿⣿⠁⢀⣿⣿⣿⠀⠀⠀⠀⢸⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠀⠀⠀⠠⠿⠟⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣿⣿⣿\r\n⣿⣿⣿⣿⣿⣿⣿⣿⠇⠀⣸⣿⣿⣿⠀⠀⠀⠀⠈⢿⣿⣿⣿⣿⣿⣿⣿⣿⢛⣻⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠃⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣿⣿⣿\r\n⣿⣿⣿⣿⣿⣿⣿⣿⣆⠀⣿⣿⣿⣿⣇⠀⠀⠀⠀⠀⠉⠛⠿⣿⣿⣿⣿⣿⣿⣿⣾⣿⣿⣿⣿⣿⣿⠿⠟⠃⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣾⣿⣿⣿\r\n⣿⣿⣿⣿⣿⣿⣿⣿⣿⣄⢸⣿⣿⣿⣿⣷⣄⠀⠀⠀⠀⠀⠀⠀⠀⠉⠙⠙⠛⠛⠛⠯⠛⠉⠉⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣠⣶⣿⣿⣿⣿⣿\r\n⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣷⣭⣙⠛⠉⢉⣴⣿⣷⣶⣤⣄⣀⣀⣀⣀⠀⠀⠀⠀⠠⠀⠀⠀⠈⠁⠀⠀⠀⠀⢀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠘⣿⣿⣿⣿⣿⣿⣿⣿⣿\r\n⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠏⠀⠀⣠⣀⣀⣀⣤⣄⢀⣤⣤⠀⠀⠀⠈⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣿⣿⣿⣿⣿⣿⣿⣿⣿\r\n⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⢻⢿⣿⣯⣿⣿⣿⣿⣽⣾⣶⣿⢏⠤⣀⠀⠈⠀⠀⠀⠀⠀⠀⠀⠀⠀⣾⣿⣿⣿⣿⣿⣿⣿⣿⣿\r\n⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣯⣿⣾⣬⡟⠷⠷⣴⣿⣿⢿⣿⣼⣿⠛⠋⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⣿⣿⣿⣿⣿⣿⣿⣿⣿", color);
    }
}