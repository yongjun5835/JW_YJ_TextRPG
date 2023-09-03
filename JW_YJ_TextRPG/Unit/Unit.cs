enum UnitType
{
    Player = 0,
    Scomber = 10,
    Shark,
    Turtle,
    Angler,
}

internal class Unit
{
    UnitType unitType;

    protected string name = "TEST";
    protected int hp =100;
    protected int maxHp = 100;
    protected int atk= 10;
    protected int def = 1;
    protected int speed = 1; // 스피드 치어3, 유어2, 성어1
    protected string habitat = "태평양"; // 1태평양, 2대서양, 3인도양
    protected int gold = 0;
    protected int exp = 0;
    protected int level = 1;
    protected string grow = "치어";

    protected int accuracy = 1; // 명중
    protected int dodge = 1; // 회피

    List<Item> itemList = new List<Item>(); // 아이템
    List<Skill> skillList = new List<Skill>(4); // 스킬
    List<Buff> debuffList = new List<Buff>(); // 디버프

    public UnitType UnitType { get { return unitType; } set { unitType = value; } }
    public string Name { get { return name; } set { name = value; } }
    public int Hp { get { return hp; } set { hp = value; } }
    public int MaxHp { get { return maxHp; } set { maxHp = value; } }
    public int Atk { get { return atk; } set { atk = value; } }
    public int Def { get { return def; } set { def = value; } }
    public int Spd { get { return speed; } set { speed = value; } }
    public string Habitat { get { return habitat; } set { habitat = value; } }
    public string Grow { get { return grow; } set { grow = value; } }
    public int Gold { get { return gold; } set { gold = value; } }
    public int Exp { get { return exp; } set { exp = value; } }
    public int Level { get { return level; } set { level = value; } }

    public int Accuracy { get { return accuracy; } set { accuracy = value; } }
    public int Dodge { get { return dodge; } set { dodge = value; } }

    public List<Item> ItemList { get { return itemList; } set { itemList = value; } }
    public List<Skill> SkillList { get { return skillList; } set { skillList = value; } }
    public List<Buff> BuffList { get { return debuffList; } set { debuffList = value; } }

    // 생성할때 만들 유닛 타입
    public Unit(UnitType unitType) 
    {
        this.unitType = unitType;
        UnitManager.UM.ChangeMonsterData(this);
    }

    // 이걸로 공격! 불값은 pp가 0이면 false 리턴
    public bool Attack(int skillListNum, Unit taget) 
    {
        if (skillList[skillListNum - 1].PP <= 0)
            return false;

        this.skillList[skillListNum - 1].PP--;
        this.skillList[skillListNum - 1].Use(this, taget);
        return true;
    }

    // 아이템 사용
    public bool UseItem(int Num, Unit taget)
    {
        bool result = itemList[Num - 1].Use(taget);
        if (result == true)
        {
            ItemList.Remove(itemList[Num - 1]);
            return true;
        }

        return false;
    }
}
