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

    public void StartPhase()
    {
        DrawDisplay();
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

    public void DrawDisplay()
    {
        Console.Clear();
        Program.ui.DrawBox(0, 0, 60, 19, "White");
        Program.ui.DrawBox(60, 0, 60, 19, "White");
        Program.ui.DrawBox(0, 19, 120, 10, "White");
    }
}