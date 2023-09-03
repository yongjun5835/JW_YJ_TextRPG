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
            taget.Gold = 20;
        }
        else if ((int)sKillType < 20)
        {
            taget.Gold = 40;
        }

    }
}

class Item
{
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

    public bool Use(Unit unit)
    {
        return SkillManager.SM.AddSkill(unit, sKillType);
    }
}