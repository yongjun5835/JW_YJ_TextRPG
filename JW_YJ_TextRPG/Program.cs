using System.Text;

namespace JW_YJ_TextRPG
{
    internal class Program
    {
        public static UI ui = new UI();
        public static Animation animation = new Animation();
        public static CreatePlayer createPlayer = new CreatePlayer();
        public static Intro intro = new Intro();
        public static Tutorial tutorial = new Tutorial();
        public static Story1 story1 = new Story1();
        public static Battle battle = new Battle();
        public static Unit player = new Unit(UnitType.Player);
        public static Hideout hideout = new Hideout();

        static void Main(string[] args)
        {
            new SkillManager();
            new UnitManager();

            Console.CursorVisible = false;
            TestBuff();
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            hideout.DrawDisplay();
            createPlayer.DrawDisplay();
            if (player.Habitat == "태평양")
            {
                player.Def = 10;
            }
            else if (player.Habitat == "대서양")
            {
                player.Def = 5;
            }
            else  if (player.Habitat == "인도양")
            {
                player.Def = 1;
            }

            if (player.Grow == "치어")
            {
                player.MaxHp = 30;
                player.Hp = 30;
                player.Spd = 5;
            }
            else if (player.Grow == "유어")
            {
                player.MaxHp = 60;
                player.Hp = 60;
                player.Spd = 3;
            }
            else if (player.Grow == "성어")
            {
                player.MaxHp = 90;
                player.Hp = 90;
                player.Spd = 1;
            }

            intro.DrawDisplay();
            tutorial.DrawDisplay();
            story1.DrawDisplay();
        }

        static void TestBuff()
        {
            Unit taget = new Unit(UnitType.Scomber);
            Unit unit1 = new Unit(UnitType.Player);
            Unit unit2 = new Unit(UnitType.Scomber);
            Unit unit3 = new Unit(UnitType.Shark);
            Unit unit4 = new Unit(UnitType.Turtle);
            Unit unit5 = new Unit(UnitType.Angler);

            int tempHp =taget.Hp;

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
    }


}