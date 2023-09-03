
partial class UnitManager
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
                Player(unit);
                break;
            case UnitType.Debug:
                Debug(unit)
            case UnitType.Scomber:
                Scomber(unit);
                break;
            case UnitType.Shark:
                Shark(unit);
                break;
            case UnitType.Turtle:
                Turtle(unit);
                break;
            case UnitType.Angler:
                Angler(unit);
                break;
            default:
                break;
        }
    }
}
