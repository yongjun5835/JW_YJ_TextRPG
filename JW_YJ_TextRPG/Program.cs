namespace JW_YJ_TextRPG
{
    internal class Program
    {
        public static UI ui = new UI();
        public static Animation animation = new Animation();

        static void Main(string[] args)
        {
            animation.UnfoldScroll(0, 0);
            animation.FoldScroll(0, 0);
            ui.DrawUI(0, 0, 12, "놀라운 결과", "Gray");
            ui.DrawUI(0, 8, 12, "놀라운 결과", "");
            ui.DrawScroll(50, 0, 20, "");
            Console.SetCursorPosition(0, 20);
        }
    }
}