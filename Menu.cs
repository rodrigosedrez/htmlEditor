namespace EditorHtml
{
    public static class Menu
    {
        public static void Show()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Black;

            DrawScreen();
            WriteOptions();

            Console.SetCursorPosition(9, 11);

            var option = short.Parse(Console.ReadLine());
            HandleMenuOption(option);
        }

        public static void spc()
        {
            Console.Write("+");
            for (int i = 0; i <= 30; i++)
                Console.Write("-");

            Console.Write("+");
            Console.Write("\n");
        }
        public static void DrawScreen()
        {
            spc();
            for (int lines = 0; lines <= 10; lines++)
            {
                Console.Write("|");
                for (int i = 0; i <= 30; i++)
                    Console.Write(" ");

                Console.Write("|");
                Console.Write("\n");
            }
            spc();
        }
        public static void WriteOptions()
        {
            Console.SetCursorPosition(10, 1);
            Console.WriteLine($"Editor de Html");
            Console.SetCursorPosition(3, 2);
            Console.WriteLine($"============================");
            Console.SetCursorPosition(1, 3);
            Console.WriteLine($"Selecione uma opções abaixo");
            Console.SetCursorPosition(2, 5);
            Console.WriteLine($"1 - Novo arquivo");
            Console.SetCursorPosition(2, 6);
            Console.WriteLine($"2 - Abrir");
            Console.SetCursorPosition(2, 10);
            Console.WriteLine($"0 - sair");
            Console.SetCursorPosition(2, 11);
            Console.WriteLine($"Opção: ");

        }
        public static void HandleMenuOption(short option)
        {
            switch (option)
            {
                case 1: Editor.Show(); break;
                case 2: Viewer.Show(""); break;
                case 0:
                    {
                        Console.Clear();
                        Environment.Exit(0);
                        break;
                    }
                default: Show(); break;
            }
        }
    }

}