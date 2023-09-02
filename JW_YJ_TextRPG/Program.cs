namespace JW_YJ_TextRPG
{
    internal class Program
    {
        public static UI ui = new UI();
        public static Animation animation = new Animation();

        static void Main(string[] args)
        {
            animation.DrawTextSlowly(0, 0, "김치를 맛있게 먹는 방법은 고구마와 같이 먹는 것이다.", "Blue");
            animation.UnfoldScroll(0, 0);
            animation.FoldScroll(0, 0);
            animation.FadeInOut(0, 0, 14, "반가워");
            Console.SetCursorPosition(0, 20);
        }
    }
}