using System.Text;

namespace EditorHtml
{
    public static class Editor
    {
        public static void Show()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine($"                 MODO EDITOR");
            Console.WriteLine($"                 -----------");
            Start();

        }
        public static void Start()
        {
            var file = new StringBuilder();
            do
            {
                file.Append(Console.ReadLine());
                file.Append(Environment.NewLine);

            } while (Console.ReadKey().Key != ConsoleKey.Escape);
            string novo = file.ToString();
            Console.WriteLine($"-----------");
            Viewer.Show(file.ToString());
            Salvar(novo);



        }
        public static void Salvar(string novo)
        {
            Console.WriteLine($"Você deseja salvar [S] ou [N] :");
            var resp = Console.ReadLine()?.ToLower();

            if (resp == "s")
            {

                Console.Clear();
                Console.WriteLine($"Nomeie seu arquivo colocando no final (.txt) ?");

                string path = Console.ReadLine().ToLower();

                using (var file2 = new StreamWriter(path))
                {
                    file2.Write(novo);
                }
                Console.WriteLine($"Arquivo {path} foi salvo com sucesso");

            }
            if (resp == "n")
                Menu.Show();




        }
    }
}