using System;

enum SKillType // 스킬 이름
{
    BodySlam
}

enum ElementType // 공격 방식
{
    Nomal, // 일반적
    Pierce, // 방어력 일부 무시
    Cut // 방어력이 약한 상대
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

    public virtual void UseBuff(temp used) { }
    public virtual void Attack(temp used, temp target) { }

    public Skill(SKillType sKillType)
    {
        this.skillType = sKillType;
        SkillManager.SM.ChangeData(this);
    }
}


class AttackSkill : Skill
{
    public AttackSkill(SKillType sKillType) : base(sKillType) { }


    public override void Attack(temp used, temp target)
    {

    }
}

class Buff
{

}

class Dot
{

}

class temp
{

}