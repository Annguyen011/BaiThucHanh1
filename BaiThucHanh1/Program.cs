// See https://aka.ms/new-console-template for more information

namespace SnakeGame
{
    class Program
    {
        static void Write(int row, int col, string content)
        {
            Console.SetCursorPosition(col, row);
            Console.Write(content);
        }

        static void DrawBorder(int width, int height)
        {
            for (int i = 0; i < height; i++)
            {
                if (i == 0 || i == height - 1)
                {
                    for (int j = 0; j < width; j++)
                    {
                        Write(i, j, "*");
                    }
                }
                else
                {
                    Write(i, 0, "*");
                    Write(i, width, "*");
                }
            }
        }

        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White; // đặt màu cho rắn
            Console.BackgroundColor = ConsoleColor.DarkBlue; // đặt màu cho mồi
            Console.Clear();
            int width = 20;
            int height = 10;
            DrawBorder(width, height);
            Write(10, 20, "o");

            bool isOver = false;
            int x = 1;
            int y = 1;
            while (!isOver)
            {
                ConsoleKeyInfo keyInfo = Console.ReadKey();
                Write(y, x, " ");
                switch (keyInfo.Key)
                {
                    case ConsoleKey.DownArrow:
                        if (y < height - 2) y++;
                        break;
                    case ConsoleKey.UpArrow:
                        if (y > 1) y--;
                        break;
                    case ConsoleKey.LeftArrow:
                        if (x > 1) x--;
                        break;
                    case ConsoleKey.RightArrow:
                        if (x < width - 2) x++;
                        break;
                    case ConsoleKey.Escape:
                        isOver = true;
                        break;
                }

                Write(y, x, "o");
            }

            Console.WriteLine("Ket thuc tro choi!");
        }
    }
}