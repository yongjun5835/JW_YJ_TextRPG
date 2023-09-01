namespace JW_YJ_TextRPG
{
    internal class Program
    {
        static UI ui = new UI();

        static void Main(string[] args)
        {
            ui.DrawUI(0, 0, 12, "놀라운 결과", "Gray");
            ui.DrawUI(0, 8, 12, "놀라운 결과", "White");
            ui.DrawScroll(50, 0, 20, "");
            Console.SetCursorPosition(0, 20);
        }
    }
}