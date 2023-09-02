using System;

enum SKillType // 스킬 이름
{
    BodySlam,
    TailWhip,
    WaterCanon,
    BubbleBeam,
    IceBeam,
    Splash,

}

enum ElementType // 공격 방식
{
    Nomal = 0, // 일반적
    Pierce, // 방어력 일부 무시
    Cut, // 방어력이 약한 상대
    
    Hp = 10,
    Atk,
    Def
}

class Skill
{
    protected SKillType skillType; // enum skilltype
    protected ElementType elementType; // enum skilltype
    protected string name = ""; // 이름
    protected string comment = ""; // 설명
    protected float power; // 스킬의 파워배율
    protected float accuracy; // 명중률

    public SKillType SkillType { get { return skillType; } }
    public ElementType ElementType { get { return elementType; } set { elementType = value; } }
    public string Name { get { return name; } set { name = value; } }
    public string Comment { get { return comment; } set { comment = value; } }
    public float Power { get { return power; } set { power = value; } }
    public float Accuracy { get { return accuracy; } set { accuracy = value; } }

    public virtual void Use(Unit user, Unit target) { } // 스킬 사용

    public Skill(SKillType sKillType) // 스킬을 만들 땐 SkillType enum값!
    {
        this.skillType = sKillType;
        SkillManager.SM.ChangeSkillData(this);
    }

    protected bool IsDodged(Unit user, Unit target)
    {
        int sucessNum = 100-(int)(Accuracy*(user.Accuracy-target.Dodge));
        if (new Random().Next(1,101)<sucessNum)
        {
            return false;
        }
        else { return true; }
    }

}


class AttackSkill : Skill
{
    public AttackSkill(SKillType sKillType) : base(sKillType) { }


    public override void Use(Unit user, Unit target)
    {
        if (IsDodged(user, target) == true)
            return;

        target.Hp -= (int)(user.Atk * power);
    }

}

class BuffSkill : Skill
{

    ElementType tagetStatus;

    public ElementType TagetStatus { set { tagetStatus = value; } }

    public BuffSkill(SKillType sKillType) : base(sKillType) { }

    public override void Use(Unit user, Unit target)
    {
        if (user != target && IsDodged(user, target) == true)
            return;


    }
}

class DotSkill
{

}

class temp
{

}