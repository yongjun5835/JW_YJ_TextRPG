class Buff
{
    AttackType atkType;
    Unit taget;
    int effectTurn;
    int buffValue;
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

    public Buff(Unit taget, int effectTurn, AttackType atkType, float percent)
    {
        SkillManager.SM.RoundTurn += this.DecreaseTurn;
        taget.BuffList.Add(this);
        this.effectTurn = effectTurn;
        this.taget = taget;
        this.atkType = atkType;

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
                Console.WriteLine("디버프 어택 타입 오류입니다.");
                Console.ReadLine();
                break;
        }
    }

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
                SkillManager.SM.RoundTurn -= this.DecreaseTurn;
                break;
            }
        }
    }

    public void DecreaseTurn()
    {
        EffectTurn--;
        if (atkType == AttackType.Hp && isEffectOn ==true)
        {
            taget.Hp -= buffValue;
        }
    }
}
