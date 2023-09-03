
using JW_YJ_TextRPG;
using System.Security.Cryptography.X509Certificates;

partial class SkillManager
{
    public static SkillManager SM;

    public delegate void Event();
    public event Event roundTurn;
    public event Event finishBattle;


    public SkillManager()
    {
        SM = this;
    }

    // 턴 진행 이벤트 ex) 턴 버프
    public void TurnEvent()
    {
        if (roundTurn == null)
            return;

        roundTurn();
    }

    //디버프 모두 삭제
    public void FinishBattle()
    {
        if (finishBattle == null)
            return;
        finishBattle();
    }

    // 스킬 실수 없이 추가 하기
    public bool AddSkill(Unit unit, SKillType newtype)
    {
        int changeListNum = -1;

        // 중복 체크
        foreach (var skill in unit.SkillList)
        {
            if (newtype == skill.SkillType)
            {
                return false;
            }
        }

        // none 체크
        for (int i = 0; i < unit.SkillList.Count; i++)
        {
            if (unit.SkillList[i].SkillType != SKillType.None)
                continue;

            changeListNum = i;
            break;
        }

        // 초과 체크
        while (unit.SkillList.Count >= 4 && changeListNum == -1)
        {
            Program.ui.Popup(unit.SkillList);
            if (int.TryParse(Console.ReadLine(), out changeListNum) == false && changeListNum == -1 || changeListNum > 4)
            {
                continue;
            }

        }

        // 추가
        switch ((int)newtype)
        {
            case < 100: // 공격 스킬
                if (changeListNum == -1)
                    unit.SkillList.Add(new AttackSkill(newtype));
                else
                    unit.SkillList[changeListNum] = new AttackSkill(newtype);
                break;
            case >= 100: // 버프 스킬
                if (changeListNum == -1)
                    unit.SkillList.Add(new BuffSkill(newtype));
                else
                    unit.SkillList[changeListNum] = new BuffSkill(newtype);
                break;
        }
        return true;

    }

    // skill 생성시 데이터 입력
    public void SetSkillData(Skill skill)
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
            case SKillType.WaterPulse:
                WaterPluse(skill);
                break;
            case SKillType.IcePunch:
                IcePunch(skill);
                break;
            case SKillType.Surf:
                Surf(skill);
                break;
            case SKillType.None:
                None(skill);
                break;
            case SKillType.FastSpin: 
                FastSpin(skill);
                break;
            case SKillType.WriggleWriggleSpin: 
                WriggleWriggleSpin(skill);
                break;
            case SKillType.LookAtThisCan:
                LookAtThisCan(skill);
                break;
                case SKillType.TunaSliced: 
                TunaSliced(skill);
                break;
            default:
                break;
        }
    }

    //공격 타입별 대미지 감소
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

    // 교체만
    public void ChangeSkillList(List<Skill>List, int to, int taget)
    {
        Skill temp;

        temp = List[taget];
        List[taget] = List[to];
        List[to] = temp;
    }
}
