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

        static void Main(string[] args)
        {
            Console.CursorVisible = false;

            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            new SkillManager();
            createPlayer.DrawDisplay();
            intro.DrawDisplay();
            tutorial.DrawDisplay();
            story1.DrawDisplay();
        }
    }
}