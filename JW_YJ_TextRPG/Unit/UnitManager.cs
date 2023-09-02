﻿
internal class UnitManager
{
    public static UnitManager UM;
    public UnitManager()
    {
        UM = this;
    }

    public void ChangeMonsterData(Unit unit)
    {
        switch (unit.UnitType)
        {
            case UnitType.Player:
                break;
            case UnitType.Scomber:
                Scomber(unit);
                break;
            case UnitType.Shark:
                Shark(unit);
                break;
            default:
                break;
        }
    }

    void Scomber(Unit unit)
    {
        unit.Name = "고등어";
        unit.Hp = 30;
        unit.Atk = 5;
        unit.Def = 2;
        unit.Spd = 5;
        unit.Accuracy = 3;
        unit.Dodge = 1;

        unit.SkillList.Add(new Skill(SKillType.BodySlam));
        unit.SkillList.Add(new Skill(SKillType.Splash));
    }

    void Shark(Unit unit)
    {
        unit.Name = "상어";
        unit.Hp = 70;
        unit.Atk = 10;
        unit.Def = 3;
        unit.Spd = 10;
        unit.Accuracy = 5;
        unit.Dodge = 5;

        unit.SkillList.Add(new Skill(SKillType.BodySlam));
        unit.SkillList.Add(new Skill(SKillType.Splash));
        unit.SkillList.Add(new Skill(SKillType.WaterCanon));
    }

}