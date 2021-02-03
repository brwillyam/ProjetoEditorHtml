using System;
using System.IO;

namespace EditorTextoHtml
{
    public static class Editor
    {
       public static void Show()
       {
           Console.Clear();
           Console.BackgroundColor = ConsoleColor.White;
           Console.ForegroundColor = ConsoleColor.Black;
           Console.Clear();
           Console.WriteLine("MODO EDITOR");
           Console.WriteLine("-----------");
           Comecar();

       }

       public static void Comecar()
       {
           var arquivo ="";
            do
             {
               arquivo += (Console.ReadLine());
               arquivo +=(Environment.NewLine);

           } while(Console.ReadKey().Key != ConsoleKey.Tab);
            
           Console.WriteLine("-----------");
           Console.WriteLine("Deseja salvar o arquivo? [s/n] ");
           var res = Console.ReadLine();
            switch(res)
            {
               case "s": Salvar(arquivo); break;
               case "n": Visualizador.Show(arquivo); break;
               default:Environment.Exit(0);break;
            }        

       }
       static void Salvar(string arquivo)
        {
           
            Console.Clear();
            Console.WriteLine("Qual o caminho para salvar o arquivo?");
            var caminho = Console.ReadLine();

            using var save = new StreamWriter(caminho);
            {
                save.Write(arquivo);
            }
            Console.WriteLine($"Arquivo {caminho} salvo com sucesso!");
            Console.ReadLine();
        }
           
  
     
    }
    }