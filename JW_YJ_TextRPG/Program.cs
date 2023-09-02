namespace JW_YJ_TextRPG
{
    internal class Program
    {
        public static UI ui = new UI();
        public static Animation animation = new Animation();
        public static CreatePlayer createPlayer = new CreatePlayer();
        public static Intro intro = new Intro();

        static void Main(string[] args)
        {
            new SkillManager();

            //createPlayer.DrawDisplay();
            //intro.DrawDisplay();

            Unit unit = new Unit();
            Unit unit1 = new Unit();

            unit.Attack(0, unit1);
            unit1.Attack(3, unit);
        }
    }
}