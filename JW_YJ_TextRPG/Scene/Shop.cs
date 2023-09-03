using JW_YJ_TextRPG;
using System.Text;

class Shop
{
    List<Item> shopItemList = new List<Item>();
    Animation Ani = Program.animation;

    bool moreAdditem = false;

    public Shop()
    {
        shopItemList.Add(new Item(SKillType.WaterCanon));
        shopItemList.Add(new Item(SKillType.WaterPulse));
        shopItemList.Add(new Item(SKillType.BubbleBeam));
    }

    public void EnterShop()
    {
        AddMoreItems();
        Program.animation.UnfoldScroll(10, 0);
        Program.ui.DrawBox(21, 4, 45, 22, "Gray");
        Program.ui.DrawText(22, 14, "-------------------------------------------", "Gray");
        Program.ui.DrawText(37, 16, $"", "White");
        Program.ui.DrawText(37, 17, $"", "White");
        Program.ui.DrawText(37, 18, $"", "White");
        Program.ui.DrawText(37, 19, $"", "Yellow");
        Program.ui.DrawText(37, 20, $"", "Red");
        Program.ui.DrawText(37, 21, $"", "Red");
        Program.ui.DrawText(37, 22, $"", "Red");
        Program.ui.DrawText(37, 23, $"", "Red");


        while (true)
        {
            for (int i = 5; i < 25; i++) // 상점 왼쪽편 그림
            {
                Program.ui.DrawText(22, i, "                                           ", "Gray");
            }

            Program.ui.DrawBox(21, 4, 45, 22, "Gray");
            Program.ui.DrawText(67, 4, "━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━", "Gray");
            Program.ui.DrawText(76, 6, " [1] 구매하기         ", "White");
            Program.ui.DrawText(67, 8, "━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━", "Gray");
            Program.ui.DrawText(76, 10, " [2] 판매하기", "White");
            Program.ui.DrawText(67, 12, "━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━", "Gray");
            Program.ui.DrawText(77, 14, "", "White");
            Program.ui.DrawText(67, 16, "━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━", "Gray");
            Program.ui.DrawText(77, 18, "[0] 돌아가기", "White");
            Program.ui.DrawText(67, 20, "━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━", "Gray");
            Program.ui.DrawBox(66, 21, 35, 5, "Gray");

            Console.CursorVisible = true;
            Program.ui.DrawText(68, 23, "                                ", "White");
            Console.SetCursorPosition(68, 23);
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    Program.ui.DrawText(68, 23, "                      ", "");
                    ListBuyItems();
                    break;
                case "2":
                    Program.ui.DrawText(68, 23, "                      ", "");
                    ListSellItems();
                    break;
                case "0":
                    return;
                default:
                    Program.ui.DrawText(68, 23, $"다시 선택해주세요.", "Red");
                    Thread.Sleep(1000);
                    Program.ui.DrawText(68, 23, "                      ", "");
                    Console.SetCursorPosition(68, 23);

                    break;
            }
        }
    }

    void ListBuyItems()
    {
        StringBuilder txt;
        Program.ui.DrawText(76, 6, "물건을 구매합니다", "White");
        Program.ui.DrawText(22, 14, "                                           ", "Gray");
        Program.ui.DrawText(77, 10, "[0] 돌아가기", "White");
        Program.ui.DrawText(77, 14, "            ", "White");
        Program.ui.DrawText(77, 18, "            ", "White");
        Program.ui.DrawText(23, 5, $"이름", "White");
        Program.ui.DrawText(23 + 13, 5, $"┃ 정보", "White");
        Program.ui.DrawText(23 + 13 + 23, 5, $"┃ 가격", "White");
        Program.ui.DrawText(22, 6, $"━━━━━━━━━━─━━━╋──────────────────────╋─────", "");



        while (true)
        {
            for (int i = 0; i < 9; i++)
            {
                if (i >= shopItemList.Count)
                {
                    Program.ui.DrawText(23, 7 + i * 2, $"                                         ", "White");
                    continue;
                }
                Program.ui.DrawText(23, 7 + i * 2, $"                                         ", "White");
                Program.ui.DrawText(23, 7 + i * 2, $"{i + 1}.{shopItemList[i].Name}", "White");
                Program.ui.DrawText(23 + 15, 7 + i * 2, $"{shopItemList[i].Comment}", "White");
                Program.ui.DrawText(23 + 15 + 23, 7 + i * 2, $"{shopItemList[i].Gold}", "White");
            }

            for (int i = 7; i < 25; i++)
            {
                Program.ui.DrawText(23 + 13 + 23, i, "┃", "white");
                Program.ui.DrawText(23 + 13, i, "┃", "white");
            }

            Program.ui.DrawText(68, 23, "                                ", "White");
            Program.ui.DrawText(68, 23, "물품 번호 : ", "White");
            Console.SetCursorPosition(80, 23);
            if (int.TryParse(Console.ReadLine(), out int input) == false)
            {
                input = -1;
            }
            if (input == 0)
                return;
            else if (input == -1 || input > shopItemList.Count)
            {
                Program.ui.DrawText(68, 23, $"다시 선택해주세요.", "Red");
                Thread.Sleep(1000);
                Program.ui.DrawText(68, 23, "                            ", "");
                Console.SetCursorPosition(68, 23);
                continue;
            }
            if (input <= shopItemList.Count && input > 0)
            {
                Program.player.Gold += 1000;
                txt = Buyitem(Program.player, shopItemList[input - 1]);
                Console.SetCursorPosition(68, 23);
                Console.Write(txt);
                Thread.Sleep(1000);
            }
        }
    }

    void ListSellItems()
    {
        StringBuilder txt;


        Program.ui.DrawText(76, 6, "물건을 판매합니다", "White");

        Program.ui.DrawText(22, 14, "                                           ", "Gray");
        Program.ui.DrawText(77, 10, "[0] 돌아가기", "White");
        Program.ui.DrawText(77, 14, "            ", "White");
        Program.ui.DrawText(77, 18, "            ", "White");
        Program.ui.DrawText(23, 5, $"이름", "White");
        Program.ui.DrawText(23 + 13, 5, $"┃ 정보", "White");
        Program.ui.DrawText(23 + 13 + 23, 5, $"┃ 가격", "White");
        Program.ui.DrawText(22, 6, $"━━━━━━━━━━─━━━╋──────────────────────╋─────", "");



        while (true)
        {
            for (int i = 0; i < 9; i++)
            {
                if (i >= Program.player.ItemList.Count)
                {
                    Program.ui.DrawText(23, 7 + i * 2, $"                                         ", "White");
                    continue;
                }
                Program.ui.DrawText(23, 7 + i * 2, $"                                         ", "White");
                Program.ui.DrawText(23, 7 + i * 2, $"{i + 1}.{Program.player.ItemList[i].Name}", "White");
                Program.ui.DrawText(23 + 15, 7 + i * 2, $"{Program.player.ItemList[i].Comment}", "White");
                Program.ui.DrawText(23 + 15 + 23, 7 + i * 2, $"{(int)(Program.player.ItemList[i].Gold * 0.8f)}", "White");
            }

            for (int i = 7; i < 25; i++)
            {
                Program.ui.DrawText(23 + 13 + 23, i, "┃", "white");
                Program.ui.DrawText(23 + 13, i, "┃", "white");
            }

            Program.ui.DrawText(68, 23, "                                ", "White");
            Program.ui.DrawText(68, 23, "물품 번호 : ", "White");
            Console.SetCursorPosition(80, 23);
            if (int.TryParse(Console.ReadLine(), out int input) == false)
            {
                input = -1;
            }
            if (input == 0)
                return;
            else if (input == -1 || input > Program.player.ItemList.Count)
            {
                Program.ui.DrawText(68, 23, $"다시 선택해주세요.", "Red");
                Thread.Sleep(1000);
                Program.ui.DrawText(68, 23, "                            ", "");
                Console.SetCursorPosition(68, 23);
                continue;
            }
            if (input <= Program.player.ItemList.Count && input > 0)
            {
                txt = Sellitem(Program.player, Program.player.ItemList[input - 1]);
                Console.SetCursorPosition(68, 23);
                Console.Write(txt);
                Thread.Sleep(1000);
            }
        }
    }


    StringBuilder Buyitem(Unit unit, Item buyItem)
    {
        StringBuilder txt = new StringBuilder();

        if (unit.Gold < buyItem.Gold)
        {
            txt.Append("구매에 실패하였습니다.");
            return txt;
        }

        unit.Gold -= buyItem.Gold;
        unit.ItemList.Add(buyItem);
        shopItemList.Remove(buyItem);

        txt.Append($"{buyItem.Name}을 구매하였습니다.");

        return txt;
    }

    StringBuilder Sellitem(Unit unit, Item sellItem)
    {
        StringBuilder txt = new StringBuilder();

        unit.Gold += (int)(sellItem.Gold * 0.8f);
        unit.ItemList.Remove(sellItem);
        shopItemList.Add(sellItem);

        txt.Append($"{sellItem.Name}을 판매하였습니다.");

        return txt;
    }

    void AddMoreItems()
    {
        if (moreAdditem = false && Program.storyManager.SP >=3)
        {
            moreAdditem = true;
            shopItemList.Add(new Item(SKillType.BiteDeep));
            shopItemList.Add(new Item(SKillType.IcePunch));
            shopItemList.Add(new Item(SKillType.Surf));

        }
    }
}


