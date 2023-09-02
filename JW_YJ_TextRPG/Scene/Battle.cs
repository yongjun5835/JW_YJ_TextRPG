using JW_YJ_TextRPG;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Battle
{
    public Battle()
    {
        
    }

    public bool isFaster = true;

    public void StartPhase(UnitType Unit)
    {
        DrawDisplay(Unit);
        Thread.Sleep(100000);
    }

    public void PlayerPhase()
    {
        
    }

    public void MonsterPhase()
    {

    }

    public void DamagePhase()
    {

    }

    public void DrawDisplay(UnitType Unit)
    {
        Console.Clear();
        Program.ui.DrawTexture(UnitType.Player, 5, 8, "White");
        Program.ui.DrawTexture(Unit, 80, 2, "White");
        Program.ui.DrawBox(0, 19, 120, 10, "White");
    }
}