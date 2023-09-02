partial class UnitManager
{

    void Player(Unit unit)
    {
        unit.Hp = 30;
        unit.MaxHp = 30;
        unit.Atk = 15;
        unit.Def = 2;
        unit.Spd = 5;
        unit.Accuracy = 3;
        unit.Dodge = 1;

        SkillManager.SM.AddSkill(unit, SKillType.BodySlam);
        SkillManager.SM.AddSkill(unit, SKillType.TailWhip);
        unit.SkillList.Add(new AttackSkill(SKillType.None));
        unit.SkillList.Add(new AttackSkill(SKillType.None));
    }

    void Scomber(Unit unit)
    {
        unit.Name = "고등어";
        unit.Hp = 30;
        unit.MaxHp = 30;
        unit.Atk = 5;
        unit.Def = 2;
        unit.Spd = 5;
        unit.Accuracy = 3;
        unit.Dodge = 1;


        SkillManager.SM.AddSkill(unit, SKillType.BodySlam);
        SkillManager.SM.AddSkill(unit, SKillType.Splash);
    }

    void Shark(Unit unit)
    {
        unit.Name = "상어";
        unit.Hp = 90;
        unit.MaxHp = 90;
        unit.Atk = 10;
        unit.Def = 3;
        unit.Spd = 10;
        unit.Accuracy = 5;
        unit.Dodge = 5;

        SkillManager.SM.AddSkill(unit, SKillType.BodySlam);
        SkillManager.SM.AddSkill(unit, SKillType.TailWhip);
        SkillManager.SM.AddSkill(unit, SKillType.WaterCanon);
    }

    void Turtle(Unit unit)
    {
        unit.Name = "거북이";
        unit.Hp = 150;
        unit.MaxHp = 150;
        unit.Atk = 5;
        unit.Def = 10;
        unit.Spd = 1;
        unit.Accuracy = 1;
        unit.Dodge = 1;

        SkillManager.SM.AddSkill(unit, SKillType.BodySlam);
        SkillManager.SM.AddSkill(unit, SKillType.TailWhip);
        SkillManager.SM.AddSkill(unit, SKillType.BubbleBeam);
    }

    void Angler(Unit unit)
    {
        unit.Name = "낚시꾼";
        unit.Hp = 210;
        unit.MaxHp = 210;
        unit.Atk = 20;
        unit.Def = 5;
        unit.Spd = 10;
        unit.Accuracy = 5;
        unit.Dodge = 5;

        SkillManager.SM.AddSkill(unit, SKillType.BodySlam);
        SkillManager.SM.AddSkill(unit, SKillType.TailWhip);
        SkillManager.SM.AddSkill(unit, SKillType.WaterCanon);
    }
}