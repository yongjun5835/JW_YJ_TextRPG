
class SkillManager
{
    public static SkillManager SM;
    public SkillManager()
    {
        SM = this;
    }

    public void ChangeData(Skill skill)
    {
        switch (skill.SkillType)
        {
            case SKillType.BodySlam :
                BodySlam(skill);
                break;
        }
    }

    void BodySlam(Skill skill)
    {
        skill.ElementType = ElementType.Nomal;
        skill.Name = "몸통 박치기";
        skill.Comment = "상대를 향하여 전속력 박치기를 한다.";
        skill.Power = 1.0f;
        skill.Accuracy = 0.9f;

    }

}
