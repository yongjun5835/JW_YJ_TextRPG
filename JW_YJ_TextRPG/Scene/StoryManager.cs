using JW_YJ_TextRPG;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

internal class StoryManager
{
    public int SP = 0;

    public StoryManager()
    {
        
    }

    public virtual void DrawDisplay()
    {

    }

    public void Progress()
    {
        Program.stories[SP - 1].DrawDisplay();
    }
}