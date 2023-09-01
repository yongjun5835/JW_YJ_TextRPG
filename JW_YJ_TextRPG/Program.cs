namespace JW_YJ_TextRPG
{
    internal class Program
    {
        static UI ui = new UI();

        static void Main(string[] args)
        {
            ui.DrawUI(1, 0, 0, "테스트용!", "");
            ui.DrawBox(10, 10, 50, 10, "");
            Console.SetCursorPosition(0, 20);
        }
    }
}