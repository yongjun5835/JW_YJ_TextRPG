class Buff
{
    Unit taget;
    AttackType atkType;
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
        this.effectTurn = effectTurn;
        this.taget = taget;
        this.atkType = atkType;

        switch (atkType)
        {
            case AttackType.Atk:
                buffValue = taget.Atk - (int)(taget.Atk * percent);
                taget.Atk -= buffValue;
                break;
            case AttackType.Def:
                buffValue = taget.Def - (int)(taget.Def * percent);
                taget.Def -= buffValue;
                break;
            default:
                Console.WriteLine("디버프 어택 타입 오류입니다.");
                Console.ReadLine();
                break;
        }
    }

    void EffectOff()
    {
        switch (atkType)
        {
            case AttackType.Atk:
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
                break;
            }
        }
    }

}
