namespace JW_YJ_TextRPG
{
    internal class Program
    {
        public static UI ui = new UI();
        public static Animation animation = new Animation();
        public static CreatePlayer createPlayer = new CreatePlayer();

        static void Main(string[] args)
        {
            animation.DrawTextSlowly(0, 0, "김치를 맛있게 먹는 방법은 고구마와 같이 먹는 것이다.", "Blue");
            animation.FadeInOut(42, 10, 14, "반가워");
            createPlayer.DrawDisplay();
            Console.SetCursorPosition(0, 20);
        }
    }
}