class ItemManager
{
    public static ItemManager IM;
    public ItemManager()
    {
        IM = this;
    }

    Skill data;
    public void SetDate(Item taget, SKillType sKillType)
    {
        if ((int)sKillType >= 100)
        {
            data = new BuffSkill(sKillType);
        }
        else
        {
            data = new AttackSkill(sKillType);
        }
        taget.SKillType = sKillType;
        taget.Name = "기술머신 " + (int)sKillType;
        taget.Comment = $"{data.Name}을 배운다.";
        taget.MaxPP = data.MaxPP;
        taget.Power = data.Power;
        if ((int)sKillType < 10)
        {
            taget.Gold = 200;
        }
        else if ((int)sKillType < 20)
        {
            taget.Gold = 400;
        }

    }
}

class Item
{
    //skill.AttackType = AttackType.Nomal;
    //    skill.Name = "파도 타기";
    //    skill.Comment = "큰 파도를 일으켜 상대를 공격한다.";
    //    skill.UseComment = "은(는) 파도를 일으켰다.";
    //    skill.MaxPP = 15;
    //    skill.PP = skill.MaxPP;
    //    skill.Power = 0.9f;
    //    skill.Accuracy = 1.0f;

    SKillType sKillType;
    string name = ""; // 이름
    string comment = ""; // 설명
    int maxPowerPoint; // 스킬 사용 가능 횟수
    protected float power; // 스킬의 파워배율
    int gold;

    public SKillType SKillType { get { return sKillType; } set { sKillType = value; } }
    public string Name { get { return name; } set { name = value; } }
    public string Comment { get { return comment; } set { comment = value; } }
    public int MaxPP { get { return maxPowerPoint; } set { maxPowerPoint = value; } }
    public float Power { get { return power; } set { power = value; } }
    public int Gold { get { return gold; } set { gold = value; } }


    public Item(SKillType type)
    {
        ItemManager.IM.SetDate(this, type);
    }

    public void Use(Unit unit)
    {
        SkillManager.SM.AddSkill(unit, sKillType);
    }
}