using System.Text.RegularExpressions;

namespace EditorHtml
{
  public class Viewer 
  {  
     public static void Show(string text){
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine($"                 MODO VISUALIZADOR");
            Console.WriteLine($"                 -----------------");
            Replace(text);
            Console.WriteLine($"\n                 -----------------");
            Console.ReadKey();
            
            
    }
    public static void Replace(string text)
    {

        var azul = new Regex(@"<\a*azul[^>]*>(.*?)<\a*/\a*azul>");
        var amarelo = new Regex(@"<\a*amarelo[^>]*>(.*?)<\a*/\a*amarelo>");
        var words = text.Split(' ');

        for (var i =0; i < words.Length; i++)
        {    
            if (azul.IsMatch(words[i]))
            {
                Console.ForegroundColor = ConsoleColor.Blue;  
                Console.Write(
                    words[i].Substring(
                        words[i].IndexOf('>') + 1,
                        (
                           ( words[i].LastIndexOf('<') - 1) -
                            words[i].IndexOf('>')
                        )         
                ) 
                );
                Console.Write(" ");    
            }
            if(amarelo.IsMatch(words[i])){
                  Console.BackgroundColor = ConsoleColor.Yellow;
                  Console.ForegroundColor = ConsoleColor.Black;  
                Console.Write(
                    words[i].Substring(
                        words[i].IndexOf('>') + 1,
                        (
                           ( words[i].LastIndexOf('<') - 1) -
                            words[i].IndexOf('>')
                        )         
                ) 
                );
                Console.Write(" ");   
            }
             else {
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Write(words[i]);
                Console.Write(" ");
            }
        }
        Console.BackgroundColor = ConsoleColor.White;
        Console.ForegroundColor = ConsoleColor.Black;
    }
}

   
}