

class Skill
{
    protected SKillType skillType;
    protected AttackType attackType;
    protected string name = ""; // 이름
    protected string comment = ""; // 설명
    protected string useComment = ""; // 사용시 코멘트
    protected int powerPoint; // 스킬 사용 가능 횟수
    protected int maxPowerPoint; // 스킬 사용 가능 횟수
    protected float power; // 스킬의 파워배율
    protected float accuracy; // 명중률

    public SKillType SkillType { get { return skillType; } }
    public AttackType AttackType { get { return attackType; } set { attackType = value; } }
    public string Name { get { return name; } set { name = value; } }
    public string Comment { get { return comment; } set { comment = value; } }
    public int MaxPP { get { return maxPowerPoint; } set { maxPowerPoint = value; } }
    public int PP
    {
        get { return powerPoint; }
        set
        {
            powerPoint = value;
            if (powerPoint > maxPowerPoint)
            {
                powerPoint = maxPowerPoint;
            }
        }
    }
    public string UseComment { get { return useComment; } set { useComment = value; } }
    public float Power { get { return power; } set { power = value; } }
    public float Accuracy { get { return accuracy; } set { accuracy = value; } }

    public virtual void Use(Unit user, Unit target) { } // 스킬 사용

    public Skill(SKillType sKillType)  // 생성시 데이터에 맞게 불러옴
    {
        this.skillType = sKillType;
        SkillManager.SM.SetSkillData(this);
    }

    protected bool IsDodged(Unit user, Unit target) // 회피 여부
    {
        int sucessNum = 100 - (int)(Accuracy * (user.Accuracy - target.Dodge));
        if (new Random().Next(1, 101) < sucessNum)
        {
            return false;
        }
        else { return true; }
    }

}


class AttackSkill : Skill
{
    int damage;

    public AttackSkill(SKillType sKillType) : base(sKillType) { }

    public override void Use(Unit user, Unit target)
    {
        if (IsDodged(user, target) == true)
            return;
        damage = (int)(user.Atk * power);
        SkillManager.SM.CalcAttackType(this, target, ref damage);
        if (damage < 0)
        {
            damage = 0;
        }
        target.Hp -= damage;
    }

}

class BuffSkill : Skill
{
    float percent = 0.0f;
    int effectTurn = 0;

    public float Percent { get { return percent; } set { percent = value; } }
    public int EffectTurn { get { return effectTurn; } set { effectTurn = value; } }

    public BuffSkill(SKillType sKillType) : base(sKillType) { }

    public override void Use(Unit user, Unit target)
    {
        if (user != target && IsDodged(user, target) == true)
            return;
        new Buff(target, EffectTurn, AttackType, Percent);
    }

}
