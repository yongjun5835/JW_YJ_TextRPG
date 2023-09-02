enum UnitType
{
    Player = 0,
    Scomber = 10,
    Shark,
    Turtle,
    Angler
}

internal class Unit
{
    UnitType unitType;

    protected string name = "TEST";
    protected int hp =100;
    protected int maxHp = 100;
    protected int atk= 10;
    protected int def = 1;
    protected int speed = 1; // 스피드

    protected int accuracy = 1; // 명중
    protected int dodge = 1; // 회피

    List<Skill> skillList = new List<Skill>(4); // 스킬
    List<Buff> debuffList = new List<Buff>(); // 디버프

    public UnitType UnitType { get { return unitType; } set { unitType = value; } }
    public string Name { get { return name; } set { name = value; } }
    public int Hp { get { return hp; } set { hp = value; } }
    public int MaxHp { get { return maxHp; } set { maxHp = value; } }
    public int Atk { get { return atk; } set { atk = value; } }
    public int Def { get { return def; } set { def = value; } }
    public int Spd { get { return speed; } set { speed = value; } }

    public int Accuracy { get { return accuracy; } set { accuracy = value; } }
    public int Dodge { get { return dodge; } set { dodge = value; } }

    public List<Skill> SkillList { get { return skillList; } set { skillList = value; } }
    public List<Buff> BuffList { get { return debuffList; } set { debuffList = value; } }


    public Unit(UnitType unitType) // 생성시 데이터에 맞게 불러옴
    {
        this.unitType = unitType;
        UnitManager.UM.ChangeMonsterData(this);
    }


    public bool Attack(int skillListNum, Unit taget) //  이걸로 공격! 불값은 pp가 0이면 false 리턴
    {
        if (skillList[skillListNum - 1].PP <= 0)
            return false;

        this.skillList[skillListNum - 1].PP--;
        this.skillList[skillListNum - 1].Use(this, taget);
        return true;
    }
}
