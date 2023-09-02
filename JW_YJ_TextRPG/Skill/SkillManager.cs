
class SkillManager
{
    public static SkillManager SM;
    public SkillManager()
    {
        SM = this;
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
            default:
                break;
        }
    }

    void BodySlam(Skill skill)
    {
        skill.ElementType = ElementType.Nomal;
        skill.Name = "몸통 박치기";
        skill.Comment = "상대를 향하여 전속력 박치기를 한다.";
        skill.Power = 0.8f;
        skill.Accuracy = 0.9f;
    }

    void TailWhip(Skill skill)
    {
        skill.ElementType = ElementType.Def;
        skill.Name = "꼬리 흔들기";
        skill.Comment = "꼬리를 흔들어 상대를 도발한다.";
        skill.Power = 0.8f;
        skill.Accuracy = 1.0f;
    }

    void WaterCanon(Skill skill)
    {
        skill.ElementType = ElementType.Cut;
        skill.Name = "물 대포";
        skill.Comment = "물을 상대에게 발사한다.";
        skill.Power = 1.0f;
        skill.Accuracy = 0.9f;
    }

    void BubbleBeam(Skill skill)
    {
        skill.ElementType = ElementType.Nomal;
        skill.Name = "거품 광선";
        skill.Comment = "거품을 상대에게 발사한다.";
        skill.Power = 1.0f;
        skill.Accuracy = 0.9f;
    }

    void IceBeam(Skill skill)
    {
        skill.ElementType = ElementType.Pierce;
        skill.Name = "냉동 빔";
        skill.Comment = "냉동빔을 상대에게 발사한다.";
        skill.Power = 1.2f;
        skill.Accuracy = 1.0f;
    }

    void Splash(Skill skill)
    {
        skill.ElementType = ElementType.Hp;
        skill.Name = "튀어오르기";
        skill.Comment = "공격도 하지 않고 팔딱팔딱 튈 뿐";
        skill.Power = 0.0f;
        skill.Accuracy = 0.0f;
    }


}
