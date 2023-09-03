using JW_YJ_TextRPG;

class Shop
{
    List<Item> Shoplist = new List<Item>();
    Animation Ani = Program.animation;

    public Shop()
    {
        Shoplist.Add(new Item(SKillType.WaterCanon));
        Shoplist.Add(new Item(SKillType.WaterPulse));
        Shoplist.Add(new Item(SKillType.IceBeam));
        Shoplist.Add(new Item(SKillType.IcePunch));
    }

    public void EnterShop()
    {
        Ani.UnfoldScroll(10, 0);
        Ani.DrawTextNomal(70, 8, "┌───────────────────┐", "");
        Ani.DrawTextNomal(70, 9, "│      1. 구매       │", "");
        Ani.DrawTextNomal(70, 12, "│     2. 판매       │", "");
        Ani.DrawTextNomal(70, 15, "│     3. 대화       │", "");
        Ani.DrawTextNomal(70, 18, "│   0. 돌아가기     │", "");
        Ani.DrawTextNomal(70, 19, "└───────────────────┘", "");

    }

    void BuyItem()
    {

    }

    void SellItem()
    {

    }

    void Talk()
    {

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
        taget.Name = "기술머신 "+(int)sKillType;
        taget.Comment = $"{data.Name}을 배운다.";
        taget.MaxPP = data.MaxPP;
        taget.Power = data.Power;

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

    public SKillType SKillType { get { return sKillType; } set { sKillType = value; } }
    public string Name { get { return name; } set { name = value; } }
    public string Comment { get { return comment; } set { comment = value; } }
    public int MaxPP { get { return maxPowerPoint; } set { maxPowerPoint = value; } }
    public float Power { get { return power; } set { power = value; } }

    public Item(SKillType type)
    {
        ItemManager.IM.SetDate(this, type);
    }

    public void Use(Unit unit)
    {
        SkillManager.SM.AddSkill(unit, sKillType);
    }
}