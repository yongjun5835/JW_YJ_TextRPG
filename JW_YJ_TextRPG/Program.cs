using System.Text;

namespace JW_YJ_TextRPG
{
    internal class Program
    {
        public static Player player = new Player(UnitType.Player);
        public static UI ui = new UI();
        public static Animation animation = new Animation();
        public static CreatePlayer createPlayer = new CreatePlayer();
        public static Intro intro = new Intro();
        public static Tutorial tutorial = new Tutorial();
        public static Story1 story1 = new Story1();
        public static Battle battle = new Battle();
        public static Unit player = new Unit(UnitType.Player);

        static void Main(string[] args)
        {
            new SkillManager();
            new UnitManager();

            Console.CursorVisible = false;

            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;


            createPlayer.DrawDisplay();
            intro.DrawDisplay();
            tutorial.DrawDisplay();
            story1.DrawDisplay();

        }

        static void TestBuff()
        {
            Unit taget = new Unit(UnitType.Scomber);
            Unit unit = new Unit(UnitType.Shark);

            int tempHp =taget.Hp;
            unit.SkillList.Add(new BuffSkill(SKillType.BiteDeep));

            taget.Def = 100;

            unit.Attack(2, taget);
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