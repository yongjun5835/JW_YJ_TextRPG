enum SKillType // 스킬 이름
{
    BodySlam =0, // 공격 스킬
    WaterCanon,
    BubbleBeam,
    IceBeam,
    Splash,
    WaterPulse = 10,
    IcePunch,
    Surf,
    FastSpin = 50, // 플레이어 스킬
    WriggleWriggleSpin,
    TunaSliced,
    TailWhip = 100, // 버프 스킬
    LookAtThisCan,
    BiteDeep,
    LookAtThisCan,

    None
}

enum AttackType // 공격 방식
{
    Nomal = 0, // 일반 공격
    Pierce, // 방어력 일부 무시
    Cut, // 방어력이 약한 상대
    Hp = 10,// 디버프 Hp는 도트딜
    Atk, 
    Def
}

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

    void WaterPluse(Skill skill)
    {
        skill.AttackType = AttackType.Nomal;
        skill.Name = "물의 파동";
        skill.Comment = "물의 진동으로 상대에게 공격한다.";
        skill.UseComment = "은(는) 물에 진동을 일으켰다.";
        skill.MaxPP = 20;
        skill.PP = skill.MaxPP;
        skill.Power = 1.2f;
        skill.Accuracy = 0.9f;

    }

    void IcePunch(Skill skill)
    {
        skill.AttackType = AttackType.Nomal;
        skill.Name = "냉동 펀치";
        skill.Comment = "냉기를 담은 펀치로 상대를 공격한다.";
        skill.UseComment = "은(는) 지느러미에 냉기를 담았다.";
        skill.MaxPP = 10;
        skill.PP = skill.MaxPP;
        skill.Power = 1.0f;
        skill.Accuracy = 1.1f;
    }

    void Surf(Skill skill)
    {
        skill.AttackType = AttackType.Nomal;
        skill.Name = "파도 타기";
        skill.Comment = "큰 파도를 일으켜 상대를 공격한다.";
        skill.UseComment = "은(는) 파도를 일으켰다.";
        skill.MaxPP = 15;
        skill.PP = skill.MaxPP;
        skill.Power = 0.9f;
        skill.Accuracy = 1.0f;
    }

    void FastSpin(Skill skill)
    {
        skill.AttackType = AttackType.Nomal;
        skill.Name = "빨리 감기";
        skill.Comment = "낚시줄을 감아 상대를 공격한다.";
        skill.UseComment = "은(는) 줄을 감았다.";
        skill.MaxPP = 20;
        skill.PP = skill.MaxPP;
        skill.Power = 0.8f;
        skill.Accuracy = 1.0f;
    }

    void WriggleWriggleSpin(Skill skill)
    {
        skill.AttackType = AttackType.Cut;
        skill.Name = "빨리 감기";
        skill.Comment = "낚시줄을 빨리 상대를 공격한다.";
        skill.UseComment = "은(는) 줄을 빨리 감았다.";
        skill.MaxPP = 10;
        skill.PP = skill.MaxPP;
        skill.Power = 1.2f;
        skill.Accuracy = 0.8f;
    }

    void LookAtThisCan(Skill skill)
    {
        skill.AttackType = AttackType.Def;
        skill.Name = "통조림 개봉";
        skill.Comment = "통조림 개봉하여 충격을 줍니다.";
        skill.UseComment = "은(는) 통조림을 열었다.";
        skill.MaxPP = 10;
        skill.PP = skill.MaxPP;
        skill.Power = 1.0f;
        skill.Accuracy = 1.0f;
        ((BuffSkill)skill).EffectTurn = 3;
        ((BuffSkill)skill).Percent = 0.3f;
    }

    void TunaSliced(Skill skill)
    {
        skill.AttackType = AttackType.Pierce;
        skill.Name = "회 썰기";
        skill.Comment = "좋은 회칼로 회를 떠 공격한다.";
        skill.UseComment = "은(는) 회를 썰었다.";
        skill.MaxPP = 10;
        skill.PP = skill.MaxPP;
        skill.Power = 1.4f;
        skill.Accuracy = 1.0f;
    }
    void None(Skill skill) 
    {
        skill.AttackType = AttackType.Nomal;
        skill.Name = "";
        skill.Comment = "";
        skill.MaxPP = 0;
        skill.PP = skill.MaxPP;
        skill.Power = 0f;
        skill.Accuracy = 0f;
    }



}
