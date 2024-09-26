namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Set the console window size
            int width = Console.LargestWindowWidth / 2;
            int height = Console.LargestWindowHeight / 2;
            Console.SetWindowSize(width, height);
            Console.SetBufferSize(width, height);

            // Draw the border   ▬▐  ▌   │    ─   └  ┘┌  ┐
            DrawBorder();

            // Prevent the console from closing immediately
            Console.ReadLine();
        }

        static void DrawBorder()
        {
            int width = Console.WindowWidth;
            int height = Console.WindowHeight;

            // Draw top border with corners
            Console.SetCursorPosition(0, 0);
            Console.Write('┌');
            Console.Write(new string('-', width - 2));
            Console.Write('┐');

            // Draw bottom border with corners
            Console.SetCursorPosition(0, height - 1);
            Console.Write('└');
            Console.Write(new string('-', width - 2));
            Console.Write('┘');

            // Draw left and right borders
            for (int i = 1; i < height - 1; i++)
            {
                Console.SetCursorPosition(0, i);
                Console.Write('|');
                Console.SetCursorPosition(width - 1, i);
                Console.Write('|');
            }
        }
    }
}
