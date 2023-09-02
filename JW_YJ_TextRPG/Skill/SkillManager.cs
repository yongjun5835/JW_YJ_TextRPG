using System.Runtime.InteropServices;

partial class SkillManager
{
    public static SkillManager SM;

    public delegate void Event();
    public event Event RoundTurn;


    public SkillManager()
    {
        SM = this;
    }

    public void TurnEvent()
    {
        if (RoundTurn == null)
            return;

        RoundTurn();
    }

    public void AddSkill(Unit unit, SKillType type) // 스킬 실수 없이 추가 하기
    {
        List<Skill> addlist = unit.SkillList;

        switch ((int)type)
        {
            case < 100: // 공격 스킬
                addlist.Add(new AttackSkill(type));
                break;
            case >= 100: // 버프 스킬
                addlist.Add(new BuffSkill(type));
                break;
        }

    }

    public void ChangeSkillData(Skill skill)
    {
        switch (skill.SkillType)
        {
            case SKillType.BodySlam:
                BodySlam(skill);
                break;
            case SKillType.TailWhip:
                TailWhip(skill);
                break;
            case SKillType.WaterCanon:
                WaterCanon(skill);
                break;
            case SKillType.BubbleBeam:
                BubbleBeam(skill);
                break;
            case SKillType.IceBeam:
                IceBeam(skill);
                break;
            case SKillType.Splash:
                Splash(skill);
                break;
            case SKillType.BiteDeep:
                BiteDeep(skill);
                break;
            case SKillType.None:
                None(skill);
                break;
            default:
                break;
        }
    } // skill 데이터 입력

    public void CalcAttackType(Skill skill, Unit taget, ref int damage)
    {
        switch (skill.AttackType)
        {
            case AttackType.Nomal:
                damage -= taget.Def;
                break;
            case AttackType.Pierce:
                damage -= (int)(taget.Def * 0.5f);
                break;
            case AttackType.Cut:
                damage -= (int)(taget.Def * 1.5f);
                break;
            default:
                damage -= taget.Def;
                break;

        }
    }


}
