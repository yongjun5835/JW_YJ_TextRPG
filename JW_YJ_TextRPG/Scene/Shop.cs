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
        Program.ui.DrawBox(21, 4, 45, 22, "Gray");

        while (true)
        {
            for (int i = 5; i < 25; i++) // 상점 왼쪽편 그림
            {
                Program.ui.DrawText(22, i, "                                           ", "Gray");
            }

            Program.ui.DelScrollOptionList();
            Program.ui.DelScrollSelectBlock("");

            Program.ui.DrawBox(21, 4, 45, 22, "Gray");
            Program.ui.DrawText(67, 4, "━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━", "Gray");
            Program.ui.DrawText(76, 6, " [1] 구매하기", "White");
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
                    ListBuyItems();
                    break;
                case "2":
                    ListSellItems();
                    break;
                case "0":
                    return;
                default:
                    Program.ui.DrawText(68, 23, $"다시 선택해주세요.", "Red");
                    Thread.Sleep(1000);
                    Console.SetCursorPosition(68, 23);

                    break;
            }
        }
    }

    void ListBuyItems()
    {
        StringBuilder txt;
        Program.ui.DelScrollOptionList();
        Program.ui.DrawText(76, 6, "물건을 구매합니다", "White");
        Program.ui.DrawText(77, 10, "[0] 돌아가기", "White");

        while (true)
        {
            Program.ui.DrawLeftScreen_ItemList(shopItemList, false);
            Program.ui.DelScrollSelectBlock("물품 번호 : ");
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
        Program.ui.DelScrollOptionList();
        Program.ui.DrawText(76, 6, "물건을 판매합니다", "White");
        Program.ui.DrawText(77, 10, "[0] 돌아가기", "White");
        Program.ui.DrawText(77, 14, "            ", "White");
        Program.ui.DrawText(77, 18, "            ", "White");

        while (true)
        {
            Program.ui.DrawLeftScreen_ItemList(Program.player.ItemList, true);
            Program.ui.DelScrollSelectBlock("물품 번호 : ");
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
        if (moreAdditem == false && Program.storyManager.SP >= 3)
        {
            moreAdditem = true;
            shopItemList.Add(new Item(SKillType.BiteDeep));
            shopItemList.Add(new Item(SKillType.IcePunch));
            shopItemList.Add(new Item(SKillType.Surf));
        }
    }
}
