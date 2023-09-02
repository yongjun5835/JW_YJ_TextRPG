partial class SkillManager
{

    void BodySlam(Skill skill)
    {
        skill.AttackType = AttackType.Nomal;
        skill.Name = "몸통 박치기";
        skill.Comment = "상대를 향하여 전속력 박치기를 한다.";
        skill.UseComment = ", 가라 몸통 박치기!!";
        skill.MaxPP = 20;
        skill.PP = skill.MaxPP;
        skill.Power = 0.8f;
        skill.Accuracy = 0.9f;
    }

    void TailWhip(Skill skill)
    {
        skill.AttackType = AttackType.Def;
        skill.Name = "꼬리 흔들기";
        skill.Comment = "꼬리를 흔들어 상대를 도발한다.";
        skill.UseComment = "은(는) 살랑살랑 꼬리를 흔들었다.";
        skill.Power = 1.0f;
        skill.MaxPP = 15;
        skill.PP = skill.MaxPP;
        skill.Accuracy = 1.0f;
        ((BuffSkill)skill).EffectTurn = 3;
        ((BuffSkill)skill).Percent = 0.2f;

    }

    void WaterCanon(Skill skill)
    {
        skill.AttackType = AttackType.Cut;
        skill.Name = "물 대포";
        skill.Comment = "물을 상대에게 발사한다.";
        skill.UseComment = "은(는) 물 대포를 발사했다!!.";

        skill.MaxPP = 10;
        skill.PP = skill.MaxPP;
        skill.Power = 1.4f;
        skill.Accuracy = 0.9f;
    }

    void BubbleBeam(Skill skill)
    {
        skill.AttackType = AttackType.Nomal;
        skill.Name = "거품 광선";
        skill.Comment = "거품을 상대에게 발사한다.";
        skill.UseComment = "은(는) 거품을 발사했다!!";
        skill.MaxPP = 10;
        skill.PP = skill.MaxPP;
        skill.Power = 1.0f;
        skill.Accuracy = 0.9f;
    }

    void IceBeam(Skill skill)
    {
        skill.AttackType = AttackType.Pierce;
        skill.Name = "냉동 빔";
        skill.Comment = "냉동빔을 상대에게 발사한다.";
        skill.UseComment = "의 내애앵도오오옹비이임!!";
        skill.MaxPP = 5;
        skill.PP = skill.MaxPP;
        skill.Power = 0.8f;
        skill.Accuracy = 0.9f;
    }

    void Splash(Skill skill)
    {
        skill.AttackType = AttackType.Nomal;
        skill.Name = "튀어오르기";
        skill.Comment = "공격도 하지 않고 팔딱팔딱 튈 뿐";
        skill.UseComment = "은(는) 팔딱 뛰었다. 아무 일도 없었다.";
        skill.MaxPP = 50;
        skill.PP = skill.MaxPP;
        skill.Power = 0.0f;
        skill.Accuracy = 0.0f;
    }

    void BiteDeep(Skill skill)
    {
        skill.AttackType = AttackType.Hp;
        skill.Name = "깊게 물기";
        skill.Comment = "상대에게 출혈을 유도한다.";
        skill.UseComment = "은(는) 깊게 깨물었다.";
        skill.MaxPP = 5;
        skill.PP = skill.MaxPP;
        skill.Power = 1.0f;
        skill.Accuracy = 0.7f;
        ((BuffSkill)skill).EffectTurn = 3;
        ((BuffSkill)skill).Percent = 5;
    }

    void None(Skill skill)
    {
        skill.AttackType = AttackType.Hp;
        skill.Name = "";
        skill.Comment = "";
        skill.MaxPP = 0;
        skill.PP = skill.MaxPP;
        skill.Power = 0f;
        skill.Accuracy = 0f;
    }

}
