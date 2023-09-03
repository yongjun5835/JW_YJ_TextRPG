using JW_YJ_TextRPG;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Hideout
{
    Shop shop = new Shop();
    public Hideout()
    {

    }

    public void DrawDisplay()
    {
        if (Program.player.Exp >= 5)
            Program.player.Level = 2;
        if (Program.player.Exp >= 15)
            Program.player.Level = 3;
        if (Program.player.Exp >= 25)
            Program.player.Level = 4;
        if (Program.player.Exp >= 45)
            Program.player.Level = 5;

        if (Program.player.Grow == "치어")
            Program.player.MaxHp = 30 + 30 * Program.player.Level;
        else if (Program.player.Grow == "유어")
            Program.player.MaxHp = 60 + 30 * Program.player.Level;
        else if (Program.player.Grow == "성어")
            Program.player.MaxHp = 90 + 30 * Program.player.Level;

        Program.animation.FadeInOut(42, 10, 15, "은신처");
        Program.animation.UnfoldScroll(10, 0);
        while (true)
        {
            Program.ui.DelScrollLeftPart();
            Program.ui.DelScrollOptionList();
            Program.ui.DelScrollSelectBlock("");
            Program.player.Hp = Program.player.MaxHp;
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

            Program.ui.DrawText(67, 4, "━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━", "Gray");
            Program.ui.DrawText(76, 6, "[1] 스토리 진행", "White");
            Program.ui.DrawText(67, 8, "━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━", "Gray");
            Program.ui.DrawText(76, 10, "[2] 바다 거래소", "White");
            Program.ui.DrawText(67, 12, "━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━", "Gray");
            Program.ui.DrawText(77, 14, "[3] 스킬관리", "White");
            Program.ui.DrawText(67, 16, "━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━", "Gray");
            if (Program.storyManager.SP >= 4 && Program.story4.isProgress == true)
                Program.ui.DrawText(77, 18, "[4] 트레이닝", "White");
            else
                Program.ui.DrawText(77, 18, "[4] 트레이닝", "Gray");
            Program.ui.DrawText(67, 20, "━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━", "Gray");

            Program.ui.DrawBox(66, 21, 35, 5, "Gray");

            bool isSelect1 = false;
            string input = "";
            Console.CursorVisible = true;
            while (isSelect1 == false)
            {
                Console.SetCursorPosition(68, 23);
                input = Console.ReadLine();
                if (input == "1")
                {
                    Console.CursorVisible = false;
                    Program.animation.FoldScroll(10, 0);
                    Thread.Sleep(1000);
                    Program.storyManager.Progress();
                }
                else if (input == "2")
                {
                    isSelect1 = true;
                    Console.CursorVisible = false;
                    shop.EnterShop();
                }
                else if (input == "3")
                {
                    isSelect1 = true;
                    Console.CursorVisible = false;
                    SkillOffice(Program.player.SkillList);
                }
                else if (input == "4")
                {
                    if (Program.storyManager.SP >= 4 && Program.story4.isProgress == true)
                    {
                        if (Program.storyManager.SP == 4)
                        {
                            Program.storyManager.SP++;
                        }
                        isSelect1 = true;
                        Console.CursorVisible = false;
                        Program.battle.isTraining = true;
                        Program.animation.FoldScroll(10, 0);
                        Thread.Sleep(1000);
                        Program.battle.StartPhase(UnitType.Turtle);
                    }
                    else
                    {
                        Console.SetCursorPosition(68, 23);
                        Console.Write("                               ");
                    }
                }
                else
                {
                    Console.SetCursorPosition(68, 23);
                    Console.Write("                               ");
                }
            }
        }
    }

    void SkillOffice(List<Skill> inven)
    {
        while (true)
        {
            Program.ui.DelScrollLeftPart();
            Program.ui.DelScrollOptionList();
            Program.ui.DrawLeftScreen_SkillList(inven);
            Program.ui.DelScrollSelectBlock("");

            StringBuilder txt;
            Program.ui.DelScrollOptionList();
            Program.ui.DrawText(76, 6, "[1] 스킬 교체", "White");
            Program.ui.DrawText(73, 10, "[2] 기술 머신 사용", "White");
            Program.ui.DrawText(77, 14, "[0] 돌아가기", "White");
            Program.ui.DrawText(77, 18, "", "White");
            if (int.TryParse(Console.ReadLine(), out int input) == false || input > 2)
            {
                Program.ui.DrawText(68, 23, $"다시 선택해주세요.", "Red");
                Thread.Sleep(1000);
                Program.ui.DrawText(68, 23, "                            ", "");
                Console.SetCursorPosition(68, 23);
                continue;
            }
            else if (input == 1)
            {
                SkillChangeMsg(inven);
            }
            else if (input == 2)
            {
                UseSkillMachine(Program.player);
            }
            else if (input == 0)
            {

                return;
            }
        }
    }

    void SkillChangeMsg(List<Skill> inven)
    {
        int first;
        int second;

        while (true)
        {
            Program.ui.DelScrollOptionList();
            Program.ui.DrawText(70, 6, "교체할 스킬을 선택해주세요.", "White");
            Program.ui.DrawText(73, 10, "[0] 돌아가기", "White");
            Program.ui.DelScrollSelectBlock("첫번째 스킬 : ");



            if (int.TryParse(Console.ReadLine(), out int input) == false || input > inven.Count)
            {
                Program.ui.DrawText(68, 23, $"다시 선택해주세요.", "Red");
                Thread.Sleep(1000);
                Program.ui.DrawText(68, 23, "                            ", "");
                Console.SetCursorPosition(68, 23);
                continue;
            }
            else if (input == 0)
            {

                return;
            }

            first = input -1;
            break;
        }

        while (true)
        {
            Program.ui.DelScrollOptionList();
            Program.ui.DrawText(70, 6, "교체할 스킬을 선택해주세요.", "White");
            Program.ui.DrawText(73, 10, "[0] 돌아가기", "White");
            Program.ui.DelScrollSelectBlock("두번째 스킬 : ");

            if (int.TryParse(Console.ReadLine(), out int input) == false || input > inven.Count)
            {
                Program.ui.DrawText(68, 23, $"다시 선택해주세요.", "Red");
                Thread.Sleep(1000);
                Program.ui.DrawText(68, 23, "                            ", "");
                Console.SetCursorPosition(68, 23);
                continue;
            }
            else if (input == 0)
            {

                return;
            }
            second = input -1;
            break;
        }

        SkillManager.SM.ChangeSkillList(inven, first, second);
    }

    void UseSkillMachine(Unit taget)
    {
        StringBuilder txt;


        while (true)
        {
            Program.ui.DelScrollOptionList();
            Program.ui.DrawBox(21, 4, 45, 22, "Gray");

            Program.ui.DrawLeftScreen_ItemList(taget.ItemList, false);
            Program.ui.DrawText(70, 6, "사용할 머신을 선택해주세요", "White");
            Program.ui.DrawText(77, 10, "[0] 돌아가기", "White");
            Program.ui.DrawText(77, 14, "            ", "White");
            Program.ui.DrawText(77, 18, "            ", "White");
            Program.ui.DelScrollSelectBlock("물품 번호 : ");

            if (int.TryParse(Console.ReadLine(), out int input) == false && input == -1 || input > taget.ItemList.Count)
            {
                Program.ui.DrawText(68, 23, $"다시 선택해주세요.", "Red");
                Thread.Sleep(1000);
                Program.ui.DrawText(68, 23, "                            ", "");
                Console.SetCursorPosition(68, 23);
                continue;
            }
            else if (input == 0)
                return;

            if (taget.UseItem(input, taget) == true)
            {
                Console.ForegroundColor= ConsoleColor.Blue;
                Program.ui.DelScrollSelectBlock("적용되었습니다.");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Program.ui.DelScrollSelectBlock("실패하였습니다.");
                Console.ResetColor();
            }
            Thread.Sleep (1000);
            continue;
        }
    }
}
