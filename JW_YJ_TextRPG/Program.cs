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

        static void Main(string[] args)
        {
            createPlayer.DrawDisplay();
            intro.DrawDisplay();
            tutorial.DrawDisplay();
            story1.DrawDisplay();
        }
    }
}