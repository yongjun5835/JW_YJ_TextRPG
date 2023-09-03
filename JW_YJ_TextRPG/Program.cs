using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JW_YJ_TextRPG
{
    internal class Program
    {
        public static UI ui = new UI();
        public static Animation animation = new Animation();
        public static CreatePlayer createPlayer = new CreatePlayer();
        public static Intro intro = new Intro();
        public static Tutorial tutorial = new Tutorial();
        public static Battle battle = new Battle();
        public static BossBattle bossBattle = new BossBattle();
        public static Unit player = new Unit(UnitType.Player);
        public static Hideout hideout = new Hideout();
        public static Story1 story1 = new Story1();
        public static Story2 story2 = new Story2();
        public static Story3 story3 = new Story3();
        public static Story4 story4 = new Story4();
        public static Story5 story5 = new Story5();
        public static BossStory bossStory = new BossStory();
        public static StoryManager storyManager = new StoryManager();
        public static Ending ending = new Ending();

        public static List<StoryManager> stories = new List<StoryManager>();

        static void Main(string[] args)
        {

            new SkillManager();
            new UnitManager();
            new ItemManager();

            stories.Add(story1);
            stories.Add(story2);
            stories.Add(story3);
            stories.Add(story4);
            stories.Add(bossStory);

            Console.CursorVisible = false;
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            bossStory.DrawDisplay();

            createPlayer.DrawDisplay();
        }

        static void TestBuff()
        {
            Unit taget = new Unit(UnitType.Scomber);
            Unit unit1 = new Unit(UnitType.Player);
            Unit unit2 = new Unit(UnitType.Scomber);
            Unit unit3 = new Unit(UnitType.Shark);
            Unit unit4 = new Unit(UnitType.Turtle);
            Unit unit5 = new Unit(UnitType.Angler);

            int tempHp = taget.Hp;

            SkillManager.SM.AddSkill(taget, SKillType.BubbleBeam);
            SkillManager.SM.AddSkill(taget, SKillType.IcePunch);
            SkillManager.SM.AddSkill(taget, SKillType.Surf);
            SkillManager.SM.AddSkill(taget, SKillType.WaterPulse);


            unit3.Attack(2, unit2);
            unit2.Attack(2, unit3);

            taget.Def = 100;

            Console.WriteLine($"공격한 턴 HP :{taget.Hp} / {tempHp}");
            SkillManager.SM.TurnEvent();
            Console.WriteLine($"+1 턴 HP :{taget.Hp} / {tempHp}");
            SkillManager.SM.TurnEvent();
            Console.WriteLine($"+2 턴 HP :{taget.Hp} / {tempHp}");
            SkillManager.SM.TurnEvent();
            Console.WriteLine($"+3 턴 HP :{taget.Hp} / {tempHp}");

        }

        static void DebugMod()
        {
            player = new Unit(UnitType.Debug);
        }
    }


}