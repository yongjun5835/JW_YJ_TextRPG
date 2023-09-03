using JW_YJ_TextRPG;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class BossBattle
{
    public Unit enemy;
    public bool isFaster;
    public string input = "";
    public Random rand = new Random();

    public void StartPhase()
    {
        enemy = new Unit(UnitType.Angler);
        if (enemy.Spd <= Program.player.Spd)
        {
            isFaster = true;
        }
        else
        {
            isFaster = false;
        }
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
        Thread.Sleep(2000);
        ClearInfo();
        Program.animation.DrawTextSlowly(64, 2, $"{Program.player.Name}은(는) 분노로 몸이 끓어오른다.", "");
        Thread.Sleep(2000);
        while (Program.player.Hp > 0 && enemy.Hp > 0)
        {
            Console.Clear();
            DrawAngler("White");
            DrawDisplay();
            ClearInfo();
            Program.animation.DrawTextSlowly(64, 2, $"어떤 스킬을 사용할까?", "");
            Thread.Sleep(2000);

            bool isSelect1 = false;
            while (isSelect1 == false)
            {
                Console.CursorVisible = true;
                Console.SetCursorPosition(64, 27);
                input = Console.ReadLine();
                if (input == "1")
                {
                    isSelect1 = true;
                    Console.CursorVisible = false;
                    if (isFaster == true)
                    {
                        PlayerPhase();
                        EnemyPhase();
                    }
                    else
                    {
                        EnemyPhase();
                        PlayerPhase();
                    }
                }
                else if (input == "2")
                {
                    isSelect1 = true;
                    Console.CursorVisible = false;
                    if (isFaster == true)
                    {
                        PlayerPhase();
                        EnemyPhase();
                    }
                    else
                    {
                        EnemyPhase();
                        PlayerPhase();
                    }
                }
                else if (input == "3")
                {
                    isSelect1 = true;
                    Console.CursorVisible = false;
                    if (isFaster == true)
                    {
                        PlayerPhase();
                        EnemyPhase();
                    }
                    else
                    {
                        EnemyPhase();
                        PlayerPhase();
                    }
                }
                else if (input == "4")
                {
                    isSelect1 = true;
                    Console.CursorVisible = false;
                    if (isFaster == true)
                    {
                        PlayerPhase();
                        EnemyPhase();
                    }
                    else
                    {
                        EnemyPhase();
                        PlayerPhase();
                    }
                }
                else
                {
                    Program.ui.DrawText(63, 27, "                                                        ", "");
                }
            }
        }

        if (enemy.Hp <= 0)
        {
            // 엔딩 1로
        }
        else if (Program.player.Hp <= 0)
        {
            // 엔딩 2로
        }
    }

    public void PlayerPhase()
    {
        if (input == "1")
        {
            Program.player.Attack(1, enemy);
            Console.Clear();
            DrawDisplay();
            DrawAngler("white");
            Program.animation.DrawTextSlowly(64, 2, $"{Program.player.Name}{Program.player.SkillList[0].UseComment}", "");
            DrawAngler("Red");
            Thread.Sleep(500);
            DrawAngler("White");
            Thread.Sleep(500);
            DrawAngler("Red");
            Thread.Sleep(500);
            DrawAngler("White");
            Thread.Sleep(500);
        }
        else if (input == "2")
        {
            Program.player.Attack(1, enemy);
            Console.Clear();
            DrawDisplay();
            DrawAngler("white");
            Program.animation.DrawTextSlowly(64, 2, $"{Program.player.Name}{Program.player.SkillList[1].UseComment}", "");
            DrawAngler("Red");
            Thread.Sleep(500);
            DrawAngler("White");
            Thread.Sleep(500);
            DrawAngler("Red");
            Thread.Sleep(500);
            DrawAngler("White");
            Thread.Sleep(500);
        }
        else if (input == "3")
        {
            Program.player.Attack(1, enemy);
            Console.Clear();
            DrawDisplay();
            DrawAngler("white");
            Program.animation.DrawTextSlowly(64, 2, $"{Program.player.Name}{Program.player.SkillList[2].UseComment}", "");
            DrawAngler("Red");
            Thread.Sleep(500);
            DrawAngler("White");
            Thread.Sleep(500);
            DrawAngler("Red");
            Thread.Sleep(500);
            DrawAngler("White");
            Thread.Sleep(500);
        }
        else if (input == "4")
        {
            Program.player.Attack(1, enemy);
            Console.Clear();
            DrawDisplay();
            DrawAngler("white");
            Program.animation.DrawTextSlowly(64, 2, $"{Program.player.Name}{Program.player.SkillList[3].UseComment}", "");
            DrawAngler("Red");
            Thread.Sleep(500);
            DrawAngler("White");
            Thread.Sleep(500);
            DrawAngler("Red");
            Thread.Sleep(500);
            DrawAngler("White");
            Thread.Sleep(500);
        }
    }

    public void EnemyPhase()
    {
        int index = rand.Next(1, 5);
        enemy.Attack(index, Program.player);
        Console.Clear();
        DrawAngler("White");
        DrawDisplay();
        ClearInfo();
        Program.animation.DrawTextSlowly(64, 2, $"낚시꾼은 {enemy.SkillList[index - 1].Name}을(를) 사용했다!", "");
        Thread.Sleep(2000);
        ClearInfo();
        Program.animation.DrawTextSlowly(64, 2, $"나의 체력은 {Program.player.Hp}남았다.", "");
        Thread.Sleep(2000);
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

    public void ClearInfo()
    {
        Program.ui.DrawText(63, 2, "                                                        ", "");
    }

    public void DrawAngler(string color)
    {
        Program.ui.DrawBox(0, 0, 62, 30, "Gray");
        Program.bossStory.DrawPicture(1, 1, "⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿\r\n⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡿⣫⡗⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠿⠿⠿⠿⠿⠿⢿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿\r\n⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⢹⣿⣿⣿⠿⠛⠛⠉⠁⠀⠀⠀⠀⠀⠀⠀⠀⠉⠀⠀⠈⠋⠽⢻⠿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿\r\n⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣟⣵⣿⣇⣿⠟⠉⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠉⠲⢝⡿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿\r\n⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠿⠋⣾⣿⣿⠈⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠙⢮⡻⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿\r\n⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣋⡄⠐⠀⢸⣿⣿⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⢿⣿⣿⣿⣿⣿⣿⣿⣿\r\n⣿⣿⣿⣿⣿⣿⣿⣿⣿⡿⣭⣝⠿⢅⠀⠐⣼⣿⡇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢻⣿⣿⣿⣿⣿⣿⣿\r\n⣿⣿⣿⣿⣿⣿⣿⣿⣿⣷⣿⣿⣷⣿⣿⢆⣿⣿⠃⠀⠀⠀⠘⠐⠛⠀⠸⠿⠿⢿⠀⠸⠛⠓⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢿⣿⣿⣿⣿⣿⣿\r\n⣿⣿⣿⣿⣿⣿⣿⡿⣯⣿⣿⣿⣿⣿⡃⣸⣿⡏⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⣿⣿⣿⣿⣿⣿\r\n⣿⣿⣿⣿⣿⣿⣿⣿⣽⣛⢿⣿⢿⣿⣧⣿⡟⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢹⣿⣿⣿⣿⣿\r\n⣿⣿⣿⣿⣿⣿⣿⣿⢹⣿⣷⣉⣀⠉⣼⠏⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠘⣿⣿⣿⣿⣿\r\n⣿⣿⣿⣿⣿⣿⣟⣷⣿⣿⣿⣿⡟⠴⠋⠀⠀⠀⠀⠀⣼⡇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣿⣿⣿⣿⣿\r\n⣿⣿⣿⣿⣿⣿⣿⣾⢹⣿⣿⣿⣧⠀⠀⠀⠀⠀⠀⣸⣿⣧⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣿⣿⣿⣿⣿\r\n⣿⣿⣿⣿⣿⣿⣿⣿⣯⣫⣷⢠⠀⠀⠀⠀⠀⠀⢀⣿⣿⣿⡄⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣿⣿⣿⣿⣿\r\n⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣟⣿⠀⠀⠀⠀⠀⠀⣸⣿⣿⣛⣻⠀⠀⠀⠀⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣿⣿⣿⣿⣿\r\n⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡟⣿⣄⠀⠀⠀⢀⠀⣿⣿⣿⣿⣿⣷⡄⢀⠀⢱⣄⠀⠀⠀⣀⣀⣀⣀⠀⣷⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣿⣿⣿⣿⣿\r\n⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⢳⣿⡟⠀⠀⠀⢸⡜⠛⠉⠉⠉⠙⠛⢿⣿⣷⣦⣿⣷⣿⣿⣿⠟⠛⠋⠉⠉⠉⠛⠹⢷⡆⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢹⣿⣿⣿⣿\r\n⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣸⡿⠁⠀⠀⠀⠈⣀⣶⣿⠤⠀⠀⡀⠰⣿⣿⣿⣿⣿⣿⣿⣷⣾⡏⡤⠀⢀⠀⠀⠀⡆⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢻⣿⣿⣿\r\n⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡿⠁⢀⣂⠀⠀⠀⣽⣿⣿⡾⣾⣇⣣⢤⣿⣿⣿⣿⣿⣿⣿⣿⣿⣧⣶⣿⣌⣽⣿⣣⡏⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠸⣿⣿⣿\r\n⣿⣿⣿⣿⣿⣿⣿⣿⣿⡟⠁⢠⣿⣿⠀⠀⠀⢱⢻⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣟⣛⣻⣯⣽⡇⠀⠀⠀⣠⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣿⣿⣿\r\n⣿⣿⣿⣿⣿⣿⣿⣿⣿⠁⢀⣿⣿⣿⠀⠀⠀⠀⢸⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠀⠀⠀⠠⠿⠟⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣿⣿⣿\r\n⣿⣿⣿⣿⣿⣿⣿⣿⠇⠀⣸⣿⣿⣿⠀⠀⠀⠀⠈⢿⣿⣿⣿⣿⣿⣿⣿⣿⢛⣻⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠃⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣿⣿⣿\r\n⣿⣿⣿⣿⣿⣿⣿⣿⣆⠀⣿⣿⣿⣿⣇⠀⠀⠀⠀⠀⠉⠛⠿⣿⣿⣿⣿⣿⣿⣿⣾⣿⣿⣿⣿⣿⣿⠿⠟⠃⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣾⣿⣿⣿\r\n⣿⣿⣿⣿⣿⣿⣿⣿⣿⣄⢸⣿⣿⣿⣿⣷⣄⠀⠀⠀⠀⠀⠀⠀⠀⠉⠙⠙⠛⠛⠛⠯⠛⠉⠉⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣠⣶⣿⣿⣿⣿⣿\r\n⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣷⣭⣙⠛⠉⢉⣴⣿⣷⣶⣤⣄⣀⣀⣀⣀⠀⠀⠀⠀⠠⠀⠀⠀⠈⠁⠀⠀⠀⠀⢀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠘⣿⣿⣿⣿⣿⣿⣿⣿⣿\r\n⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠏⠀⠀⣠⣀⣀⣀⣤⣄⢀⣤⣤⠀⠀⠀⠈⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣿⣿⣿⣿⣿⣿⣿⣿⣿\r\n⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⢻⢿⣿⣯⣿⣿⣿⣿⣽⣾⣶⣿⢏⠤⣀⠀⠈⠀⠀⠀⠀⠀⠀⠀⠀⠀⣾⣿⣿⣿⣿⣿⣿⣿⣿⣿\r\n⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣯⣿⣾⣬⡟⠷⠷⣴⣿⣿⢿⣿⣼⣿⠛⠋⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⣿⣿⣿⣿⣿⣿⣿⣿⣿", color);
    }
}