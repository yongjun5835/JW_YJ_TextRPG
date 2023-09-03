using JW_YJ_TextRPG;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Battle
{
    public Battle()
    {
        
    }

    public bool isFaster;
    public Unit enemy;
    public Random rand = new Random();
    public int index;

    public void StartPhase(UnitType Unit)
    {
        enemy = new Unit(Unit);
        if (enemy.Spd <= Program.player.Spd)
        {
            isFaster = true;
        }
        else
        {
            isFaster = false;
        }
        DrawDisplay(Unit);
        Program.animation.DrawTextSlowly(46, 23, $"{enemy.Name}이(가) 모습을 드러냈다!", "White");
        Thread.Sleep(2000);
        DrawDisplay(Unit);
        Program.animation.DrawTextSlowly(46, 23, $"{Program.player.Name}은(는) 전투를 각오했다!", "White");
        Thread.Sleep(2000);
        ChoicePhase();
    }

    public void ChoicePhase()
    {
        DrawDisplay(enemy.UnitType);
        Program.animation.DrawTextSlowly(49, 23, $"다음은 어떤 행동을 할까?", "White");
        Thread.Sleep(2000);
        DrawDisplay(enemy.UnitType);
        Program.ui.DrawText(48, 21, "[1] 스킬사용", "gray");
        Program.ui.DrawText(48, 22, "[2] 도망간다", "gray");
        Program.ui.DrawBox(48, 23, 27, 5, "gray");
        bool isSelect1 = false;
        string input = "";
        while (isSelect1 == false)
        {
            Console.CursorVisible = true;
            Console.SetCursorPosition(50, 25);
            input = Console.ReadLine();
            if (input == "1")
            {
                BattlePhase();
                isSelect1 = true;
                Console.CursorVisible = false;
            }
            else if (input == "2")
            {
                Console.Clear();
                Program.animation.SmallerBox(32, 5);
                Thread.Sleep(1000);
                isSelect1 = true;
                Console.CursorVisible = false;
            }
            else
            {
                DrawDisplay(enemy.UnitType);
                Program.ui.DrawText(48, 21, "[1] 스킬사용", "gray");
                Program.ui.DrawText(48, 22, "[2] 도망간다", "gray");
                Program.ui.DrawBox(48, 23, 27, 5, "gray");
            }
        }
    }

    public void BattlePhase()
    {
        DrawDisplay(enemy.UnitType);
        Program.animation.DrawTextSlowly(50, 23, $"어떤 스킬을 사용할까?", "White");
        Thread.Sleep(2000);
        DrawDisplay(enemy.UnitType);

        Program.ui.DrawText(2, 21, "[N] 스킬 이름", "White");
        Program.ui.DrawText(22, 21, "|", "White");
        Program.ui.DrawText(24, 21, "스킬 설명", "White");
        Program.ui.DrawText(71, 21, "|", "White");
        Program.ui.DrawText(73, 21, "남은 PP / 맥스 PP", "White");

        Program.ui.DrawText(2, 23, $"[1] {Program.player.SkillList[0].Name}", "White");
        Program.ui.DrawText(22, 23, "|", "White");
        Program.ui.DrawText(24, 23, $"{Program.player.SkillList[0].Comment}", "White");
        Program.ui.DrawText(71, 23, "|", "White");
        Program.ui.DrawText(73, 23, $"{Program.player.SkillList[0].PP} / {Program.player.SkillList[0].MaxPP}", "White");

        Program.ui.DrawText(2, 24, $"[2] {Program.player.SkillList[1].Name}", "White");
        Program.ui.DrawText(22, 24, "|", "White");
        Program.ui.DrawText(24, 24, $"{Program.player.SkillList[1].Comment}", "White");
        Program.ui.DrawText(71, 24, "|", "White");
        Program.ui.DrawText(73, 24, $"{Program.player.SkillList[1].PP} / {Program.player.SkillList[1].MaxPP}", "White");

        Program.ui.DrawText(2, 25, $"[3] {Program.player.SkillList[2].Name}", "White");
        Program.ui.DrawText(22, 25, "|", "White");
        Program.ui.DrawText(24, 25, $"{Program.player.SkillList[2].Comment}", "White");
        Program.ui.DrawText(71, 25, "|", "White");
        Program.ui.DrawText(73, 25, $"{Program.player.SkillList[2].PP} / {Program.player.SkillList[2].MaxPP}", "White");

        Program.ui.DrawText(2, 26, $"[4] {Program.player.SkillList[3].Name}", "White");
        Program.ui.DrawText(22, 26, "|", "White");
        Program.ui.DrawText(24, 26, $"{Program.player.SkillList[3].Comment}", "White");
        Program.ui.DrawText(71, 26, "|", "White");
        Program.ui.DrawText(73, 26, $"{Program.player.SkillList[3].PP} / {Program.player.SkillList[3].MaxPP}", "White");

        Program.ui.DrawBox(91, 21, 27, 5, "gray");

        bool isSelect1 = false;
        string input = "";
        while (isSelect1 == false)
        {
            Console.CursorVisible = true;
            Console.SetCursorPosition(93, 23);
            input = Console.ReadLine();
            if (input == "1")
            {
                if (isFaster == true)
                {
                    index = rand.Next(1, 3);

                    Program.player.Attack(1, enemy);
                    DrawDisplay(enemy.UnitType);
                    Program.animation.DrawTextSlowly(46, 23, $"{Program.player.Name}이(가) {Program.player.SkillList[0].Name}을(를) 사용했다!", "White");
                    Thread.Sleep(2000);
                    DrawDisplay(enemy.UnitType);
                    Program.animation.DrawTextSlowly(46, 23, $"{Program.player.Name} {Program.player.SkillList[0].UseComment}", "Red");
                    Thread.Sleep(2000);
                    if (enemy.Hp <= 0)
                    {
                        DrawDisplay(enemy.UnitType);
                        Program.animation.DrawTextSlowly(46, 23, $"상대는 체력을 모두 소진했습니다!", "Blue");
                        Thread.Sleep(2000);
                        DrawDisplay(enemy.UnitType);
                        Program.animation.DrawTextSlowly(43, 23, $"상대는 {Program.player.Name}의 한 끼 식사가 되었습니다!.", "Blue");
                        Thread.Sleep(2000);
                        // 리워드 페이지로
                        break;
                    }

                    enemy.Attack(index, Program.player);
                    DrawDisplay(enemy.UnitType);
                    Program.animation.DrawTextSlowly(46, 23, $"{enemy.Name}이(가) {enemy.SkillList[index - 1].Name}을(를) 사용했다!", "White");
                    Thread.Sleep(2000);
                    DrawDisplay(enemy.UnitType);
                    Program.animation.DrawTextSlowly(46, 23, $"{enemy.Name} {enemy.SkillList[index - 1].UseComment}", "Red");
                    Thread.Sleep(2000);
                    if (Program.player.Hp <= 0)
                    {
                        DrawDisplay(enemy.UnitType);
                        Program.animation.DrawTextSlowly(46, 23, $"당신은 체력을 모두 소진했습니다!", "Red");
                        Thread.Sleep(2000);
                        DrawDisplay(enemy.UnitType);
                        Program.animation.DrawTextSlowly(46, 23, $"당신은 급하게 은신처로 갔습니다.", "Red");
                        Thread.Sleep(2000);
                        // 은신처로 돌아가기
                        break;
                    }

                    isSelect1 = true;
                    Console.CursorVisible = false;
                }
                else
                {
                    index = rand.Next(1, 3);

                    enemy.Attack(index, Program.player);
                    DrawDisplay(enemy.UnitType);
                    Program.animation.DrawTextSlowly(46, 23, $"{enemy.Name}이(가) {enemy.SkillList[index - 1].Name}을(를) 사용했다!", "White");
                    Thread.Sleep(2000);
                    DrawDisplay(enemy.UnitType);
                    Program.animation.DrawTextSlowly(46, 23, $"{enemy.Name} {enemy.SkillList[index - 1].UseComment}", "Red");
                    Thread.Sleep(2000);
                    if (Program.player.Hp <= 0)
                    {
                        DrawDisplay(enemy.UnitType);
                        Program.animation.DrawTextSlowly(46, 23, $"당신은 체력을 모두 소진했습니다!", "Red");
                        Thread.Sleep(2000);
                        DrawDisplay(enemy.UnitType);
                        Program.animation.DrawTextSlowly(46, 23, $"당신은 급하게 은신처로 갔습니다.", "Red");
                        Thread.Sleep(2000);
                        // 은신처로 돌아가기
                        break;
                    }

                    Program.player.Attack(1, enemy);
                    DrawDisplay(enemy.UnitType);
                    Program.animation.DrawTextSlowly(46, 23, $"{Program.player.Name}이(가) {Program.player.SkillList[0].Name}을(를) 사용했다!", "White");
                    Thread.Sleep(2000);
                    DrawDisplay(enemy.UnitType);
                    Program.animation.DrawTextSlowly(46, 23, $"{Program.player.Name} {Program.player.SkillList[0].UseComment}", "Red");
                    Thread.Sleep(2000);
                    if (enemy.Hp <= 0)
                    {
                        DrawDisplay(enemy.UnitType);
                        Program.animation.DrawTextSlowly(46, 23, $"상대는 체력을 모두 소진했습니다!", "Blue");
                        Thread.Sleep(2000);
                        DrawDisplay(enemy.UnitType);
                        Program.animation.DrawTextSlowly(43, 23, $"상대는 {Program.player.Name}의 한 끼 식사가 되었습니다!.", "Blue");
                        Thread.Sleep(2000);
                        // 리워드 페이지로
                        break;
                    }

                    isSelect1 = true;
                    Console.CursorVisible = false;
                }
            }
            else if (input == "2")
            {
                if (isFaster == true)
                {
                    index = rand.Next(1, 3);

                    Program.player.Attack(2, enemy);
                    DrawDisplay(enemy.UnitType);
                    Program.animation.DrawTextSlowly(46, 23, $"{Program.player.Name}이(가) {Program.player.SkillList[1].Name}을(를) 사용했다!", "White");
                    Thread.Sleep(2000);
                    DrawDisplay(enemy.UnitType);
                    Program.animation.DrawTextSlowly(46, 23, $"{Program.player.Name} {Program.player.SkillList[1].UseComment}", "Red");
                    Thread.Sleep(2000);
                    if (enemy.Hp <= 0)
                    {
                        DrawDisplay(enemy.UnitType);
                        Program.animation.DrawTextSlowly(46, 23, $"상대는 체력을 모두 소진했습니다!", "Blue");
                        Thread.Sleep(2000);
                        DrawDisplay(enemy.UnitType);
                        Program.animation.DrawTextSlowly(43, 23, $"상대는 {Program.player.Name}의 한 끼 식사가 되었습니다!.", "Blue");
                        Thread.Sleep(2000);
                        // 리워드 페이지로
                        break;
                    }

                    enemy.Attack(index, Program.player);
                    DrawDisplay(enemy.UnitType);
                    Program.animation.DrawTextSlowly(46, 23, $"{enemy.Name}이(가) {enemy.SkillList[index - 1].Name}을(를) 사용했다!", "White");
                    Thread.Sleep(2000);
                    DrawDisplay(enemy.UnitType);
                    Program.animation.DrawTextSlowly(46, 23, $"{enemy.Name} {enemy.SkillList[index - 1].UseComment}", "Red");
                    Thread.Sleep(2000);
                    if (Program.player.Hp <= 0)
                    {
                        DrawDisplay(enemy.UnitType);
                        Program.animation.DrawTextSlowly(46, 23, $"당신은 체력을 모두 소진했습니다!", "Red");
                        Thread.Sleep(2000);
                        DrawDisplay(enemy.UnitType);
                        Program.animation.DrawTextSlowly(46, 23, $"당신은 급하게 은신처로 갔습니다.", "Red");
                        Thread.Sleep(2000);
                        // 은신처로 돌아가기
                        break;
                    }

                    isSelect1 = true;
                    Console.CursorVisible = false;
                }
                else
                {
                    index = rand.Next(1, 3);

                    enemy.Attack(index, Program.player);
                    DrawDisplay(enemy.UnitType);
                    Program.animation.DrawTextSlowly(46, 23, $"{enemy.Name}이(가) {enemy.SkillList[index - 1].Name}을(를) 사용했다!", "White");
                    Thread.Sleep(2000);
                    DrawDisplay(enemy.UnitType);
                    Program.animation.DrawTextSlowly(46, 23, $"{enemy.Name} {enemy.SkillList[index - 1].UseComment}", "Red");
                    Thread.Sleep(2000);
                    if (Program.player.Hp <= 0)
                    {
                        DrawDisplay(enemy.UnitType);
                        Program.animation.DrawTextSlowly(46, 23, $"당신은 체력을 모두 소진했습니다!", "Red");
                        Thread.Sleep(2000);
                        DrawDisplay(enemy.UnitType);
                        Program.animation.DrawTextSlowly(46, 23, $"당신은 급하게 은신처로 갔습니다.", "Red");
                        Thread.Sleep(2000);
                        // 은신처로 돌아가기
                        break;
                    }

                    Program.player.Attack(2, enemy);
                    DrawDisplay(enemy.UnitType);
                    Program.animation.DrawTextSlowly(46, 23, $"{Program.player.Name}이(가) {Program.player.SkillList[1].Name}을(를) 사용했다!", "White");
                    Thread.Sleep(2000);
                    DrawDisplay(enemy.UnitType);
                    Program.animation.DrawTextSlowly(46, 23, $"{Program.player.Name} {Program.player.SkillList[1].UseComment}", "Red");
                    Thread.Sleep(2000);
                    if (enemy.Hp <= 0)
                    {
                        DrawDisplay(enemy.UnitType);
                        Program.animation.DrawTextSlowly(46, 23, $"상대는 체력을 모두 소진했습니다!", "Blue");
                        Thread.Sleep(2000);
                        DrawDisplay(enemy.UnitType);
                        Program.animation.DrawTextSlowly(43, 23, $"상대는 {Program.player.Name}의 한 끼 식사가 되었습니다!.", "Blue");
                        Thread.Sleep(2000);
                        // 리워드 페이지로
                        break;
                    }

                    isSelect1 = true;
                    Console.CursorVisible = false;
                }
            }
            else if (input == "3")
            {
                if (isFaster == true)
                {
                    index = rand.Next(1, 3);

                    Program.player.Attack(3, enemy);
                    DrawDisplay(enemy.UnitType);
                    Program.animation.DrawTextSlowly(46, 23, $"{Program.player.Name}이(가) {Program.player.SkillList[2].Name}을(를) 사용했다!", "White");
                    Thread.Sleep(2000);
                    DrawDisplay(enemy.UnitType);
                    Program.animation.DrawTextSlowly(46, 23, $"{Program.player.Name} {Program.player.SkillList[2].UseComment}", "Red");
                    Thread.Sleep(2000);
                    if (enemy.Hp <= 0)
                    {
                        DrawDisplay(enemy.UnitType);
                        Program.animation.DrawTextSlowly(46, 23, $"상대는 체력을 모두 소진했습니다!", "Blue");
                        Thread.Sleep(2000);
                        DrawDisplay(enemy.UnitType);
                        Program.animation.DrawTextSlowly(43, 23, $"상대는 {Program.player.Name}의 한 끼 식사가 되었습니다!.", "Blue");
                        Thread.Sleep(2000);
                        // 리워드 페이지로
                        break;
                    }

                    enemy.Attack(index, Program.player);
                    DrawDisplay(enemy.UnitType);
                    Program.animation.DrawTextSlowly(46, 23, $"{enemy.Name}이(가) {enemy.SkillList[index - 1].Name}을(를) 사용했다!", "White");
                    Thread.Sleep(2000);
                    DrawDisplay(enemy.UnitType);
                    Program.animation.DrawTextSlowly(46, 23, $"{enemy.Name} {enemy.SkillList[index - 1].UseComment}", "Red");
                    Thread.Sleep(2000);
                    if (Program.player.Hp <= 0)
                    {
                        DrawDisplay(enemy.UnitType);
                        Program.animation.DrawTextSlowly(46, 23, $"당신은 체력을 모두 소진했습니다!", "Red");
                        Thread.Sleep(2000);
                        DrawDisplay(enemy.UnitType);
                        Program.animation.DrawTextSlowly(46, 23, $"당신은 급하게 은신처로 갔습니다.", "Red");
                        Thread.Sleep(2000);
                        // 은신처로 돌아가기
                        break;
                    }

                    isSelect1 = true;
                    Console.CursorVisible = false;
                }
                else
                {
                    index = rand.Next(1, 3);

                    enemy.Attack(index, Program.player);
                    DrawDisplay(enemy.UnitType);
                    Program.animation.DrawTextSlowly(46, 23, $"{enemy.Name}이(가) {enemy.SkillList[index - 1].Name}을(를) 사용했다!", "White");
                    Thread.Sleep(2000);
                    DrawDisplay(enemy.UnitType);
                    Program.animation.DrawTextSlowly(46, 23, $"{enemy.Name} {enemy.SkillList[index - 1].UseComment}", "Red");
                    Thread.Sleep(2000);
                    if (Program.player.Hp <= 0)
                    {
                        DrawDisplay(enemy.UnitType);
                        Program.animation.DrawTextSlowly(46, 23, $"당신은 체력을 모두 소진했습니다!", "Red");
                        Thread.Sleep(2000);
                        DrawDisplay(enemy.UnitType);
                        Program.animation.DrawTextSlowly(46, 23, $"당신은 급하게 은신처로 갔습니다.", "Red");
                        Thread.Sleep(2000);
                        // 은신처로 돌아가기
                        break;
                    }

                    Program.player.Attack(3, enemy);
                    DrawDisplay(enemy.UnitType);
                    Program.animation.DrawTextSlowly(46, 23, $"{Program.player.Name}이(가) {Program.player.SkillList[2].Name}을(를) 사용했다!", "White");
                    Thread.Sleep(2000);
                    DrawDisplay(enemy.UnitType);
                    Program.animation.DrawTextSlowly(46, 23, $"{Program.player.Name} {Program.player.SkillList[2].UseComment}", "Red");
                    Thread.Sleep(2000);
                    if (enemy.Hp <= 0)
                    {
                        DrawDisplay(enemy.UnitType);
                        Program.animation.DrawTextSlowly(46, 23, $"상대는 체력을 모두 소진했습니다!", "Blue");
                        Thread.Sleep(2000);
                        DrawDisplay(enemy.UnitType);
                        Program.animation.DrawTextSlowly(43, 23, $"상대는 {Program.player.Name}의 한 끼 식사가 되었습니다!.", "Blue");
                        Thread.Sleep(2000);
                        // 리워드 페이지로
                        break;
                    }

                    isSelect1 = true;
                    Console.CursorVisible = false;
                }
            }
            else if (input == "4")
            {
                if (isFaster == true)
                {
                    index = rand.Next(1, 3);

                    Program.player.Attack(4, enemy);
                    DrawDisplay(enemy.UnitType);
                    Program.animation.DrawTextSlowly(46, 23, $"{Program.player.Name}이(가) {Program.player.SkillList[3].Name}을(를) 사용했다!", "White");
                    Thread.Sleep(2000);
                    DrawDisplay(enemy.UnitType);
                    Program.animation.DrawTextSlowly(46, 23, $"{Program.player.Name} {Program.player.SkillList[3].UseComment}", "Red");
                    Thread.Sleep(2000);
                    if (enemy.Hp <= 0)
                    {
                        DrawDisplay(enemy.UnitType);
                        Program.animation.DrawTextSlowly(46, 23, $"상대는 체력을 모두 소진했습니다!", "Blue");
                        Thread.Sleep(2000);
                        DrawDisplay(enemy.UnitType);
                        Program.animation.DrawTextSlowly(43, 23, $"상대는 {Program.player.Name}의 한 끼 식사가 되었습니다!.", "Blue");
                        Thread.Sleep(2000);
                        // 리워드 페이지로
                        break;
                    }

                    enemy.Attack(index, Program.player);
                    DrawDisplay(enemy.UnitType);
                    Program.animation.DrawTextSlowly(46, 23, $"{enemy.Name}이(가) {enemy.SkillList[index - 1].Name}을(를) 사용했다!", "White");
                    Thread.Sleep(2000);
                    DrawDisplay(enemy.UnitType);
                    Program.animation.DrawTextSlowly(46, 23, $"{enemy.Name} {enemy.SkillList[index - 1].UseComment}", "Red");
                    Thread.Sleep(2000);
                    if (Program.player.Hp <= 0)
                    {
                        DrawDisplay(enemy.UnitType);
                        Program.animation.DrawTextSlowly(46, 23, $"당신은 체력을 모두 소진했습니다!", "Red");
                        Thread.Sleep(2000);
                        DrawDisplay(enemy.UnitType);
                        Program.animation.DrawTextSlowly(46, 23, $"당신은 급하게 은신처로 갔습니다.", "Red");
                        Thread.Sleep(2000);
                        // 은신처로 돌아가기
                        break;
                    }

                    isSelect1 = true;
                    Console.CursorVisible = false;
                }
                else
                {
                    index = rand.Next(1, 3);

                    enemy.Attack(index, Program.player);
                    DrawDisplay(enemy.UnitType);
                    Program.animation.DrawTextSlowly(46, 23, $"{enemy.Name}이(가) {enemy.SkillList[index - 1].Name}을(를) 사용했다!", "White");
                    Thread.Sleep(2000);
                    DrawDisplay(enemy.UnitType);
                    Program.animation.DrawTextSlowly(46, 23, $"{enemy.Name} {enemy.SkillList[index - 1].UseComment}", "Red");
                    Thread.Sleep(2000);
                    if (Program.player.Hp <= 0)
                    {
                        DrawDisplay(enemy.UnitType);
                        Program.animation.DrawTextSlowly(46, 23, $"당신은 체력을 모두 소진했습니다!", "Red");
                        Thread.Sleep(2000);
                        DrawDisplay(enemy.UnitType);
                        Program.animation.DrawTextSlowly(46, 23, $"당신은 급하게 은신처로 갔습니다.", "Red");
                        Thread.Sleep(2000);
                        // 은신처로 돌아가기
                        break;
                    }

                    Program.player.Attack(4, enemy);
                    DrawDisplay(enemy.UnitType);
                    Program.animation.DrawTextSlowly(46, 23, $"{Program.player.Name}이(가) {Program.player.SkillList[3].Name}을(를) 사용했다!", "White");
                    Thread.Sleep(2000);
                    DrawDisplay(enemy.UnitType);
                    Program.animation.DrawTextSlowly(46, 23, $"{Program.player.Name} {Program.player.SkillList[3].UseComment}", "Red");
                    Thread.Sleep(2000);
                    if (enemy.Hp <= 0)
                    {
                        DrawDisplay(enemy.UnitType);
                        Program.animation.DrawTextSlowly(46, 23, $"상대는 체력을 모두 소진했습니다!", "Blue");
                        Thread.Sleep(2000);
                        DrawDisplay(enemy.UnitType);
                        Program.animation.DrawTextSlowly(43, 23, $"상대는 {Program.player.Name}의 한 끼 식사가 되었습니다!.", "Blue");
                        Thread.Sleep(2000);
                        // 리워드 페이지로
                        break;
                    }

                    isSelect1 = true;
                    Console.CursorVisible = false;
                }
            }
            else
            {
                DrawDisplay(enemy.UnitType);
                Program.animation.DrawTextSlowly(50, 23, $"그런 선택지는 없다!", "White");
                Thread.Sleep(2000);
                DrawDisplay(enemy.UnitType);

                Program.ui.DrawText(2, 21, "[N] 스킬 이름", "White");
                Program.ui.DrawText(22, 21, "|", "White");
                Program.ui.DrawText(24, 21, "스킬 설명", "White");
                Program.ui.DrawText(71, 21, "|", "White");
                Program.ui.DrawText(73, 21, "남은 PP / 맥스 PP", "White");

                Program.ui.DrawText(2, 23, $"[1] {Program.player.SkillList[0].Name}", "White");
                Program.ui.DrawText(22, 23, "|", "White");
                Program.ui.DrawText(24, 23, $"{Program.player.SkillList[0].Comment}", "White");
                Program.ui.DrawText(71, 23, "|", "White");
                Program.ui.DrawText(73, 23, $"{Program.player.SkillList[0].PP} / {Program.player.SkillList[0].MaxPP}", "White");

                Program.ui.DrawText(2, 24, $"[2] {Program.player.SkillList[1].Name}", "White");
                Program.ui.DrawText(22, 24, "|", "White");
                Program.ui.DrawText(24, 24, $"{Program.player.SkillList[1].Comment}", "White");
                Program.ui.DrawText(71, 24, "|", "White");
                Program.ui.DrawText(73, 24, $"{Program.player.SkillList[1].PP} / {Program.player.SkillList[1].MaxPP}", "White");

                Program.ui.DrawText(2, 25, $"[3] {Program.player.SkillList[2].Name}", "White");
                Program.ui.DrawText(22, 25, "|", "White");
                Program.ui.DrawText(24, 25, $"{Program.player.SkillList[2].Comment}", "White");
                Program.ui.DrawText(71, 25, "|", "White");
                Program.ui.DrawText(73, 25, $"{Program.player.SkillList[2].PP} / {Program.player.SkillList[2].MaxPP}", "White");

                Program.ui.DrawText(2, 26, $"[4] {Program.player.SkillList[3].Name}", "White");
                Program.ui.DrawText(22, 26, "|", "White");
                Program.ui.DrawText(24, 26, $"{Program.player.SkillList[3].Comment}", "White");
                Program.ui.DrawText(71, 26, "|", "White");
                Program.ui.DrawText(73, 26, $"{Program.player.SkillList[3].PP} / {Program.player.SkillList[3].MaxPP}", "White");

                Program.ui.DrawBox(91, 21, 27, 5, "gray");
            }
        }

        if (Program.player.Hp > 0 && enemy.Hp > 0)
            ChoicePhase();
        else if (Program.player.Hp <= 0)
        {
            Console.Clear();
            Program.animation.SmallerBox(32, 5);
            Thread.Sleep(1000);
        }
        else if (enemy.Hp <= 0)
        {
            Console.Clear();
            Program.animation.SmallerBox(32, 5);
            Thread.Sleep(1000);
            Reward(enemy.Gold, enemy.Exp);
        }
    }

    public void Reward(int totalGold, int totalExp)
    {
        SkillManager.SM.FinishBattle();
        Console.Clear();
        Program.animation.BiggerBox(32, 5);
        Program.animation.OpenBox(55, 12);
        Program.animation.DrawTextSlowly(39, 11, $"당신은 {totalGold}의 골드와 {totalExp}의 경험치를 흭득했습니다!", "Blue");
        Thread.Sleep(5000);
        Program.animation.SmallerBox(32, 5);
        Thread.Sleep(1000);
    }

    public void DrawDisplay(UnitType Unit)
    {
        Console.Clear();
        Program.ui.DrawTexture(UnitType.Player, 5, 8, "Blue");
        Program.ui.DrawHpBar(5, 6, Program.player);
        Program.ui.DrawTexture(Unit, 80, 2, "White");
        Program.ui.DrawHpBar(80, 13, enemy);
        Program.ui.DrawBox(0, 19, 120, 10, "White");
    }
}