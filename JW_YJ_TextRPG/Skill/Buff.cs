class Buff
{
    AttackType atkType;
    Unit taget;
    int effectTurn;
    int buffValue;

    float initialValue;
    bool isEffectOn = true;

    public int EffectTurn
    {
        get { return effectTurn; }
        set
        {
            effectTurn = value;
            if (effectTurn <= 0 && isEffectOn == true)
            {
                EffectOff();
            }
        }
    }

    // 
    public Buff(Unit taget, int effectTurn, AttackType atkType, float percent)
    {
        initialValue = percent;
        this.effectTurn = effectTurn;
        this.taget = taget;
        this.atkType = atkType;

        if (HaveSameEffect() == true) // 중복 효과 체크
        {
            return;
        }

        switch (atkType)
        {
            case AttackType.Hp:
                buffValue = (int)percent;
                taget.Hp -= buffValue;
                break;
            case AttackType.Atk:
                buffValue = (int)(taget.Atk*percent);
                taget.Atk -= buffValue;
                break;
            case AttackType.Def:
                buffValue = (int)(taget.Def*percent);
                taget.Def -= buffValue;
                break;
            default:
                Console.WriteLine("AttackType enum 위치 오류");
                Console.ReadLine();
                break;
        }

        taget.BuffList.Add(this);
        SkillManager.SM.roundTurn += this.DecreaseTurn;
        SkillManager.SM.finishBattle += this.EffectOff;
    }

    // 이펙트 강제 종료
    public void EffectOff()
    {
        isEffectOn = false;

        switch (atkType)
        {
            case AttackType.Hp:
                effectTurn = 0;
                break;
            case AttackType.Atk:
                effectTurn = 0;
                taget.Atk += buffValue;
                break;
            case AttackType.Def:
                taget.Def += buffValue;
                break;
        }
        foreach (var buff in taget.BuffList)
        {
            if (buff == this)
            {
                taget.BuffList.Remove(this);
                SkillManager.SM.roundTurn -= this.DecreaseTurn;
                break;
            }
        }
    }

    // 1턴 제거
    public void DecreaseTurn()
    {
        EffectTurn--;
        if (atkType == AttackType.Hp && isEffectOn ==true)
        {
            taget.Hp -= buffValue;
        }
    }

    // 중복 효과는 기간만 연장
    bool HaveSameEffect() 
    {
        foreach (var buff in taget.BuffList)
        {
            if (buff.atkType != this.atkType)
                return false;
            if (buff.initialValue != this.initialValue)
                return false;

            buff.EffectTurn += effectTurn;
            return true;

        }
        return false;
    }
}
