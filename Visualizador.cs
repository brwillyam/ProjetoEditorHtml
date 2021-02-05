using System;
using System.Text.RegularExpressions;

namespace EditorTextoHtml
{
    public class Visualizador
    {
        public static void Show(string arquivo)
        {
             Console.Clear();
           Console.BackgroundColor = ConsoleColor.White;
           Console.ForegroundColor = ConsoleColor.Black;
           Console.Clear();
           Console.WriteLine("MODO VISUALIZAÇÃO");
           Console.WriteLine("-----------------");
           Replace(arquivo);
           Console.WriteLine("-----------------");
           Console.ReadKey();
           Menu.Show();
        
        }

        public static void Replace(string arquivo)
        {
            var strong = new Regex(@"<\s*strong[^>]*>(.*?)<\s*/\s*strong>");
            var words = arquivo.Split(' ');

            for(var i = 0; i < words.Length; i++)
            {
                if (strong.IsMatch(words[i]))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(
                        words[i].Substring(                    
                            words[i].IndexOf('>') + 1,
                                ( 
                                   (words[i].LastIndexOf('<') - 1) -
                                    words[i].IndexOf('>')
                                   )
                            )
                     );
                    Console.Write(" ");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write(words[i]);
                    Console.Write(" ");
                }       
            }
        }       



    }
}